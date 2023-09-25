namespace StorageBrokers
{
    internal partial class StorageBroker : IStorageBroker
    {
        public StorageBroker()
        {
            //Database configurations
        }

        //onmodelcreating()
        //onmodelconfiguring()
        private async ValueTask<T> Insert<T>(T entity)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("entity saved");
            });
            return entity;
        }
        private async ValueTask<T> GetAsync<T>(int Id) 
        {
           return await Task.Run(() =>
            {
                return default(T);
            });
            
        }
    }
}
