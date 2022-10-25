public class WearableEyeViewAdjustment : MonoBehaviour // TypeDefIndex: 11802
{

	public virtual void OnEnteredEyesView(Wearable w) { }

	public virtual void OnExitedEyesView(Wearable w) { }

	public void .ctor() { }

}

public class WearableEyeViewAdjustment_Submesh : WearableEyeViewAdjustment // TypeDefIndex: 11803
{
	public int TargetSubmesh; 
	public Material HideMaterial; 
	public Material DefaultMaterial; 


	public override void OnEnteredEyesView(Wearable w) { }

	public override void OnExitedEyesView(Wearable w) { }

	public void .ctor() { }

}

