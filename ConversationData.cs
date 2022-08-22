public class ConversationData : ScriptableObject // TypeDefIndex: 8840
{	// Fields
	public string shortname; // 0x18
	public Translate.Phrase providerNameTranslated; // 0x20
	public ConversationData.SpeechNode[] speeches; // 0x28

	// Properties
	public string providerName { get; }

	// Methods

	// RVA: 0x6BB0F0 Offset: 0x6B96F0 VA: 0x1806BB0F0
	public string get_providerName() { }

	// RVA: 0x6BB040 Offset: 0x6B9640 VA: 0x1806BB040
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

	// RVA: 0x6BAEE0 Offset: 0x6B94E0 VA: 0x1806BAEE0
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

	// RVA: 0x6C8A20 Offset: 0x6C7020 VA: 0x1806C8A20
	public string get_responseText() { }

	// RVA: 0x6C8840 Offset: 0x6C6E40 VA: 0x1806C8840
	public bool PassesConditions(BasePlayer player, IConversationProvider provider) { }

	// RVA: 0x6C8640 Offset: 0x6C6C40 VA: 0x1806C8640
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

	// RVA: 0x6C8A50 Offset: 0x6C7050 VA: 0x1806C8A50
	public string get_statement() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

