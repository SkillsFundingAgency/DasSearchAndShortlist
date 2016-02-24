namespace Sfa.Eds.Das.Tools.MetaDataCreationTool.Services.interfaces
{
    using System.Collections.Generic;

    public interface IVstsService
    {
        IEnumerable<string> GetStandardObjectsIds();
        IEnumerable<string> GetStandards();
        string GetLatesCommit();

        void PushCommit(string body);
    }
}