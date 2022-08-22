public struct Option // TypeDefIndex: 7027
{	// Fields
	public Icons Icon; // 0x0
	public string Value; // 0x8
	public Translate.Phrase Label; // 0x10
	public bool Default; // 0x18

	// Methods

	// RVA: 0x14B640 Offset: 0x14AA40 VA: 0x18014B640
	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0x14B710 Offset: 0x14AB10 VA: 0x18014B710
	public void .ctor(Translate.Phrase phrase, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0x14B700 Offset: 0x14AB00 VA: 0x18014B700
	public void .ctor(Icons icon, string value, bool isdefault = False) { }

}

public struct Option // TypeDefIndex: 11674
{	// Fields
	public string title; // 0x0
	public string desc; // 0x8
	public string requirements; // 0x10
	public string icon; // 0x18
	public bool showOnItem; // 0x20
	public int order; // 0x24
	public float time; // 0x28
	public bool usableWhileWounded; // 0x2C
	public bool longUseOnly; // 0x2D
	public bool showDisabled; // 0x2E
	public bool show; // 0x2F
	public Action<BasePlayer> function; // 0x30
	public Action timeStart; // 0x38
	public Action timeProgress; // 0x40
	public Sprite iconSprite; // 0x48
	public string command; // 0x50

	// Properties
	public BaseEntity.Menu.Option copyOptionsFrom { set; }

	// Methods

	// RVA: 0xF4FC0 Offset: 0xF43C0 VA: 0x1800F4FC0
	public void set_copyOptionsFrom(BaseEntity.Menu.Option value) { }

	// RVA: 0xF4FA0 Offset: 0xF43A0 VA: 0x1800F4FA0
	public void RunTimeStart() { }

	// RVA: 0xF4F80 Offset: 0xF4380 VA: 0x1800F4F80
	public void RunTimeProgress() { }

}

