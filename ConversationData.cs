public class ConversationData : ScriptableObject // TypeDefIndex: 8840
{	// Fields
	public string shortname; // 0x18
	public Translate.Phrase providerNameTranslated; // 0x20
	public ConversationData.SpeechNode[] speeches; // 0x28

	// Properties
	public string providerName { get; }

	// Methods

	// RVA: 0x6BAFE0 Offset: 0x6B95E0 VA: 0x1806BAFE0
	public string get_providerName() { }

	// RVA: 0x6BAF30 Offset: 0x6B9530 VA: 0x1806BAF30
	public int GetSpeechNodeIndex(string speechShortName) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class ConversationData.ConversationCondition // TypeDefIndex: 8841
{	// Fields
	public ConversationData.ConversationCondition.ConditionType conditionType; // 0x10
	public uint conditionAmount; // 0x14
	public bool inverse; // 0x18
	public string failedSpeechNode; // 0x20

	// Methods

	// RVA: 0x6BADD0 Offset: 0x6B93D0 VA: 0x1806BADD0
	public bool Passes(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum ConversationData.ConversationCondition.ConditionType // TypeDefIndex: 8842
{	// Fields
	public int value__; // 0x0
	public const ConversationData.ConversationCondition.ConditionType NONE = 0;
	public const ConversationData.ConversationCondition.ConditionType HASHEALTH = 1;
	public const ConversationData.ConversationCondition.ConditionType HASSCRAP = 2;
	public const ConversationData.ConversationCondition.ConditionType PROVIDERBUSY = 3;
	public const ConversationData.ConversationCondition.ConditionType MISSIONCOMPLETE = 4;
	public const ConversationData.ConversationCondition.ConditionType MISSIONATTEMPTED = 5;
	public const ConversationData.ConversationCondition.ConditionType CANACCEPT = 6;

}

public class ConversationData.ResponseNode // TypeDefIndex: 8843
{	// Fields
	public Translate.Phrase responseTextLocalized; // 0x10
	public ConversationData.ConversationCondition[] conditions; // 0x18
	public string actionString; // 0x20
	public string resultingSpeechNode; // 0x28

	// Properties
	public string responseText { get; }

	// Methods

	// RVA: 0x6C8910 Offset: 0x6C6F10 VA: 0x1806C8910
	public string get_responseText() { }

	// RVA: 0x6C8730 Offset: 0x6C6D30 VA: 0x1806C8730
	public bool PassesConditions(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x6C8530 Offset: 0x6C6B30 VA: 0x1806C8530
	public string GetFailedSpeechNode(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ConversationData.SpeechNode // TypeDefIndex: 8844
{	// Fields
	public string shortname; // 0x10
	public Translate.Phrase statementLocalized; // 0x18
	public ConversationData.ResponseNode[] responses; // 0x20
	public Vector2 nodePosition; // 0x28

	// Properties
	public string statement { get; }

	// Methods

	// RVA: 0x6C8940 Offset: 0x6C6F40 VA: 0x1806C8940
	public string get_statement() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

