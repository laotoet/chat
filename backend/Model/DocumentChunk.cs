namespace backend.Model
{
    public class DocumentChunk
    {
        public string Id { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public float[] Embedding { get; set; } = Array.Empty<float>();
        public DateTime CreatedAt { get; set; }
        public string SourceDocumentId { get; set; } = string.Empty;
        public int ChunkIndex { get; set; }
        public int ContentLength => Content.Length;
        public Dictionary<string, object> Metadata { get; set; } = [];
    }
}
