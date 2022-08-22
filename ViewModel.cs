public class ViewModel : MonoBehaviour, IClientComponent // TypeDefIndex: 9251
{	// Fields
	public GameObjectRef viewModelPrefab; // 0x18
	public HeldEntity targetEntity; // 0x20
	public BaseViewModel instance; // 0x28

	// Properties
	public bool ironSights { set; }

	// Methods

	// RVA: 0xADF5F0 Offset: 0xADDBF0 VA: 0x180ADF5F0
	public void Deploy(BaseEntity parent) { }

	// RVA: 0xADF960 Offset: 0xADDF60 VA: 0x180ADF960
	public void OnDisable() { }

	// RVA: 0xADF8F0 Offset: 0xADDEF0 VA: 0x180ADF8F0
	public void Holster() { }

	// RVA: 0xADF480 Offset: 0xADDA80 VA: 0x180ADF480
	public void Clear() { }

	// RVA: 0xADF9D0 Offset: 0xADDFD0 VA: 0x180ADF9D0
	public void OnFrame() { }

	// RVA: 0xADFB30 Offset: 0xADE130 VA: 0x180ADFB30
	public void Play(string name, int layer = 0) { }

	// RVA: 0xADFC60 Offset: 0xADE260 VA: 0x180ADFC60
	public void ResetTrigger(string name) { }

	// RVA: 0xADFBD0 Offset: 0xADE1D0 VA: 0x180ADFBD0
	public void ResetTrigger(int hash) { }

	// RVA: 0xADFF70 Offset: 0xADE570 VA: 0x180ADFF70
	public void Trigger(string name) { }

	// RVA: 0xAE0000 Offset: 0xADE600 VA: 0x180AE0000
	public void Trigger(int hash) { }

	// RVA: 0xADF550 Offset: 0xADDB50 VA: 0x180ADF550
	public void CrossFade(string name, float duration = 0,2) { }

	// RVA: 0xADFD90 Offset: 0xADE390 VA: 0x180ADFD90
	public void SetBool(string name, bool bState) { }

	// RVA: 0xADFCF0 Offset: 0xADE2F0 VA: 0x180ADFCF0
	public void SetBool(int hash, bool bState) { }

	// RVA: 0xADFED0 Offset: 0xADE4D0 VA: 0x180ADFED0
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0xADFE30 Offset: 0xADE430 VA: 0x180ADFE30
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0xAE0090 Offset: 0xADE690 VA: 0x180AE0090
	public void set_ironSights(bool value) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

