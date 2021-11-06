/*
 * This code has been automatically generated by aas-core-csharp-codegen.
 * Do NOT edit or append.
 */

using System.Collections.Generic;  // can't alias

using Aas = AasCore.Aas3;

namespace AasCore.Aas3
{
    public static class Stringification
    {
        private static readonly Dictionary<Aas.IdentifierType, string> _identifierTypeToString = (
            new Dictionary<Aas.IdentifierType, string>()
            {
                { Aas.IdentifierType.Irdi, "IRDI" },
                { Aas.IdentifierType.Iri, "IRI" },
                { Aas.IdentifierType.Custom, "Custom" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.IdentifierType that)
        {
            if (_identifierTypeToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.IdentifierType> _identifierTypeFromString = (
            new Dictionary<string, Aas.IdentifierType>()
            {
                { "IRDI", Aas.IdentifierType.Irdi },
                { "IRI", Aas.IdentifierType.Iri },
                { "Custom", Aas.IdentifierType.Custom }
            });

        /// <summary>
        /// Parse the string representation of <see cref="IdentifierType" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="IdentifierType" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.IdentifierType? IdentifierTypeFromString(string text)
        {
            if (_identifierTypeFromString.TryGetValue(text, out IdentifierType value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.ModelingKind, string> _modelingKindToString = (
            new Dictionary<Aas.ModelingKind, string>()
            {
                { Aas.ModelingKind.Template, "Template" },
                { Aas.ModelingKind.Instance, "Instance" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.ModelingKind that)
        {
            if (_modelingKindToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.ModelingKind> _modelingKindFromString = (
            new Dictionary<string, Aas.ModelingKind>()
            {
                { "Template", Aas.ModelingKind.Template },
                { "Instance", Aas.ModelingKind.Instance }
            });

        /// <summary>
        /// Parse the string representation of <see cref="ModelingKind" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="ModelingKind" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.ModelingKind? ModelingKindFromString(string text)
        {
            if (_modelingKindFromString.TryGetValue(text, out ModelingKind value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.LocalKeyType, string> _localKeyTypeToString = (
            new Dictionary<Aas.LocalKeyType, string>()
            {
                { Aas.LocalKeyType.IdShort, "IdShort" },
                { Aas.LocalKeyType.FragmentId, "FragmentId" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.LocalKeyType that)
        {
            if (_localKeyTypeToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.LocalKeyType> _localKeyTypeFromString = (
            new Dictionary<string, Aas.LocalKeyType>()
            {
                { "IdShort", Aas.LocalKeyType.IdShort },
                { "FragmentId", Aas.LocalKeyType.FragmentId }
            });

        /// <summary>
        /// Parse the string representation of <see cref="LocalKeyType" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="LocalKeyType" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.LocalKeyType? LocalKeyTypeFromString(string text)
        {
            if (_localKeyTypeFromString.TryGetValue(text, out LocalKeyType value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.KeyType, string> _keyTypeToString = (
            new Dictionary<Aas.KeyType, string>()
            {
                { Aas.KeyType.IdShort, "IdShort" },
                { Aas.KeyType.FragmentId, "FragmentId" },
                { Aas.KeyType.Custom, "Custom" },
                { Aas.KeyType.Irdi, "IRDI" },
                { Aas.KeyType.Iri, "IRI" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.KeyType that)
        {
            if (_keyTypeToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.KeyType> _keyTypeFromString = (
            new Dictionary<string, Aas.KeyType>()
            {
                { "IdShort", Aas.KeyType.IdShort },
                { "FragmentId", Aas.KeyType.FragmentId },
                { "Custom", Aas.KeyType.Custom },
                { "IRDI", Aas.KeyType.Irdi },
                { "IRI", Aas.KeyType.Iri }
            });

        /// <summary>
        /// Parse the string representation of <see cref="KeyType" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="KeyType" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.KeyType? KeyTypeFromString(string text)
        {
            if (_keyTypeFromString.TryGetValue(text, out KeyType value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.IdentifiableElements, string> _identifiableElementsToString = (
            new Dictionary<Aas.IdentifiableElements, string>()
            {
                { Aas.IdentifiableElements.Asset, "Asset" },
                { Aas.IdentifiableElements.AssetAdministrationShell, "AssetAdministrationShell" },
                { Aas.IdentifiableElements.ConceptDescription, "ConceptDescription" },
                { Aas.IdentifiableElements.Submodel, "Submodel" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.IdentifiableElements that)
        {
            if (_identifiableElementsToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.IdentifiableElements> _identifiableElementsFromString = (
            new Dictionary<string, Aas.IdentifiableElements>()
            {
                { "Asset", Aas.IdentifiableElements.Asset },
                { "AssetAdministrationShell", Aas.IdentifiableElements.AssetAdministrationShell },
                { "ConceptDescription", Aas.IdentifiableElements.ConceptDescription },
                { "Submodel", Aas.IdentifiableElements.Submodel }
            });

        /// <summary>
        /// Parse the string representation of <see cref="IdentifiableElements" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="IdentifiableElements" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.IdentifiableElements? IdentifiableElementsFromString(string text)
        {
            if (_identifiableElementsFromString.TryGetValue(text, out IdentifiableElements value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.ReferableElements, string> _referableElementsToString = (
            new Dictionary<Aas.ReferableElements, string>()
            {
                { Aas.ReferableElements.AccessPermissionRule, "AccessPermissionRule" },
                { Aas.ReferableElements.AnnotatedRelationshipElement, "AnnotatedRelationshipElement" },
                { Aas.ReferableElements.Asset, "Asset" },
                { Aas.ReferableElements.AssetAdministrationShell, "AssetAdministrationShell" },
                { Aas.ReferableElements.BasicEvent, "BasicEvent" },
                { Aas.ReferableElements.Blob, "Blob" },
                { Aas.ReferableElements.Capability, "Capability" },
                { Aas.ReferableElements.ConceptDescription, "ConceptDescription" },
                { Aas.ReferableElements.ConceptDictionary, "ConceptDictionary" },
                { Aas.ReferableElements.DataElement, "DataElement" },
                { Aas.ReferableElements.Entity, "Entity" },
                { Aas.ReferableElements.Event, "Event" },
                { Aas.ReferableElements.File, "File" },
                { Aas.ReferableElements.MultiLanguageProperty, "MultiLanguageProperty" },
                { Aas.ReferableElements.Operation, "Operation" },
                { Aas.ReferableElements.Property, "Property" },
                { Aas.ReferableElements.Range, "Range" },
                { Aas.ReferableElements.ReferenceElement, "ReferenceElement" },
                { Aas.ReferableElements.RelationshipElement, "RelationshipElement" },
                { Aas.ReferableElements.Submodel, "Submodel" },
                { Aas.ReferableElements.SubmodelElement, "SubmodelElement" },
                { Aas.ReferableElements.SubmodelElementCollection, "SubmodelElementCollection" },
                { Aas.ReferableElements.View, "View" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.ReferableElements that)
        {
            if (_referableElementsToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.ReferableElements> _referableElementsFromString = (
            new Dictionary<string, Aas.ReferableElements>()
            {
                { "AccessPermissionRule", Aas.ReferableElements.AccessPermissionRule },
                { "AnnotatedRelationshipElement", Aas.ReferableElements.AnnotatedRelationshipElement },
                { "Asset", Aas.ReferableElements.Asset },
                { "AssetAdministrationShell", Aas.ReferableElements.AssetAdministrationShell },
                { "BasicEvent", Aas.ReferableElements.BasicEvent },
                { "Blob", Aas.ReferableElements.Blob },
                { "Capability", Aas.ReferableElements.Capability },
                { "ConceptDescription", Aas.ReferableElements.ConceptDescription },
                { "ConceptDictionary", Aas.ReferableElements.ConceptDictionary },
                { "DataElement", Aas.ReferableElements.DataElement },
                { "Entity", Aas.ReferableElements.Entity },
                { "Event", Aas.ReferableElements.Event },
                { "File", Aas.ReferableElements.File },
                { "MultiLanguageProperty", Aas.ReferableElements.MultiLanguageProperty },
                { "Operation", Aas.ReferableElements.Operation },
                { "Property", Aas.ReferableElements.Property },
                { "Range", Aas.ReferableElements.Range },
                { "ReferenceElement", Aas.ReferableElements.ReferenceElement },
                { "RelationshipElement", Aas.ReferableElements.RelationshipElement },
                { "Submodel", Aas.ReferableElements.Submodel },
                { "SubmodelElement", Aas.ReferableElements.SubmodelElement },
                { "SubmodelElementCollection", Aas.ReferableElements.SubmodelElementCollection },
                { "View", Aas.ReferableElements.View }
            });

        /// <summary>
        /// Parse the string representation of <see cref="ReferableElements" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="ReferableElements" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.ReferableElements? ReferableElementsFromString(string text)
        {
            if (_referableElementsFromString.TryGetValue(text, out ReferableElements value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<Aas.KeyElements, string> _keyElementsToString = (
            new Dictionary<Aas.KeyElements, string>()
            {
                { Aas.KeyElements.GlobalReference, "GlobalReference" },
                { Aas.KeyElements.FragmentReference, "FragmentReference" },
                { Aas.KeyElements.AccessPermissionRule, "AccessPermissionRule" },
                { Aas.KeyElements.AnnotatedRelationshipElement, "AnnotatedRelationshipElement" },
                { Aas.KeyElements.Asset, "Asset" },
                { Aas.KeyElements.AssetAdministrationShell, "AssetAdministrationShell" },
                { Aas.KeyElements.BasicEvent, "BasicEvent" },
                { Aas.KeyElements.Blob, "Blob" },
                { Aas.KeyElements.Capability, "Capability" },
                { Aas.KeyElements.ConceptDescription, "ConceptDescription" },
                { Aas.KeyElements.ConceptDictionary, "ConceptDictionary" },
                { Aas.KeyElements.DataElement, "DataElement" },
                { Aas.KeyElements.Entity, "Entity" },
                { Aas.KeyElements.Event, "Event" },
                { Aas.KeyElements.File, "File" },
                { Aas.KeyElements.MultiLanguageProperty, "MultiLanguageProperty" },
                { Aas.KeyElements.Operation, "Operation" },
                { Aas.KeyElements.Property, "Property" },
                { Aas.KeyElements.Range, "Range" },
                { Aas.KeyElements.ReferenceElement, "ReferenceElement" },
                { Aas.KeyElements.RelationshipElement, "RelationshipElement" },
                { Aas.KeyElements.Submodel, "Submodel" },
                { Aas.KeyElements.SubmodelElement, "SubmodelElement" },
                { Aas.KeyElements.SubmodelElementCollection, "SubmodelElementCollection" },
                { Aas.KeyElements.View, "View" }
            });

        /// <summary>
        /// Retrieve the string representation of <paramref name="that" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="that" /> is not a valid literal, return <c>null</c>.
        /// </remarks>
        public static string? ToString(Aas.KeyElements that)
        {
            if (_keyElementsToString.TryGetValue(that, out string? value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private static readonly Dictionary<string, Aas.KeyElements> _keyElementsFromString = (
            new Dictionary<string, Aas.KeyElements>()
            {
                { "GlobalReference", Aas.KeyElements.GlobalReference },
                { "FragmentReference", Aas.KeyElements.FragmentReference },
                { "AccessPermissionRule", Aas.KeyElements.AccessPermissionRule },
                { "AnnotatedRelationshipElement", Aas.KeyElements.AnnotatedRelationshipElement },
                { "Asset", Aas.KeyElements.Asset },
                { "AssetAdministrationShell", Aas.KeyElements.AssetAdministrationShell },
                { "BasicEvent", Aas.KeyElements.BasicEvent },
                { "Blob", Aas.KeyElements.Blob },
                { "Capability", Aas.KeyElements.Capability },
                { "ConceptDescription", Aas.KeyElements.ConceptDescription },
                { "ConceptDictionary", Aas.KeyElements.ConceptDictionary },
                { "DataElement", Aas.KeyElements.DataElement },
                { "Entity", Aas.KeyElements.Entity },
                { "Event", Aas.KeyElements.Event },
                { "File", Aas.KeyElements.File },
                { "MultiLanguageProperty", Aas.KeyElements.MultiLanguageProperty },
                { "Operation", Aas.KeyElements.Operation },
                { "Property", Aas.KeyElements.Property },
                { "Range", Aas.KeyElements.Range },
                { "ReferenceElement", Aas.KeyElements.ReferenceElement },
                { "RelationshipElement", Aas.KeyElements.RelationshipElement },
                { "Submodel", Aas.KeyElements.Submodel },
                { "SubmodelElement", Aas.KeyElements.SubmodelElement },
                { "SubmodelElementCollection", Aas.KeyElements.SubmodelElementCollection },
                { "View", Aas.KeyElements.View }
            });

        /// <summary>
        /// Parse the string representation of <see cref="KeyElements" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="text" /> is not a valid string representation 
        /// of a literal of <see cref="KeyElements" />, 
        /// return <c>null</c>.
        /// </remarks>
        public static Aas.KeyElements? KeyElementsFromString(string text)
        {
            if (_keyElementsFromString.TryGetValue(text, out KeyElements value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
    }  // public static class Stringification
}  // namespace AasCore.Aas3

/*
 * This code has been automatically generated by aas-core-csharp-codegen.
 * Do NOT edit or append.
 */