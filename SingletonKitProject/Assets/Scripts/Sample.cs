using com.amabie.SingletonKit;

public class Sample : SingletonMonoBehaviour<Sample>
{
    public void Start()
    {
        UnityEngine.Debug.Log("<color=green>少なくとも一つは正常に生成されました</color>");

        UnityEngine.Debug.Log("--- SingletonMonoBehaviour Test はここまで ---");
        UnityEngine.Debug.Log("--- ここからSingleton Test  ---");

        UnityEngine.Debug.Log("<color=green>--- not singleton test ---</color>");
        var not_singleton = new SampleNotSingleton();
        UnityEngine.Debug.Log($"instance object hash: {not_singleton.GetHashCode()}");
        UnityEngine.Debug.Log("シングルトンでない場合、再生成するとオブジェクトハッシュは異なります。");
        var not_singleton2 = new SampleNotSingleton();
        UnityEngine.Debug.Log($"instance object hash: {not_singleton2.GetHashCode()}");

        UnityEngine.Debug.Log("<color=green>--- singleton test ---</color>");
        var singleton = SampleSingleton.Instance;
        UnityEngine.Debug.Log($"instance object hash: {singleton.GetHashCode()}");
        UnityEngine.Debug.Log("シングルトンの場合、再生成してもオブジェクトハッシュは同じです。");
        var singleton2 = SampleSingleton.Instance;
        UnityEngine.Debug.Log($"instance object hash: {singleton2.GetHashCode()}");
    }
}
