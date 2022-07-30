namespace TheOmenDen.Shared.JsonApi.Atomic.Generators.Json;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, GenerationMode = JsonSourceGenerationMode.Serialization, WriteIndented = true)]
[JsonSerializable(typeof(IRef))]
public partial class RefGeneratorContext : JsonSerializerContext {}
