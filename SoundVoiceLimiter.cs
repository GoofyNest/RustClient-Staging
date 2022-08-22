public class SoundVoiceLimiter : MonoBehaviour, IClientComponent // TypeDefIndex: 9045
{	// Fields
	public int maxSimultaneousSounds; // 0x18
	private List<Sound> sounds; // 0x20

	// Methods

	// RVA: 0xA7DAB0 Offset: 0xA7C0B0 VA: 0x180A7DAB0
	public void EnforceSoundLimit() { }

	// RVA: 0xA7DA50 Offset: 0xA7C050 VA: 0x180A7DA50
	public void AddSound(Sound sound) { }

	// RVA: 0xA7DCB0 Offset: 0xA7C2B0 VA: 0x180A7DCB0
	public void RemoveSound(Sound sound) { }

	// RVA: 0xA7DD10 Offset: 0xA7C310 VA: 0x180A7DD10
	public void .ctor() { }

}

