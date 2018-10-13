//以下示例展示异步的WhenAll()方法使用场景

public async Task<User> GetUserAsync(int userId)
{
    //按照给出的userId，查询并返回数据库中对应的User对象
}

//<summary>按照一组userId，查询返回一组对应的User对象集合</summary>
public static async Task<IEnumerable<User>> GetUersAsync(IEnumerable<int> userIds)
{
    var getUserTasks=new List<Task<User>>();//疑问：此处Task是表示一个异步操作结果的集合？
    foreach (int userId in userIds)
    {
        getUserTasks.Add(GetUserAsync);//推测：这样会衍生出很多类似的异步操作
    }
    return await Task.WhenAll(getUserTasks);//等待所有异步操作结束，把结果一起返回
}

public static async Task<User[]> GetUsersAsync(IEnumerable<int> userIds)
{
    var getUerTasks=userIds.Select(id=>GetUserAsync(id));
    return await Task.WhenAll(getUserTasks);
    MathDelegate math1=(int n)=>{return n*n;}
    MathDelegate math2=n=>n*n;    
}