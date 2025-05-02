using SpaceWarp.API.Mods;

public class TestPlugin : MonoBehaviourMod
{
    public override void OnInitialized()
    {
        SWLogger.LogInfo("TestPlugin initialized");
    }
}
