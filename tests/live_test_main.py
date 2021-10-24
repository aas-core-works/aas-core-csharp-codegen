"""
Transpile the meta-model into C# and compile them into a project.

This live tests expects dotnet to be installed on the machine.
"""
import io
import os
import pathlib
import subprocess
import sys
import tempfile
import textwrap

import aas_core_csharp_codegen.main


def main() -> int:
    """Execute the main routine."""
    print("Running dotnet --version to check that dotnet is available...")
    run = subprocess.run(
        ['dotnet', '--version'], stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    if run.returncode != 0:
        print(
            f"Failed to execute ``dotnet --version`` "
            f"with the exit code {run.returncode}. Is dotnet installed?",
            file=sys.stderr)
        return 1

    with tempfile.TemporaryDirectory() as tmp_dir:
        repo_dir = pathlib.Path(os.path.realpath(__file__)).parent.parent

        # TODO: remove
        (repo_dir/"deleteme").mkdir(exist_ok=True,parents=True)
        tmp_dir = str(repo_dir / "deleteme/expected_output")

        parent_case_dir = repo_dir / "test_data" / "test_main"
        assert parent_case_dir.exists() and parent_case_dir.is_dir(), parent_case_dir

        for case_dir in parent_case_dir.iterdir():
            assert case_dir.is_dir(), case_dir

            model_pth = case_dir / "input/meta_model.py"
            assert model_pth.exists() and model_pth.is_file(), model_pth

            snippets_dir = case_dir / "input/snippets"
            assert snippets_dir.exists() and snippets_dir.is_dir(), snippets_dir

            namespace_pth = case_dir / "input/namespace.txt"
            assert namespace_pth.exists() and namespace_pth.is_file(), namespace_pth
            namespace = (case_dir / "input/namespace.txt").read_text()

            output_dir = pathlib.Path(tmp_dir) / case_dir.name

            print(
                f"Generating the files based on the case {case_dir} "
                f"to: {output_dir} ...")

            output_dir.mkdir(exist_ok=True, parents=True)
            params = aas_core_csharp_codegen.main.Parameters(
                model_path=model_pth,
                snippets_dir=snippets_dir,
                namespace=namespace,
                output_dir=output_dir)

            stdout = io.StringIO()
            stderr = io.StringIO()

            return_code = aas_core_csharp_codegen.main.run(
                params=params, stdout=stdout, stderr=stderr)

            assert stderr.getvalue() == "", (
                f"Expected no stderr on valid models, but got:\n{stderr.getvalue()}")

            assert return_code == 0, (
                f"Expected return code 0 on valid models, but got: {return_code}")

            print("Generating the .csproj file...")
            csproj_pth = output_dir / "SomeProject.csproj"
            csproj_pth.write_text(textwrap.dedent('''\
                <Project Sdk="Microsoft.NET.Sdk">
                    <PropertyGroup>
                        <TargetFrameworks>net5.0;netstandard2.1;netstandard2.0</TargetFrameworks>
                        <Nullable>enable</Nullable>
                        <Configurations>Debug;Release;DebugSlow</Configurations>
                        <Platforms>AnyCPU</Platforms>
                        <LangVersion>8</LangVersion>
                    </PropertyGroup>
                </Project>
                '''))

            print("Calling dotnet build...")
            run = subprocess.run(
                ['dotnet', 'build', '.'], cwd=str(output_dir))
            assert run.returncode == 0, (
                f"Expected the build to succeed, but got exit code: {run.returncode}")


if __name__ == "__main__":
    sys.exit(main())