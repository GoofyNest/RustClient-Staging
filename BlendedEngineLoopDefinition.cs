public class BlendedEngineLoopDefinition : ScriptableObject // TypeDefIndex: 10689
{
	public BlendedEngineLoopDefinition.EngineLoopDefinition[] engineLoops; 
	public float minRPM; 
	public float maxRPM; 
	public float RPMChangeRateUp; 
	public float RPMChangeRateDown; 


	public void .ctor() { }

}

public class BlendedEngineLoopDefinition.EngineLoopDefinition // TypeDefIndex: 10690
{
	public SoundDefinition soundDefinition; 
	public float RPM; 
	public float startRPM; 
	public float startFullRPM; 
	public float stopFullRPM; 
	public float stopRPM; 


	public float GetPitchForRPM(float targetRPM) { }

	public void .ctor() { }

}

