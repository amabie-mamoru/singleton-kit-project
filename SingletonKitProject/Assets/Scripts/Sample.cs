using com.amabie.SingletonKit;

public class Sample : SingletonMonoBehaviour<Sample>
{
    public void Start()
    {
        UnityEngine.Debug.Log("<color=green>少なくとも一つは正常に生成されました</color>");
    }
}
