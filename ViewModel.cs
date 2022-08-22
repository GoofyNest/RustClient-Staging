public class ViewModel : MonoBehaviour, IClientComponent // TypeDefIndex: 9251
{	// Fields
	public GameObjectRef viewModelPrefab; // 0x18
	public HeldEntity targetEntity; // 0x20
	public BaseViewModel instance; // 0x28

	// Properties
	public bool ironSights { set; }

	// Methods

	// RVA: 0xADF120 Offset: 0xADD720 VA: 0x180ADF120
	public void Deploy(BaseEntity parent) { }

	// RVA: 0xADF490 Offset: 0xADDA90 VA: 0x180ADF490
	public void OnDisable() { }

	// RVA: 0xADF420 Offset: 0xADDA20 VA: 0x180ADF420
	public void Holster() { }

	// RVA: 0xADEFB0 Offset: 0xADD5B0 VA: 0x180ADEFB0
	public void Clear() { }

	// RVA: 0xADF500 Offset: 0xADDB00 VA: 0x180ADF500
	public void OnFrame() { }

	// RVA: 0xADF660 Offset: 0xADDC60 VA: 0x180ADF660
	public void Play(string name, int layer = 0) { }

	// RVA: 0xADF790 Offset: 0xADDD90 VA: 0x180ADF790
	public void ResetTrigger(string name) { }

	// RVA: 0xADF700 Offset: 0xADDD00 VA: 0x180ADF700
	public void ResetTrigger(int hash) { }

	// RVA: 0xADFAA0 Offset: 0xADE0A0 VA: 0x180ADFAA0
	public void Trigger(string name) { }

	// RVA: 0xADFB30 Offset: 0xADE130 VA: 0x180ADFB30
	public void Trigger(int hash) { }

	// RVA: 0xADF080 Offset: 0xADD680 VA: 0x180ADF080
	public void CrossFade(string name, float duration = 0,2) { }

	// RVA: 0xADF8C0 Offset: 0xADDEC0 VA: 0x180ADF8C0
	public void SetBool(string name, bool bState) { }

	// RVA: 0xADF820 Offset: 0xADDE20 VA: 0x180ADF820
	public void SetBool(int hash, bool bState) { }

	// RVA: 0xADFA00 Offset: 0xADE000 VA: 0x180ADFA00
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0xADF960 Offset: 0xADDF60 VA: 0x180ADF960
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0xADFBC0 Offset: 0xADE1C0 VA: 0x180ADFBC0
	public void set_ironSights(bool value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

