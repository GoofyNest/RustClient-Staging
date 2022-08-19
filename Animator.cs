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

	[NativeMethodAttribute] // RVA: 0xCA460 Offset: 0xC9860 VA: 0x1800CA460
	// RVA: 0x22DD080 Offset: 0x22DB680 VA: 0x1822DD080
	public bool get_isInitialized() { }

	// RVA: 0x22DBFE0 Offset: 0x22DA5E0 VA: 0x1822DBFE0
	public float GetFloat(string name) { }

	// RVA: 0x22DBFA0 Offset: 0x22DA5A0 VA: 0x1822DBFA0
	public float GetFloat(int id) { }

	// RVA: 0x22DC7B0 Offset: 0x22DADB0 VA: 0x1822DC7B0
	public void SetFloat(string name, float value) { }

	// RVA: 0x22DC740 Offset: 0x22DAD40 VA: 0x1822DC740
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DC6F0 Offset: 0x22DACF0 VA: 0x1822DC6F0
	public void SetFloat(int id, float value) { }

	// RVA: 0x22DC690 Offset: 0x22DAC90 VA: 0x1822DC690
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x22DBE80 Offset: 0x22DA480 VA: 0x1822DBE80
	public bool GetBool(int id) { }

	// RVA: 0x22DC630 Offset: 0x22DAC30 VA: 0x1822DC630
	public void SetBool(string name, bool value) { }

	// RVA: 0x22DC5D0 Offset: 0x22DABD0 VA: 0x1822DC5D0
	public void SetBool(int id, bool value) { }

	// RVA: 0x22DC0C0 Offset: 0x22DA6C0 VA: 0x1822DC0C0
	public int GetInteger(string name) { }

	// RVA: 0x22DCBE0 Offset: 0x22DB1E0 VA: 0x1822DCBE0
	public void SetInteger(string name, int value) { }

	// RVA: 0x22DCB90 Offset: 0x22DB190 VA: 0x1822DCB90
	public void SetInteger(int id, int value) { }

	// RVA: 0x22DCF20 Offset: 0x22DB520 VA: 0x1822DCF20
	public void SetTrigger(string name) { }

	// RVA: 0x22DCEE0 Offset: 0x22DB4E0 VA: 0x1822DCEE0
	public void SetTrigger(int id) { }

	// RVA: 0x22DC580 Offset: 0x22DAB80 VA: 0x1822DC580
	public void ResetTrigger(string name) { }

	// RVA: 0x22DC540 Offset: 0x22DAB40 VA: 0x1822DC540
	public void ResetTrigger(int id) { }

	// RVA: 0x22DD180 Offset: 0x22DB780 VA: 0x1822DD180
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x22DD350 Offset: 0x22DB950 VA: 0x1822DD350
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x22DCA50 Offset: 0x22DB050 VA: 0x1822DCA50
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DC860 Offset: 0x22DAE60 VA: 0x1822DC860
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x22DCB20 Offset: 0x22DB120 VA: 0x1822DCB20
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DC900 Offset: 0x22DAF00 VA: 0x1822DC900
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x22DC070 Offset: 0x22DA670 VA: 0x1822DC070
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x22DC030 Offset: 0x22DA630 VA: 0x1822DC030
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x22DC9F0 Offset: 0x22DAFF0 VA: 0x1822DC9F0
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DC950 Offset: 0x22DAF50 VA: 0x1822DC950
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCAC0 Offset: 0x22DB0C0 VA: 0x1822DCAC0
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DC9A0 Offset: 0x22DAFA0 VA: 0x1822DC9A0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x22DCD30 Offset: 0x22DB330 VA: 0x1822DCD30
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethodAttribute] // RVA: 0xCA5D0 Offset: 0xC99D0 VA: 0x1800CA5D0
	// RVA: 0x22DCCE0 Offset: 0x22DB2E0 VA: 0x1822DCCE0
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x22DCE00 Offset: 0x22DB400 VA: 0x1822DCE00
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x22DCE70 Offset: 0x22DB470 VA: 0x1822DCE70
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethodAttribute] // RVA: 0xCA940 Offset: 0xC9D40 VA: 0x1800CA940
	// RVA: 0x22DCD90 Offset: 0x22DB390 VA: 0x1822DCD90
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x22DD0C0 Offset: 0x22DB6C0 VA: 0x1822DD0C0
	public int get_layerCount() { }

	// RVA: 0x22DC110 Offset: 0x22DA710 VA: 0x1822DC110
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x22DC160 Offset: 0x22DA760 VA: 0x1822DC160
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x22DCC40 Offset: 0x22DB240 VA: 0x1822DCC40
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x22DBE20 Offset: 0x22DA420 VA: 0x1822DBE20
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x22DBF00 Offset: 0x22DA500 VA: 0x1822DBF00
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x22DC1E0 Offset: 0x22DA7E0 VA: 0x1822DC1E0
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCA9A0 Offset: 0xC9DA0 VA: 0x1800CA9A0
	// RVA: 0x22DBEC0 Offset: 0x22DA4C0 VA: 0x1822DBEC0
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[FreeFunctionAttribute] // RVA: 0xCAB60 Offset: 0xC9F60 VA: 0x1800CAB60
	// RVA: 0x22DC1A0 Offset: 0x22DA7A0 VA: 0x1822DC1A0
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x22DC310 Offset: 0x22DA910 VA: 0x1822DC310
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x22DD300 Offset: 0x22DB900 VA: 0x1822DD300
	public void set_speed(float value) { }

	// RVA: 0x22DBC30 Offset: 0x22DA230 VA: 0x1822DBC30
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DBB10 Offset: 0x22DA110 VA: 0x1822DBB10
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DBD90 Offset: 0x22DA390 VA: 0x1822DBD90
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunctionAttribute] // RVA: 0xCAF00 Offset: 0xCA300 VA: 0x1800CAF00
	// RVA: 0x22DBCC0 Offset: 0x22DA2C0 VA: 0x1822DBCC0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x22DBD20 Offset: 0x22DA320 VA: 0x1822DBD20
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x22DBBB0 Offset: 0x22DA1B0 VA: 0x1822DBBB0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x22DC520 Offset: 0x22DAB20 VA: 0x1822DC520
	public void Play(string stateName, int layer) { }

	// RVA: 0x22DC440 Offset: 0x22DAA40 VA: 0x1822DC440
	public void Play(string stateName) { }

	// RVA: 0x22DC350 Offset: 0x22DA950 VA: 0x1822DC350
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunctionAttribute] // RVA: 0xCB210 Offset: 0xCA610 VA: 0x1800CB210
	// RVA: 0x22DC3E0 Offset: 0x22DA9E0 VA: 0x1822DC3E0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x22DC4C0 Offset: 0x22DAAC0 VA: 0x1822DC4C0
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x22DC470 Offset: 0x22DAA70 VA: 0x1822DC470
	public void Play(int stateNameHash) { }

	// RVA: 0x22DD000 Offset: 0x22DB600 VA: 0x1822DD000
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x22DD220 Offset: 0x22DB820 VA: 0x1822DD220
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x22DD140 Offset: 0x22DB740 VA: 0x1822DD140
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x22DD2B0 Offset: 0x22DB8B0 VA: 0x1822DD2B0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethodAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	// RVA: 0x22DD040 Offset: 0x22DB640 VA: 0x1822DD040
	public bool get_hasBoundPlayables() { }

	// RVA: 0x22DC280 Offset: 0x22DA880 VA: 0x1822DC280
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethodAttribute] // RVA: 0xCB6A0 Offset: 0xCAAA0 VA: 0x1800CB6A0
	// RVA: 0x22DCF70 Offset: 0x22DB570 VA: 0x1822DCF70
	public static int StringToHash(string name) { }

	// RVA: 0x22DD1D0 Offset: 0x22DB7D0 VA: 0x1822DD1D0
	public void set_avatar(Avatar value) { }

	// RVA: 0x22DBA60 Offset: 0x22DA060 VA: 0x1822DBA60
	private void CheckIfInIKPass() { }

	// RVA: 0x22DC2D0 Offset: 0x22DA8D0 VA: 0x1822DC2D0
	private bool IsInIKPass() { }

	[FreeFunctionAttribute] // RVA: 0xCB900 Offset: 0xCAD00 VA: 0x1800CB900
	// RVA: 0x22DC7B0 Offset: 0x22DADB0 VA: 0x1822DC7B0
	private void SetFloatString(string name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBB60 Offset: 0xCAF60 VA: 0x1800CBB60
	// RVA: 0x22DC6F0 Offset: 0x22DACF0 VA: 0x1822DC6F0
	private void SetFloatID(int id, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCBCA0 Offset: 0xCB0A0 VA: 0x1800CBCA0
	// RVA: 0x22DBFE0 Offset: 0x22DA5E0 VA: 0x1822DBFE0
	private float GetFloatString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCBDB0 Offset: 0xCB1B0 VA: 0x1800CBDB0
	// RVA: 0x22DBFA0 Offset: 0x22DA5A0 VA: 0x1822DBFA0
	private float GetFloatID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	// RVA: 0x22DC630 Offset: 0x22DAC30 VA: 0x1822DC630
	private void SetBoolString(string name, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCBF50 Offset: 0xCB350 VA: 0x1800CBF50
	// RVA: 0x22DC5D0 Offset: 0x22DABD0 VA: 0x1822DC5D0
	private void SetBoolID(int id, bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCC110 Offset: 0xCB510 VA: 0x1800CC110
	// RVA: 0x22DBE80 Offset: 0x22DA480 VA: 0x1822DBE80
	private bool GetBoolID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC250 Offset: 0xCB650 VA: 0x1800CC250
	// RVA: 0x22DCBE0 Offset: 0x22DB1E0 VA: 0x1822DCBE0
	private void SetIntegerString(string name, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC410 Offset: 0xCB810 VA: 0x1800CC410
	// RVA: 0x22DCB90 Offset: 0x22DB190 VA: 0x1822DCB90
	private void SetIntegerID(int id, int value) { }

	[FreeFunctionAttribute] // RVA: 0xCC4E0 Offset: 0xCB8E0 VA: 0x1800CC4E0
	// RVA: 0x22DC0C0 Offset: 0x22DA6C0 VA: 0x1822DC0C0
	private int GetIntegerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC720 Offset: 0xCBB20 VA: 0x1800CC720
	// RVA: 0x22DCF20 Offset: 0x22DB520 VA: 0x1822DCF20
	private void SetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCC7B0 Offset: 0xCBBB0 VA: 0x1800CC7B0
	// RVA: 0x22DCEE0 Offset: 0x22DB4E0 VA: 0x1822DCEE0
	private void SetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCC960 Offset: 0xCBD60 VA: 0x1800CC960
	// RVA: 0x22DC580 Offset: 0x22DAB80 VA: 0x1822DC580
	private void ResetTriggerString(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCCAC0 Offset: 0xCBEC0 VA: 0x1800CCAC0
	// RVA: 0x22DC540 Offset: 0x22DAB40 VA: 0x1822DC540
	private void ResetTriggerID(int id) { }

	[FreeFunctionAttribute] // RVA: 0xCCC00 Offset: 0xCC000 VA: 0x1800CCC00
	// RVA: 0x22DC740 Offset: 0x22DAD40 VA: 0x1822DC740
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xCCDC0 Offset: 0xCC1C0 VA: 0x1800CCDC0
	// RVA: 0x22DC690 Offset: 0x22DAC90 VA: 0x1822DC690
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[NativeMethodAttribute] // RVA: 0xCCE80 Offset: 0xCC280 VA: 0x1800CCE80
	// RVA: 0x22DCFB0 Offset: 0x22DB5B0 VA: 0x1822DCFB0
	public void Update(float deltaTime) { }

	// RVA: 0x22DD100 Offset: 0x22DB700 VA: 0x1822DD100
	public bool get_logWarnings() { }

	// RVA: 0x22DD260 Offset: 0x22DB860 VA: 0x1822DD260
	public void set_fireEvents(bool value) { }

	// RVA: 0x22DC810 Offset: 0x22DAE10 VA: 0x1822DC810
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x22DC8B0 Offset: 0x22DAEB0 VA: 0x1822DC8B0
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x22DCC90 Offset: 0x22DB290 VA: 0x1822DCC90
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

}

