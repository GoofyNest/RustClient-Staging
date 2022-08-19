public class SoundVoiceLimiter : MonoBehaviour, IClientComponent // TypeDefIndex: 9045
{	// Fields
	public int maxSimultaneousSounds; // 0x18
	private List<Sound> sounds; // 0x20

	// Methods

	// RVA: 0xA7D320 Offset: 0xA7B920 VA: 0x180A7D320
	public void EnforceSoundLimit() { }

	// RVA: 0xA7D2C0 Offset: 0xA7B8C0 VA: 0x180A7D2C0
	public void AddSound(Sound sound) { }

	// RVA: 0xA7D520 Offset: 0xA7BB20 VA: 0x180A7D520
	public void RemoveSound(Sound sound) { }

	// RVA: 0xA7D580 Offset: 0xA7BB80 VA: 0x180A7D580
	public void .ctor() { }

}

