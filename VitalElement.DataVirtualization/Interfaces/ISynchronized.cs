namespace VitalElement.VirtualizingCollection.Interfaces
{
    public interface ISynchronized
    {
        bool IsSynchronized { get; }
        
        object SyncRoot { get; }
    }
}