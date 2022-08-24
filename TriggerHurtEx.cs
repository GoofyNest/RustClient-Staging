public class TriggerHurtEx : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 10718
{	public float repeatRate; // 0x30
	[HeaderAttribute] // RVA: 0x75760 Offset: 0x74B60 VA: 0x180075760
	public List<DamageTypeEntry> damageOnEnter; // 0x38
	public GameObjectRef effectOnEnter; // 0x40
	public TriggerHurtEx.HurtType hurtTypeOnEnter; // 0x48
	[HeaderAttribute] // RVA: 0x75980 Offset: 0x74D80 VA: 0x180075980
	public List<DamageTypeEntry> damageOnTimer; // 0x50
	public GameObjectRef effectOnTimer; // 0x58
	public TriggerHurtEx.HurtType hurtTypeOnTimer; // 0x60
	[HeaderAttribute] // RVA: 0x75AE0 Offset: 0x74EE0 VA: 0x180075AE0
	public List<DamageTypeEntry> damageOnMove; // 0x68
	public GameObjectRef effectOnMove; // 0x70
	public TriggerHurtEx.HurtType hurtTypeOnMove; // 0x78
	[HeaderAttribute] // RVA: 0x75D00 Offset: 0x75100 VA: 0x180075D00
	public List<DamageTypeEntry> damageOnLeave; // 0x80
	public GameObjectRef effectOnLeave; // 0x88
	public TriggerHurtEx.HurtType hurtTypeOnLeave; // 0x90
	public bool damageEnabled; // 0x94


	public void .ctor() { }

}

public enum TriggerHurtEx.HurtType // TypeDefIndex: 10719
{	public int value__; // 0x0
	public const TriggerHurtEx.HurtType Simple = 0;
	public const TriggerHurtEx.HurtType IncludeBleedingAndScreenShake = 1;

}

