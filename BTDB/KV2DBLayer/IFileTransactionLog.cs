namespace BTDB.KV2DBLayer
{
    internal interface IFileTransactionLog : IFileInfo
    {
        uint PreviousFileId { get; }
        uint NextFileId { get; set; }
    }
}