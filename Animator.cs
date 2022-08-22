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
	// RVA: 0x22DD180 Offset: 0x22DB780 VA: 0x1822DD180
	public bool get_isInitialized() { }

	// RVA: 0x22DC0E0 Offset: 0x22DA6E0 VA: 0x1822DC0E0
	public float GetFloat(string name) { }

	// RVA: 0x22DC0A0 Offset: 0x22DA6A0 VA: 0x1822DC0A0
	public float GetFloat(int id) { }

	// RVA: 0x22DC8B0 Offset: 0x22DAEB0 VA: 0x1822DC8B0
	public void SetFloat(string name, float value) { }

	// RVA: 0x22DC840 Offset: 0x22DAE40 VA: 0x1822DC840
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DC7F0 Offset: 0x22DADF0 VA: 0x1822DC7F0
	public void SetFloat(int id, float value) { }

	// RVA: 0x22DC790 Offset: 0x22DAD90 VA: 0x1822DC790
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DBF80 Offset: 0x22DA580 VA: 0x1822DBF80
	public bool GetBool(int id) { }

	// RVA: 0x22DC730 Offset: 0x22DAD30 VA: 0x1822DC730
	public void SetBool(string name, bool value) { }

	// RVA: 0x22DC6D0 Offset: 0x22DACD0 VA: 0x1822DC6D0
	public void SetBool(int id, bool value) { }

	// RVA: 0x22DC1C0 Offset: 0x22DA7C0 VA: 0x1822DC1C0
	public int GetInteger(string name) { }

	// RVA: 0x22DCCE0 Offset: 0x22DB2E0 VA: 0x1822DCCE0
	public void SetInteger(string name, int value) { }

	// RVA: 0x22DCC90 Offset: 0x22DB290 VA: 0x1822DCC90
	public void SetInteger(int id, int value) { }

	// RVA: 0x22DD020 Offset: 0x22DB620 VA: 0x1822DD020
	public void SetTrigger(string name) { }

	// RVA: 0x22DCFE0 Offset: 0x22DB5E0 VA: 0x1822DCFE0
	public void SetTrigger(int id) { }

	// RVA: 0x22DC680 Offset: 0x22DAC80 VA: 0x1822DC680
	public void ResetTrigger(string name) { }

	// RVA: 0x22DC640 Offset: 0x22DAC40 VA: 0x1822DC640
	public void ResetTrigger(int id) { }

	// RVA: 0x22DD280 Offset: 0x22DB880 VA: 0x1822DD280
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x22DD450 Offset: 0x22DBA50 VA: 0x1822DD450
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x22DCB50 Offset: 0x22DB150 VA: 0x1822DCB50
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DC960 Offset: 0x22DAF60 VA: 0x1822DC960
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DCC20 Offset: 0x22DB220 VA: 0x1822DCC20
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DCA00 Offset: 0x22DB000 VA: 0x1822DCA00
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DC170 Offset: 0x22DA770 VA: 0x1822DC170
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x22DC130 Offset: 0x22DA730 VA: 0x1822DC130
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x22DCAF0 Offset: 0x22DB0F0 VA: 0x1822DCAF0
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCA50 Offset: 0x22DB050 VA: 0x1822DCA50
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCBC0 Offset: 0x22DB1C0 VA: 0x1822DCBC0
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCAA0 Offset: 0x22DB0A0 VA: 0x1822DCAA0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCE30 Offset: 0x22DB430 VA: 0x1822DCE30
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA660 Offset: 0xC9A60 VA: 0x1800CA660
	// RVA: 0x22DCDE0 Offset: 0x22DB3E0 VA: 0x1822DCDE0
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x22DCF00 Offset: 0x22DB500 VA: 0x1822DCF00
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x22DCF70 Offset: 0x22DB570 VA: 0x1822DCF70
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA9D0 Offset: 0xC9DD0 VA: 0x1800CA9D0
	// RVA: 0x22DCE90 Offset: 0x22DB490 VA: 0x1822DCE90
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x22DD1C0 Offset: 0x22DB7C0 VA: 0x1822DD1C0
	public int get_layerCount() { }

	// RVA: 0x22DC210 Offset: 0x22DA810 VA: 0x1822DC210
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x22DC260 Offset: 0x22DA860 VA: 0x1822DC260
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x22DCD40 Offset: 0x22DB340 VA: 0x1822DCD40
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x22DBF20 Offset: 0x22DA520 VA: 0x1822DBF20
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22DC000 Offset: 0x22DA600 VA: 0x1822DC000
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22DC2E0 Offset: 0x22DA8E0 VA: 0x1822DC2E0
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAA30 Offset: 0xC9E30 VA: 0x1800CAA30
	// RVA: 0x22DBFC0 Offset: 0x22DA5C0 VA: 0x1822DBFC0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCABF0 Offset: 0xC9FF0 VA: 0x1800CABF0
	// RVA: 0x22DC2A0 Offset: 0x22DA8A0 VA: 0x1822DC2A0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x22DC410 Offset: 0x22DAA10 VA: 0x1822DC410
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x22DD400 Offset: 0x22DBA00 VA: 0x1822DD400
	public void set_speed(float value) { }

	// RVA: 0x22DBD30 Offset: 0x22DA330 VA: 0x1822DBD30
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DBC10 Offset: 0x22DA210 VA: 0x1822DBC10
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DBE90 Offset: 0x22DA490 VA: 0x1822DBE90
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCAF90 Offset: 0xCA390 VA: 0x1800CAF90
	// RVA: 0x22DBDC0 Offset: 0x22DA3C0 VA: 0x1822DBDC0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x22DBE20 Offset: 0x22DA420 VA: 0x1822DBE20
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DBCB0 Offset: 0x22DA2B0 VA: 0x1822DBCB0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DC620 Offset: 0x22DAC20 VA: 0x1822DC620
	public void Play(string stateName, int layer) { }

	// RVA: 0x22DC540 Offset: 0x22DAB40 VA: 0x1822DC540
	public void Play(string stateName) { }

	// RVA: 0x22DC450 Offset: 0x22DAA50 VA: 0x1822DC450
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB2A0 Offset: 0xCA6A0 VA: 0x1800CB2A0
	// RVA: 0x22DC4E0 Offset: 0x22DAAE0 VA: 0x1822DC4E0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22DC5C0 Offset: 0x22DABC0 VA: 0x1822DC5C0
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x22DC570 Offset: 0x22DAB70 VA: 0x1822DC570
	public void Play(int stateNameHash) { }

	// RVA: 0x22DD100 Offset: 0x22DB700 VA: 0x1822DD100
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x22DD320 Offset: 0x22DB920 VA: 0x1822DD320
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x22DD240 Offset: 0x22DB840 VA: 0x1822DD240
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x22DD3B0 Offset: 0x22DB9B0 VA: 0x1822DD3B0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB570 Offset: 0xCA970 VA: 0x1800CB570
	// RVA: 0x22DD140 Offset: 0x22DB740 VA: 0x1822DD140
	public bool get_hasBoundPlayables() { }

	// RVA: 0x22DC380 Offset: 0x22DA980 VA: 0x1822DC380
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB730 Offset: 0xCAB30 VA: 0x1800CB730
	// RVA: 0x22DD070 Offset: 0x22DB670 VA: 0x1822DD070
	public static int StringToHash(string name) { }

	// RVA: 0x22DD2D0 Offset: 0x22DB8D0 VA: 0x1822DD2D0
	public void set_avatar(Avatar value) { }

	// RVA: 0x22DBB60 Offset: 0x22DA160 VA: 0x1822DBB60
	private void CheckIfInIKPass() { }

	// RVA: 0x22DC3D0 Offset: 0x22DA9D0 VA: 0x1822DC3D0
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB990 Offset: 0xCAD90 VA: 0x1800CB990
	// RVA: 0x22DC8B0 Offset: 0x22DAEB0 VA: 0x1822DC8B0
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBBF0 Offset: 0xCAFF0 VA: 0x1800CBBF0
	// RVA: 0x22DC7F0 Offset: 0x22DADF0 VA: 0x1822DC7F0
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBD30 Offset: 0xCB130 VA: 0x1800CBD30
	// RVA: 0x22DC0E0 Offset: 0x22DA6E0 VA: 0x1822DC0E0
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBE10 Offset: 0xCB210 VA: 0x1800CBE10
	// RVA: 0x22DC0A0 Offset: 0x22DA6A0 VA: 0x1822DC0A0
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBEF0 Offset: 0xCB2F0 VA: 0x1800CBEF0
	// RVA: 0x22DC730 Offset: 0x22DAD30 VA: 0x1822DC730
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFE0 Offset: 0xCB3E0 VA: 0x1800CBFE0
	// RVA: 0x22DC6D0 Offset: 0x22DACD0 VA: 0x1822DC6D0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC1A0 Offset: 0xCB5A0 VA: 0x1800CC1A0
	// RVA: 0x22DBF80 Offset: 0x22DA580 VA: 0x1822DBF80
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC2E0 Offset: 0xCB6E0 VA: 0x1800CC2E0
	// RVA: 0x22DCCE0 Offset: 0x22DB2E0 VA: 0x1822DCCE0
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC470 Offset: 0xCB870 VA: 0x1800CC470
	// RVA: 0x22DCC90 Offset: 0x22DB290 VA: 0x1822DCC90
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC590 Offset: 0xCB990 VA: 0x1800CC590
	// RVA: 0x22DC1C0 Offset: 0x22DA7C0 VA: 0x1822DC1C0
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC7B0 Offset: 0xCBBB0 VA: 0x1800CC7B0
	// RVA: 0x22DD020 Offset: 0x22DB620 VA: 0x1822DD020
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	// RVA: 0x22DCFE0 Offset: 0x22DB5E0 VA: 0x1822DCFE0
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	// RVA: 0x22DC680 Offset: 0x22DAC80 VA: 0x1822DC680
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCB50 Offset: 0xCBF50 VA: 0x1800CCB50
	// RVA: 0x22DC640 Offset: 0x22DAC40 VA: 0x1822DC640
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCCC0 Offset: 0xCC0C0 VA: 0x1800CCCC0
	// RVA: 0x22DC840 Offset: 0x22DAE40 VA: 0x1822DC840
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCE50 Offset: 0xCC250 VA: 0x1800CCE50
	// RVA: 0x22DC790 Offset: 0x22DAD90 VA: 0x1822DC790
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCF10 Offset: 0xCC310 VA: 0x1800CCF10
	// RVA: 0x22DD0B0 Offset: 0x22DB6B0 VA: 0x1822DD0B0
	public void Update(float deltaTime) { }

	// RVA: 0x22DD200 Offset: 0x22DB800 VA: 0x1822DD200
	public bool get_logWarnings() { }

	// RVA: 0x22DD360 Offset: 0x22DB960 VA: 0x1822DD360
	public void set_fireEvents(bool value) { }

	// RVA: 0x22DC910 Offset: 0x22DAF10 VA: 0x1822DC910
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x22DC9B0 Offset: 0x22DAFB0 VA: 0x1822DC9B0
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x22DCD90 Offset: 0x22DB390 VA: 0x1822DCD90
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

