public class Animator : Behaviour // TypeDefIndex: 4487
{	public bool isInitialized { get; }
	public bool applyRootMotion { set; }
	public AnimatorUpdateMode updateMode { set; }
	public int layerCount { get; }
	public float speed { set; }
	public AnimatorCullingMode cullingMode { get; set; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { set; }
	public bool logWarnings { get; }
	public bool fireEvents { set; }


	[NativeMethodAttribute] // RVA: 0xCA620 Offset: 0xC9A20 VA: 0x1800CA620
	public bool get_isInitialized() { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	public bool GetBool(int id) { }

	public void SetBool(string name, bool value) { }

	public void SetBool(int id, bool value) { }

	public int GetInteger(string name) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	public void set_applyRootMotion(bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA740 Offset: 0xC9B40 VA: 0x1800CA740
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCAB00 Offset: 0xC9F00 VA: 0x1800CAB00
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public int get_layerCount() { }

	public int GetLayerIndex(string layerName) { }

	public float GetLayerWeight(int layerIndex) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAB60 Offset: 0xC9F60 VA: 0x1800CAB60
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCACE0 Offset: 0xCA0E0 VA: 0x1800CACE0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public bool IsInTransition(int layerIndex) { }

	public void set_speed(float value) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB0C0 Offset: 0xCA4C0 VA: 0x1800CB0C0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB3D0 Offset: 0xCA7D0 VA: 0x1800CB3D0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	public AnimatorCullingMode get_cullingMode() { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB610 Offset: 0xCAA10 VA: 0x1800CB610
	public bool get_hasBoundPlayables() { }

	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB7A0 Offset: 0xCABA0 VA: 0x1800CB7A0
	public static int StringToHash(string name) { }

	public void set_avatar(Avatar value) { }

	private void CheckIfInIKPass() { }

	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCBA10 Offset: 0xCAE10 VA: 0x1800CBA10
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBC80 Offset: 0xCB080 VA: 0x1800CBC80
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBE10 Offset: 0xCB210 VA: 0x1800CBE10
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBF10 Offset: 0xCB310 VA: 0x1800CBF10
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC080 Offset: 0xCB480 VA: 0x1800CC080
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC2A0 Offset: 0xCB6A0 VA: 0x1800CC2A0
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC360 Offset: 0xCB760 VA: 0x1800CC360
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC4D0 Offset: 0xCB8D0 VA: 0x1800CC4D0
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC610 Offset: 0xCBA10 VA: 0x1800CC610
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC860 Offset: 0xCBC60 VA: 0x1800CC860
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC980 Offset: 0xCBD80 VA: 0x1800CC980
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCB10 Offset: 0xCBF10 VA: 0x1800CCB10
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCC40 Offset: 0xCC040 VA: 0x1800CCC40
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCDF0 Offset: 0xCC1F0 VA: 0x1800CCDF0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCF00 Offset: 0xCC300 VA: 0x1800CCF00
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCF70 Offset: 0xCC370 VA: 0x1800CCF70
	public void Update(float deltaTime) { }

	public bool get_logWarnings() { }

	public void set_fireEvents(bool value) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

