/*
 * This code has been automatically generated by aas-core-codegen.
 * Do NOT edit or append.
 */

package aas_core.aas3_0.enhancing;

import java.lang.Iterable;
import java.util.Optional;
import java.util.List;
import aas_core.aas3_0.visitation.IVisitor;
import aas_core.aas3_0.visitation.IVisitorWithContext;
import aas_core.aas3_0.visitation.ITransformer;
import aas_core.aas3_0.visitation.ITransformerWithContext;
import aas_core.aas3_0.types.enums.*;
import aas_core.aas3_0.types.impl.*;
import aas_core.aas3_0.types.model.*;

public class EnhancedEventPayload<EnhancementT>
  extends Enhanced<EnhancementT>
  implements IEventPayload {
  private final IEventPayload instance;

  public EnhancedEventPayload(
    IEventPayload instance,
    EnhancementT enhancement
  ) {
    super(enhancement);
    this.instance = instance;
  }

  @Override
  public IReference getSource() {
    return instance.getSource();
  }

  @Override
  public void setSource(IReference source) {
    instance.setSource(source);
  }

  @Override
  public Optional<IReference> getSourceSemanticId() {
    return instance.getSourceSemanticId();
  }

  @Override
  public void setSourceSemanticId(IReference sourceSemanticId) {
    instance.setSourceSemanticId(sourceSemanticId);
  }

  @Override
  public IReference getObservableReference() {
    return instance.getObservableReference();
  }

  @Override
  public void setObservableReference(IReference observableReference) {
    instance.setObservableReference(observableReference);
  }

  @Override
  public Optional<IReference> getObservableSemanticId() {
    return instance.getObservableSemanticId();
  }

  @Override
  public void setObservableSemanticId(IReference observableSemanticId) {
    instance.setObservableSemanticId(observableSemanticId);
  }

  @Override
  public Optional<String> getTopic() {
    return instance.getTopic();
  }

  @Override
  public void setTopic(String topic) {
    instance.setTopic(topic);
  }

  @Override
  public Optional<IReference> getSubjectId() {
    return instance.getSubjectId();
  }

  @Override
  public void setSubjectId(IReference subjectId) {
    instance.setSubjectId(subjectId);
  }

  @Override
  public String getTimeStamp() {
    return instance.getTimeStamp();
  }

  @Override
  public void setTimeStamp(String timeStamp) {
    instance.setTimeStamp(timeStamp);
  }

  @Override
  public Optional<byte[]> getPayload() {
    return instance.getPayload();
  }

  @Override
  public void setPayload(byte[] payload) {
    instance.setPayload(payload);
  }

  public Iterable<IClass> descendOnce() {
    return instance.descendOnce();
  }

  public Iterable<IClass> descend() {
    return instance.descend();
  }

  public void accept(IVisitor visitor) {
    visitor.visitEventPayload(instance);
  }

  public <ContextT> void accept(
    IVisitorWithContext<ContextT> visitor,
    ContextT context
  ) {
    visitor.visitEventPayload(instance, context);
  }

  public <T> T transform(ITransformer<T> transformer) {
    return transformer.transformEventPayload(instance);
  }

  public <ContextT, T> T transform(
    ITransformerWithContext<ContextT, T> transformer,
    ContextT context
  ) {
    return transformer.transformEventPayload(instance, context);
  }
}

/*
 * This code has been automatically generated by aas-core-codegen.
 * Do NOT edit or append.
 */