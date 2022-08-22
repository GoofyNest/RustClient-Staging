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
	// RVA: 0x22DCEC0 Offset: 0x22DB4C0 VA: 0x1822DCEC0
	public bool get_isInitialized() { }

	// RVA: 0x22DBE20 Offset: 0x22DA420 VA: 0x1822DBE20
	public float GetFloat(string name) { }

	// RVA: 0x22DBDE0 Offset: 0x22DA3E0 VA: 0x1822DBDE0
	public float GetFloat(int id) { }

	// RVA: 0x22DC5F0 Offset: 0x22DABF0 VA: 0x1822DC5F0
	public void SetFloat(string name, float value) { }

	// RVA: 0x22DC580 Offset: 0x22DAB80 VA: 0x1822DC580
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DC530 Offset: 0x22DAB30 VA: 0x1822DC530
	public void SetFloat(int id, float value) { }

	// RVA: 0x22DC4D0 Offset: 0x22DAAD0 VA: 0x1822DC4D0
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DBCC0 Offset: 0x22DA2C0 VA: 0x1822DBCC0
	public bool GetBool(int id) { }

	// RVA: 0x22DC470 Offset: 0x22DAA70 VA: 0x1822DC470
	public void SetBool(string name, bool value) { }

	// RVA: 0x22DC410 Offset: 0x22DAA10 VA: 0x1822DC410
	public void SetBool(int id, bool value) { }

	// RVA: 0x22DBF00 Offset: 0x22DA500 VA: 0x1822DBF00
	public int GetInteger(string name) { }

	// RVA: 0x22DCA20 Offset: 0x22DB020 VA: 0x1822DCA20
	public void SetInteger(string name, int value) { }

	// RVA: 0x22DC9D0 Offset: 0x22DAFD0 VA: 0x1822DC9D0
	public void SetInteger(int id, int value) { }

	// RVA: 0x22DCD60 Offset: 0x22DB360 VA: 0x1822DCD60
	public void SetTrigger(string name) { }

	// RVA: 0x22DCD20 Offset: 0x22DB320 VA: 0x1822DCD20
	public void SetTrigger(int id) { }

	// RVA: 0x22DC3C0 Offset: 0x22DA9C0 VA: 0x1822DC3C0
	public void ResetTrigger(string name) { }

	// RVA: 0x22DC380 Offset: 0x22DA980 VA: 0x1822DC380
	public void ResetTrigger(int id) { }

	// RVA: 0x22DCFC0 Offset: 0x22DB5C0 VA: 0x1822DCFC0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x22DD190 Offset: 0x22DB790 VA: 0x1822DD190
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x22DC890 Offset: 0x22DAE90 VA: 0x1822DC890
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DC6A0 Offset: 0x22DACA0 VA: 0x1822DC6A0
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DC960 Offset: 0x22DAF60 VA: 0x1822DC960
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DC740 Offset: 0x22DAD40 VA: 0x1822DC740
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DBEB0 Offset: 0x22DA4B0 VA: 0x1822DBEB0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x22DBE70 Offset: 0x22DA470 VA: 0x1822DBE70
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x22DC830 Offset: 0x22DAE30 VA: 0x1822DC830
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DC790 Offset: 0x22DAD90 VA: 0x1822DC790
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DC900 Offset: 0x22DAF00 VA: 0x1822DC900
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DC7E0 Offset: 0x22DADE0 VA: 0x1822DC7E0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCB70 Offset: 0x22DB170 VA: 0x1822DCB70
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA660 Offset: 0xC9A60 VA: 0x1800CA660
	// RVA: 0x22DCB20 Offset: 0x22DB120 VA: 0x1822DCB20
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x22DCC40 Offset: 0x22DB240 VA: 0x1822DCC40
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x22DCCB0 Offset: 0x22DB2B0 VA: 0x1822DCCB0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA9D0 Offset: 0xC9DD0 VA: 0x1800CA9D0
	// RVA: 0x22DCBD0 Offset: 0x22DB1D0 VA: 0x1822DCBD0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x22DCF00 Offset: 0x22DB500 VA: 0x1822DCF00
	public int get_layerCount() { }

	// RVA: 0x22DBF50 Offset: 0x22DA550 VA: 0x1822DBF50
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x22DBFA0 Offset: 0x22DA5A0 VA: 0x1822DBFA0
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x22DCA80 Offset: 0x22DB080 VA: 0x1822DCA80
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x22DBC60 Offset: 0x22DA260 VA: 0x1822DBC60
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22DBD40 Offset: 0x22DA340 VA: 0x1822DBD40
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22DC020 Offset: 0x22DA620 VA: 0x1822DC020
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAA30 Offset: 0xC9E30 VA: 0x1800CAA30
	// RVA: 0x22DBD00 Offset: 0x22DA300 VA: 0x1822DBD00
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCABF0 Offset: 0xC9FF0 VA: 0x1800CABF0
	// RVA: 0x22DBFE0 Offset: 0x22DA5E0 VA: 0x1822DBFE0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x22DC150 Offset: 0x22DA750 VA: 0x1822DC150
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x22DD140 Offset: 0x22DB740 VA: 0x1822DD140
	public void set_speed(float value) { }

	// RVA: 0x22DBA70 Offset: 0x22DA070 VA: 0x1822DBA70
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DB950 Offset: 0x22D9F50 VA: 0x1822DB950
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DBBD0 Offset: 0x22DA1D0 VA: 0x1822DBBD0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCAF90 Offset: 0xCA390 VA: 0x1800CAF90
	// RVA: 0x22DBB00 Offset: 0x22DA100 VA: 0x1822DBB00
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x22DBB60 Offset: 0x22DA160 VA: 0x1822DBB60
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DB9F0 Offset: 0x22D9FF0 VA: 0x1822DB9F0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DC360 Offset: 0x22DA960 VA: 0x1822DC360
	public void Play(string stateName, int layer) { }

	// RVA: 0x22DC280 Offset: 0x22DA880 VA: 0x1822DC280
	public void Play(string stateName) { }

	// RVA: 0x22DC190 Offset: 0x22DA790 VA: 0x1822DC190
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB2A0 Offset: 0xCA6A0 VA: 0x1800CB2A0
	// RVA: 0x22DC220 Offset: 0x22DA820 VA: 0x1822DC220
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22DC300 Offset: 0x22DA900 VA: 0x1822DC300
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x22DC2B0 Offset: 0x22DA8B0 VA: 0x1822DC2B0
	public void Play(int stateNameHash) { }

	// RVA: 0x22DCE40 Offset: 0x22DB440 VA: 0x1822DCE40
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x22DD060 Offset: 0x22DB660 VA: 0x1822DD060
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x22DCF80 Offset: 0x22DB580 VA: 0x1822DCF80
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x22DD0F0 Offset: 0x22DB6F0 VA: 0x1822DD0F0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB570 Offset: 0xCA970 VA: 0x1800CB570
	// RVA: 0x22DCE80 Offset: 0x22DB480 VA: 0x1822DCE80
	public bool get_hasBoundPlayables() { }

	// RVA: 0x22DC0C0 Offset: 0x22DA6C0 VA: 0x1822DC0C0
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB730 Offset: 0xCAB30 VA: 0x1800CB730
	// RVA: 0x22DCDB0 Offset: 0x22DB3B0 VA: 0x1822DCDB0
	public static int StringToHash(string name) { }

	// RVA: 0x22DD010 Offset: 0x22DB610 VA: 0x1822DD010
	public void set_avatar(Avatar value) { }

	// RVA: 0x22DB8A0 Offset: 0x22D9EA0 VA: 0x1822DB8A0
	private void CheckIfInIKPass() { }

	// RVA: 0x22DC110 Offset: 0x22DA710 VA: 0x1822DC110
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB990 Offset: 0xCAD90 VA: 0x1800CB990
	// RVA: 0x22DC5F0 Offset: 0x22DABF0 VA: 0x1822DC5F0
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBBF0 Offset: 0xCAFF0 VA: 0x1800CBBF0
	// RVA: 0x22DC530 Offset: 0x22DAB30 VA: 0x1822DC530
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBD30 Offset: 0xCB130 VA: 0x1800CBD30
	// RVA: 0x22DBE20 Offset: 0x22DA420 VA: 0x1822DBE20
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBE10 Offset: 0xCB210 VA: 0x1800CBE10
	// RVA: 0x22DBDE0 Offset: 0x22DA3E0 VA: 0x1822DBDE0
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBEF0 Offset: 0xCB2F0 VA: 0x1800CBEF0
	// RVA: 0x22DC470 Offset: 0x22DAA70 VA: 0x1822DC470
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBFE0 Offset: 0xCB3E0 VA: 0x1800CBFE0
	// RVA: 0x22DC410 Offset: 0x22DAA10 VA: 0x1822DC410
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC1A0 Offset: 0xCB5A0 VA: 0x1800CC1A0
	// RVA: 0x22DBCC0 Offset: 0x22DA2C0 VA: 0x1822DBCC0
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC2E0 Offset: 0xCB6E0 VA: 0x1800CC2E0
	// RVA: 0x22DCA20 Offset: 0x22DB020 VA: 0x1822DCA20
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC470 Offset: 0xCB870 VA: 0x1800CC470
	// RVA: 0x22DC9D0 Offset: 0x22DAFD0 VA: 0x1822DC9D0
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC590 Offset: 0xCB990 VA: 0x1800CC590
	// RVA: 0x22DBF00 Offset: 0x22DA500 VA: 0x1822DBF00
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC7B0 Offset: 0xCBBB0 VA: 0x1800CC7B0
	// RVA: 0x22DCD60 Offset: 0x22DB360 VA: 0x1822DCD60
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC890 Offset: 0xCBC90 VA: 0x1800CC890
	// RVA: 0x22DCD20 Offset: 0x22DB320 VA: 0x1822DCD20
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	// RVA: 0x22DC3C0 Offset: 0x22DA9C0 VA: 0x1822DC3C0
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCB50 Offset: 0xCBF50 VA: 0x1800CCB50
	// RVA: 0x22DC380 Offset: 0x22DA980 VA: 0x1822DC380
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCCC0 Offset: 0xCC0C0 VA: 0x1800CCCC0
	// RVA: 0x22DC580 Offset: 0x22DAB80 VA: 0x1822DC580
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCE50 Offset: 0xCC250 VA: 0x1800CCE50
	// RVA: 0x22DC4D0 Offset: 0x22DAAD0 VA: 0x1822DC4D0
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCF10 Offset: 0xCC310 VA: 0x1800CCF10
	// RVA: 0x22DCDF0 Offset: 0x22DB3F0 VA: 0x1822DCDF0
	public void Update(float deltaTime) { }

	// RVA: 0x22DCF40 Offset: 0x22DB540 VA: 0x1822DCF40
	public bool get_logWarnings() { }

	// RVA: 0x22DD0A0 Offset: 0x22DB6A0 VA: 0x1822DD0A0
	public void set_fireEvents(bool value) { }

	// RVA: 0x22DC650 Offset: 0x22DAC50 VA: 0x1822DC650
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x22DC6F0 Offset: 0x22DACF0 VA: 0x1822DC6F0
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x22DCAD0 Offset: 0x22DB0D0 VA: 0x1822DCAD0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

