using UnityEditor;

public class BuildIOS
{
    public static void Build()
    {
        // Define build options
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" }; // Update with your scenes
        buildPlayerOptions.locationPathName = "Builds/iOS";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;

        // Build the player
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
