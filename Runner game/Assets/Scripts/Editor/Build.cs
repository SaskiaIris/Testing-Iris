using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Build : MonoBehaviour {
    // Start is called before the first frame update
    


	static void build() {
		string[] scenes = {
			//"Assets/Scenes/SampleLevel.unity",
			"Assets/Scenes/LevelOne.unity",
			//"Assets/Scenes/LevelTwo.unity"
		};

		BuildPipeline.BuildPlayer(scenes, "D:/GitHub/testing/Runner game/Builds/Runner game.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
	}
}
