namespace Sfa.Eds.Das.Tools.MetaDataCreationTool.Models
{
    public sealed class StandardObject
    {
        public string FileName { get; set; }

        public string Json { get; set; }

        public StandardObject(string fileName, string json)
        {
            FileName = fileName;
            Json = json;
        }
    }
}