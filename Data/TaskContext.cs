namespace TasksAPI.Data
{
    public class TaskContext
    {
        public delegate Task<IdbConnection> GetConnection();
    }
}
