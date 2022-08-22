public class Animator : Behaviour // TypeDefIndex: 4487
{	// Properties
	public bool isInitialized { get; }
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

	// Methods

	[NativeMethodAttribute] // RVA: 0xCA4F0 Offset: 0xC98F0 VA: 0x1800CA4F0
	// RVA: 0x22DD9A0 Offset: 0x22DBFA0 VA: 0x1822DD9A0
	public bool get_isInitialized() { }

	// RVA: 0x22DC900 Offset: 0x22DAF00 VA: 0x1822DC900
	public float GetFloat(string name) { }

	// RVA: 0x22DC8C0 Offset: 0x22DAEC0 VA: 0x1822DC8C0
	public float GetFloat(int id) { }

	// RVA: 0x22DD0D0 Offset: 0x22DB6D0 VA: 0x1822DD0D0
	public void SetFloat(string name, float value) { }

	// RVA: 0x22DD060 Offset: 0x22DB660 VA: 0x1822DD060
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DD010 Offset: 0x22DB610 VA: 0x1822DD010
	public void SetFloat(int id, float value) { }

	// RVA: 0x22DCFB0 Offset: 0x22DB5B0 VA: 0x1822DCFB0
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DC7A0 Offset: 0x22DADA0 VA: 0x1822DC7A0
	public bool GetBool(int id) { }

	// RVA: 0x22DCF50 Offset: 0x22DB550 VA: 0x1822DCF50
	public void SetBool(string name, bool value) { }

	// RVA: 0x22DCEF0 Offset: 0x22DB4F0 VA: 0x1822DCEF0
	public void SetBool(int id, bool value) { }

	// RVA: 0x22DC9E0 Offset: 0x22DAFE0 VA: 0x1822DC9E0
	public int GetInteger(string name) { }

	// RVA: 0x22DD500 Offset: 0x22DBB00 VA: 0x1822DD500
	public void SetInteger(string name, int value) { }

	// RVA: 0x22DD4B0 Offset: 0x22DBAB0 VA: 0x1822DD4B0
	public void SetInteger(int id, int value) { }

	// RVA: 0x22DD840 Offset: 0x22DBE40 VA: 0x1822DD840
	public void SetTrigger(string name) { }

	// RVA: 0x22DD800 Offset: 0x22DBE00 VA: 0x1822DD800
	public void SetTrigger(int id) { }

	// RVA: 0x22DCEA0 Offset: 0x22DB4A0 VA: 0x1822DCEA0
	public void ResetTrigger(string name) { }

	// RVA: 0x22DCE60 Offset: 0x22DB460 VA: 0x1822DCE60
	public void ResetTrigger(int id) { }

	// RVA: 0x22DDAA0 Offset: 0x22DC0A0 VA: 0x1822DDAA0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x22DDC70 Offset: 0x22DC270 VA: 0x1822DDC70
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x22DD370 Offset: 0x22DB970 VA: 0x1822DD370
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DD180 Offset: 0x22DB780 VA: 0x1822DD180
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DD440 Offset: 0x22DBA40 VA: 0x1822DD440
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DD220 Offset: 0x22DB820 VA: 0x1822DD220
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DC990 Offset: 0x22DAF90 VA: 0x1822DC990
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x22DC950 Offset: 0x22DAF50 VA: 0x1822DC950
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x22DD310 Offset: 0x22DB910 VA: 0x1822DD310
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DD270 Offset: 0x22DB870 VA: 0x1822DD270
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DD3E0 Offset: 0x22DB9E0 VA: 0x1822DD3E0
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DD2C0 Offset: 0x22DB8C0 VA: 0x1822DD2C0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DD650 Offset: 0x22DBC50 VA: 0x1822DD650
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA660 Offset: 0xC9A60 VA: 0x1800CA660
	// RVA: 0x22DD600 Offset: 0x22DBC00 VA: 0x1822DD600
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x22DD720 Offset: 0x22DBD20 VA: 0x1822DD720
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x22DD790 Offset: 0x22DBD90 VA: 0x1822DD790
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA9D0 Offset: 0xC9DD0 VA: 0x1800CA9D0
	// RVA: 0x22DD6B0 Offset: 0x22DBCB0 VA: 0x1822DD6B0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x22DD9E0 Offset: 0x22DBFE0 VA: 0x1822DD9E0
	public int get_layerCount() { }

	// RVA: 0x22DCA30 Offset: 0x22DB030 VA: 0x1822DCA30
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x22DCA80 Offset: 0x22DB080 VA: 0x1822DCA80
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x22DD560 Offset: 0x22DBB60 VA: 0x1822DD560
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x22DC740 Offset: 0x22DAD40 VA: 0x1822DC740
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22DC820 Offset: 0x22DAE20 VA: 0x1822DC820
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22DCB00 Offset: 0x22DB100 VA: 0x1822DCB00
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAA30 Offset: 0xC9E30 VA: 0x1800CAA30
	// RVA: 0x22DC7E0 Offset: 0x22DADE0 VA: 0x1822DC7E0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCABF0 Offset: 0xC9FF0 VA: 0x1800CABF0
	// RVA: 0x22DCAC0 Offset: 0x22DB0C0 VA: 0x1822DCAC0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x22DCC30 Offset: 0x22DB230 VA: 0x1822DCC30
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x22DDC20 Offset: 0x22DC220 VA: 0x1822DDC20
	public void set_speed(float value) { }

	// RVA: 0x22DC550 Offset: 0x22DAB50 VA: 0x1822DC550
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DC430 Offset: 0x22DAA30 VA: 0x1822DC430
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DC6B0 Offset: 0x22DACB0 VA: 0x1822DC6B0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCAF90 Offset: 0xCA390 VA: 0x1800CAF90
	// RVA: 0x22DC5E0 Offset: 0x22DABE0 VA: 0x1822DC5E0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x22DC640 Offset: 0x22DAC40 VA: 0x1822DC640
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DC4D0 Offset: 0x22DAAD0 VA: 0x1822DC4D0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DCE40 Offset: 0x22DB440 VA: 0x1822DCE40
	public void Play(string stateName, int layer) { }

	// RVA: 0x22DCD60 Offset: 0x22DB360 VA: 0x1822DCD60
	public void Play(string stateName) { }

	// RVA: 0x22DCC70 Offset: 0x22DB270 VA: 0x1822DCC70
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB2A0 Offset: 0xCA6A0 VA: 0x1800CB2A0
	// RVA: 0x22DCD00 Offset: 0x22DB300 VA: 0x1822DCD00
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22DCDE0 Offset: 0x22DB3E0 VA: 0x1822DCDE0
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x22DCD90 Offset: 0x22DB390 VA: 0x1822DCD90
	public void Play(int stateNameHash) { }

	// RVA: 0x22DD920 Offset: 0x22DBF20 VA: 0x1822DD920
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x22DDB40 Offset: 0x22DC140 VA: 0x1822DDB40
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x22DDA60 Offset: 0x22DC060 VA: 0x1822DDA60
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x22DDBD0 Offset: 0x22DC1D0 VA: 0x1822DDBD0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB570 Offset: 0xCA970 VA: 0x1800CB570
	// RVA: 0x22DD960 Offset: 0x22DBF60 VA: 0x1822DD960
	public bool get_hasBoundPlayables() { }

	// RVA: 0x22DCBA0 Offset: 0x22DB1A0 VA: 0x1822DCBA0
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB730 Offset: 0xCAB30 VA: 0x1800CB730
	// RVA: 0x22DD890 Offset: 0x22DBE90 VA: 0x1822DD890
	public static int StringToHash(string name) { }

	// RVA: 0x22DDAF0 Offset: 0x22DC0F0 VA: 0x1822DDAF0
	public void set_avatar(Avatar value) { }

	// RVA: 0x22DC380 Offset: 0x22DA980 VA: 0x1822DC380
	private void CheckIfInIKPass() { }

	// RVA: 0x22DCBF0 Offset: 0x22DB1F0 VA: 0x1822DCBF0
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB990 Offset: 0xCAD90 VA: 0x1800CB990
	// RVA: 0x22DD0D0 Offset: 0x22DB6D0 VA: 0x1822DD0D0
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBBF0 Offset: 0xCAFF0 VA: 0x1800CBBF0
	// RVA: 0x22DD010 Offset: 0x22DB610 VA: 0x1822DD010
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBD30 Offset: 0xCB130 VA: 0x1800CBD30
	// RVA: 0x22DC900 Offset: 0x22DAF00 VA: 0x1822DC900
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBE10 Offset: 0xCB210 VA: 0x1800CBE10
	// RVA: 0x22DC8C0 Offset: 0x22DAEC0 VA: 0x1822DC8C0
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBEF0 Offset: 0xCB2F0 VA: 0x1800CBEF0
	// RVA: 0x22DCF50 Offset: 0x22DB550 VA: 0x1822DCF50
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFE0 Offset: 0xCB3E0 VA: 0x1800CBFE0
	// RVA: 0x22DCEF0 Offset: 0x22DB4F0 VA: 0x1822DCEF0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC1A0 Offset: 0xCB5A0 VA: 0x1800CC1A0
	// RVA: 0x22DC7A0 Offset: 0x22DADA0 VA: 0x1822DC7A0
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC2E0 Offset: 0xCB6E0 VA: 0x1800CC2E0
	// RVA: 0x22DD500 Offset: 0x22DBB00 VA: 0x1822DD500
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC470 Offset: 0xCB870 VA: 0x1800CC470
	// RVA: 0x22DD4B0 Offset: 0x22DBAB0 VA: 0x1822DD4B0
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC590 Offset: 0xCB990 VA: 0x1800CC590
	// RVA: 0x22DC9E0 Offset: 0x22DAFE0 VA: 0x1822DC9E0
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC7B0 Offset: 0xCBBB0 VA: 0x1800CC7B0
	// RVA: 0x22DD840 Offset: 0x22DBE40 VA: 0x1822DD840
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	// RVA: 0x22DD800 Offset: 0x22DBE00 VA: 0x1822DD800
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	// RVA: 0x22DCEA0 Offset: 0x22DB4A0 VA: 0x1822DCEA0
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCB50 Offset: 0xCBF50 VA: 0x1800CCB50
	// RVA: 0x22DCE60 Offset: 0x22DB460 VA: 0x1822DCE60
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCCC0 Offset: 0xCC0C0 VA: 0x1800CCCC0
	// RVA: 0x22DD060 Offset: 0x22DB660 VA: 0x1822DD060
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCE50 Offset: 0xCC250 VA: 0x1800CCE50
	// RVA: 0x22DCFB0 Offset: 0x22DB5B0 VA: 0x1822DCFB0
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCF10 Offset: 0xCC310 VA: 0x1800CCF10
	// RVA: 0x22DD8D0 Offset: 0x22DBED0 VA: 0x1822DD8D0
	public void Update(float deltaTime) { }

	// RVA: 0x22DDA20 Offset: 0x22DC020 VA: 0x1822DDA20
	public bool get_logWarnings() { }

	// RVA: 0x22DDB80 Offset: 0x22DC180 VA: 0x1822DDB80
	public void set_fireEvents(bool value) { }

	// RVA: 0x22DD130 Offset: 0x22DB730 VA: 0x1822DD130
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x22DD1D0 Offset: 0x22DB7D0 VA: 0x1822DD1D0
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x22DD5B0 Offset: 0x22DBBB0 VA: 0x1822DD5B0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

