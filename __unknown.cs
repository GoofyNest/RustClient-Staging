internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <message>j__TPar <message>i__Field; // 0x0


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(<message>j__TPar message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13593D0 Offset: 0x13579D0 VA: 0x1813593D0
	|-<>f__AnonymousType0<object>..ctor
	|-<>f__AnonymousType0<string>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895E80 Offset: 0x1894480 VA: 0x181895E80
	|-<>f__AnonymousType0<object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895F30 Offset: 0x1894530 VA: 0x181895F30
	|-<>f__AnonymousType0<object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895F80 Offset: 0x1894580 VA: 0x181895F80
	|-<>f__AnonymousType0<object>.ToString
	*/

}

internal class __Filters // TypeDefIndex: 143
{	internal static readonly __Filters Instance; // 0x139A7


	internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) { }

	internal virtual bool FilterName(MemberInfo m, object filterCriteria) { }

	internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 155
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Func<MP3Stream>..ctor
	|-Func<JsonSerializerSettings>..ctor
	|-Func<PublishResult>..ctor
	|-Func<bool>..ctor
	|-Func<byte>..ctor
	|-Func<Stream>..ctor
	|-Func<int>..ctor
	|-Func<UdpReceiveResult>..ctor
	|-Func<Nullable<ServerInfo>>..ctor
	|-Func<Nullable<Image>>..ctor
	|-Func<Nullable<InventoryPurchaseResult>>..ctor
	|-Func<Nullable<InventoryResult>>..ctor
	|-Func<Nullable<Item>>..ctor
	|-Func<Nullable<ResultPage>>..ctor
	|-Func<Nullable<int>>..ctor
	|-Func<Nullable<Int32Enum>>..ctor
	|-Func<object>..ctor
	|-Func<string>..ctor
	|-Func<StringBuilder>..ctor
	|-Func<ManualResetEvent>..ctor
	|-Func<SemaphoreSlim>..ctor
	|-Func<Task.ContingentProperties>..ctor
	|-Func<Task<Stream>>..ctor
	|-Func<Task<WebResponse>>..ctor
	|-Func<VoidTaskResult>..ctor
	*/

	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B895F0 Offset: 0x1B87BF0 VA: 0x181B895F0
	|-Func<JsonSerializerSettings>.Invoke
	|-Func<IReferenceResolver>.Invoke
	|-Func<string>.Invoke
	|-Func<object>.Invoke
	|
	|-RVA: 0x1B89FF0 Offset: 0x1B885F0 VA: 0x181B89FF0
	|-Func<bool>.Invoke
	|-Func<byte>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-RVA: 0x1B89D80 Offset: 0x1B88380 VA: 0x181B89D80
	|-Func<int>.Invoke
	|
	|-RVA: 0x1B89AD0 Offset: 0x1B880D0 VA: 0x181B89AD0
	|-Func<PublishResult>.Invoke
	|-Func<Nullable<Image>>.Invoke
	|
	|-RVA: 0x1221520 Offset: 0x121FB20 VA: 0x181221520
	|-Func<UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1B8A7F0 Offset: 0x1B88DF0 VA: 0x181B8A7F0
	|-Func<Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x1B89340 Offset: 0x1B87940 VA: 0x181B89340
	|-Func<Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x1977F10 Offset: 0x1976510 VA: 0x181977F10
	|-Func<Nullable<InventoryResult>>.Invoke
	|
	|-RVA: 0x1B8A260 Offset: 0x1B88860 VA: 0x181B8A260
	|-Func<Nullable<Item>>.Invoke
	|
	|-RVA: 0x1B89860 Offset: 0x1B87E60 VA: 0x181B89860
	|-Func<Nullable<int>>.Invoke
	|-Func<Nullable<Int32Enum>>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190
	|-Func<PublishResult>.BeginInvoke
	|-Func<bool>.BeginInvoke
	|-Func<byte>.BeginInvoke
	|-Func<int>.BeginInvoke
	|-Func<UdpReceiveResult>.BeginInvoke
	|-Func<Nullable<ServerInfo>>.BeginInvoke
	|-Func<Nullable<Image>>.BeginInvoke
	|-Func<Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<Nullable<InventoryResult>>.BeginInvoke
	|-Func<Nullable<Item>>.BeginInvoke
	|-Func<Nullable<ResultPage>>.BeginInvoke
	|-Func<Nullable<int>>.BeginInvoke
	|-Func<Nullable<Int32Enum>>.BeginInvoke
	|-Func<object>.BeginInvoke
	|-Func<VoidTaskResult>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19E6920 Offset: 0x19E4F20 VA: 0x1819E6920
	|-Func<PublishResult>.EndInvoke
	|-Func<Nullable<Image>>.EndInvoke
	|
	|-RVA: 0xFF70B0 Offset: 0xFF56B0 VA: 0x180FF70B0
	|-Func<bool>.EndInvoke
	|-Func<byte>.EndInvoke
	|-Func<VoidTaskResult>.EndInvoke
	|
	|-RVA: 0xB9AFA0 Offset: 0xB995A0 VA: 0x180B9AFA0
	|-Func<int>.EndInvoke
	|
	|-RVA: 0x12214E0 Offset: 0x121FAE0 VA: 0x1812214E0
	|-Func<UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0x19E6790 Offset: 0x19E4D90 VA: 0x1819E6790
	|-Func<Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19E6800 Offset: 0x19E4E00 VA: 0x1819E6800
	|-Func<Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x1977ED0 Offset: 0x19764D0 VA: 0x181977ED0
	|-Func<Nullable<InventoryResult>>.EndInvoke
	|
	|-RVA: 0x19E6870 Offset: 0x19E4E70 VA: 0x1819E6870
	|-Func<Nullable<Item>>.EndInvoke
	|
	|-RVA: 0x1221E30 Offset: 0x1220430 VA: 0x181221E30
	|-Func<Nullable<int>>.EndInvoke
	|-Func<Nullable<Int32Enum>>.EndInvoke
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Func<object>.EndInvoke
	*/

}

public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 156
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Func<AchievementGroup.AchievementItem, bool>..ctor
	|-Func<BaseEntity, bool>..ctor
	|-Func<BaseNetworkable, Debugging.EntityInfo>..ctor
	|-Func<BaseNetworkable, bool>..ctor
	|-Func<BaseNetworkable, uint>..ctor
	|-Func<BaseViewModel, string>..ctor
	|-Func<Admin.PlayerInfo, GameObjectRef>..ctor
	|-Func<Admin.PlayerInfo, object>..ctor
	|-Func<Admin.ServerConvarInfo, GameObjectRef>..ctor
	|-Func<Admin.ServerConvarInfo, object>..ctor
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>..ctor
	|-Func<Debugging.EntityInfo, bool>..ctor
	|-Func<Entity.EntityInfo, bool>..ctor
	|-Func<ConsoleSystem.Command, bool>..ctor
	|-Func<ConstructionGrade, BuildingGrade.Enum>..ctor
	|-Func<ConstructionGrade, bool>..ctor
	|-Func<CraftingQueueIcon, bool>..ctor
	|-Func<Demos.DemoInfo, DateTime>..ctor
	|-Func<Demos.DemoInfo, object>..ctor
	|-Func<Demos.DemoInfo, string>..ctor
	|-Func<Demos.DemoInfo, TimeSpan>..ctor
	|-Func<DungeonBaseInfo, int>..ctor
	|-Func<EZSoftBone.BoneChain, int>..ctor
	|-Func<AccountNotice, bool>..ctor
	|-Func<AccountNotice, DateTime>..ctor
	|-Func<BurstCloth.Chain, FourBitNumber>..ctor
	|-Func<BurstCloth.Chain, SevenBitNumber>..ctor
	|-Func<BurstCloth.Chain, bool>..ctor
	|-Func<BurstCloth.Chain, int>..ctor
	|-Func<CardPlayerData, bool>..ctor
	|-Func<Hero, Guid>..ctor
	|-Func<Input.Button, bool>..ctor
	|-Func<Input.Button, string>..ctor
	|-Func<Manifest.Administrator, bool>..ctor
	|-Func<Manifest.NewsInfo.BlogInfo, string>..ctor
	|-Func<Manifest.ServerDesc, string>..ctor
	|-Func<RCon.BannedAddresses, bool>..ctor
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>..ctor
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>..ctor
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>..ctor
	|-Func<SkeletonDefinition.Bone, Option>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryItem>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>..ctor
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>..ctor
	|-Func<SkeletonDefinition.Bone, bool>..ctor
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>..ctor
	|-Func<SkeletonDefinition.Bone, int>..ctor
	|-Func<SkeletonDefinition.Bone, Int32Enum>..ctor
	|-Func<SkeletonDefinition.Bone, long>..ctor
	|-Func<SkeletonDefinition.Bone, object>..ctor
	|-Func<SkeletonDefinition.Bone, float>..ctor
	|-Func<SkeletonDefinition.Bone, GameObject>..ctor
	|-Func<SkeletonDefinition.Bone, Resolution>..ctor
	|-Func<SkeletonDefinition.Bone, Transform>..ctor
	|-Func<WeightedStringList.Container, bool>..ctor
	|-Func<WeightedStringList.Container, float>..ctor
	|-Func<GameManifest.PrefabProperties, bool>..ctor
	|-Func<GameManifest.PrefabProperties, string>..ctor
	|-Func<GameStat.Stat, bool>..ctor
	|-Func<GenerateDungeonBase.DungeonSegment, float>..ctor
	|-Func<GenerateDungeonGrid.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateDungeonGrid.PathNode, bool>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GeneratePowerlineLayout.PathNode, bool>..ctor
	|-Func<GenerateRoadLayout.PathNode, PathFinder.Point>..ctor
	|-Func<GenerateRoadLayout.PathNode, bool>..ctor
	|-Func<HitboxDefinition, int>..ctor
	|-Func<IPlayerInfo, bool>..ctor
	|-Func<IPlayerInfo, int>..ctor
	|-Func<IPlayerInfo, string>..ctor
	|-Func<IPlayerItem, bool>..ctor
	|-Func<IPlayerItem, DateTimeOffset>..ctor
	|-Func<IPlayerItem, int>..ctor
	|-Func<IPlayerItemDefinition, bool>..ctor
	|-Func<IPlayerItemDefinition, int>..ctor
	|-Func<ImageStorageEntity.ImageRequest, IImageReceiver>..ctor
	|-Func<ImageStorageEntity.ImageRequest, object>..ctor
	|-Func<Item, bool>..ctor
	|-Func<Item, int>..ctor
	|-Func<ItemBlueprint, Rarity>..ctor
	|-Func<ItemBlueprint, bool>..ctor
	|-Func<ItemBlueprint, int>..ctor
	|-Func<ItemDefinition, ItemCategory>..ctor
	|-Func<ItemDefinition, ItemModWearable>..ctor
	|-Func<ItemDefinition, bool>..ctor
	|-Func<ItemDefinition, float>..ctor
	|-Func<ItemDefinition, string>..ctor
	|-Func<ItemIcon, int>..ctor
	|-Func<ItemModWearable, bool>..ctor
	|-Func<ItemModWearable, Guid>..ctor
	|-Func<ItemSkinDirectory.Skin, bool>..ctor
	|-Func<LoadAssetsResult, bool>..ctor
	|-Func<LoadAssetsResult, int>..ctor
	|-Func<FourBitNumber, FourBitNumber>..ctor
	|-Func<FourBitNumber, bool>..ctor
	|-Func<SevenBitNumber, SevenBitNumber>..ctor
	|-Func<SevenBitNumber, bool>..ctor
	|-Func<SevenBitNumber, object>..ctor
	|-Func<EventsCollection, int>..ctor
	|-Func<TrackChunk, EventsCollection>..ctor
	|-Func<TrackChunk, bool>..ctor
	|-Func<ITempoMapValuesCache, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, bool>..ctor
	|-Func<MetricTempoMapValuesCache.AccumulatedMicroseconds, long>..ctor
	|-Func<ValueChange<TimeSignature>, bool>..ctor
	|-Func<MusicTheme, float>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, object>..ctor
	|-Func<DefaultSerializationBinder.TypeNameKey, Type>..ctor
	|-Func<JsonProperty, JsonProperty>..ctor
	|-Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence>..ctor
	|-Func<JsonProperty, int>..ctor
	|-Func<JsonProperty, string>..ctor
	|-Func<JsonSerializerInternalReader.CreatorPropertyContext, bool>..ctor
	|-Func<ConvertUtils.TypeConvertKey, Func<object, object>>..ctor
	|-Func<ConvertUtils.TypeConvertKey, object>..ctor
	|-Func<PathFinder.Point, PathFinder.Point>..ctor
	|-Func<PathFinder.Point, bool>..ctor
	|-Func<PetCommandList.PetCommandDesc, bool>..ctor
	|-Func<PieMenu.MenuOption, bool>..ctor
	|-Func<PieMenu.MenuOption, int>..ctor
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>..ctor
	|-Func<PlayerItemRecipe, IPlayerItemDefinition>..ctor
	|-Func<PlayerItemRecipe, PathFinder.Point>..ctor
	|-Func<PlayerItemRecipe, PlayerItemRecipe>..ctor
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>..ctor
	|-Func<PlayerItemRecipe, Option>..ctor
	|-Func<PlayerItemRecipe, InventoryItem>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe, InventoryRecipe>..ctor
	|-Func<PlayerItemRecipe, bool>..ctor
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>..ctor
	|-Func<PlayerItemRecipe, int>..ctor
	|-Func<PlayerItemRecipe, Int32Enum>..ctor
	|-Func<PlayerItemRecipe, long>..ctor
	|-Func<PlayerItemRecipe, object>..ctor
	|-Func<PlayerItemRecipe, float>..ctor
	|-Func<PlayerItemRecipe, Resolution>..ctor
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>..ctor
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<PlayerItemRecipe.Ingredient, bool>..ctor
	|-Func<PlayerItemRecipe.Ingredient, int>..ctor
	|-Func<Prefab, bool>..ctor
	|-Func<Prefab<DungeonGridLink>, int>..ctor
	|-Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ProjectileWeaponMod.Modifier, bool>..ctor
	|-Func<ProjectileWeaponMod.Modifier, float>..ctor
	|-Func<MarketTerminal.PendingOrder, uint>..ctor
	|-Func<PathData, PathList>..ctor
	|-Func<PathData, bool>..ctor
	|-Func<PlayerNameID, bool>..ctor
	|-Func<PlayerTeam.TeamMember, ulong>..ctor
	|-Func<PrefabData, bool>..ctor
	|-Func<PrefabData, string>..ctor
	|-Func<RelationshipManager.PlayerRelationshipInfo, ulong>..ctor
	|-Func<Indexer.Entity, Indexer.Entity>..ctor
	|-Func<Indexer.Entity, uint>..ctor
	|-Func<SteamItem, InventoryItem>..ctor
	|-Func<SteamItemDefinition, InventoryDef>..ctor
	|-Func<Option, Option>..ctor
	|-Func<Option, bool>..ctor
	|-Func<OptionAttribute, Option>..ctor
	|-Func<SteamInventoryItem, bool>..ctor
	|-Func<SteamInventoryItem, IEnumerable<PlayerItemRecipe>>..ctor
	|-Func<SteamInventoryItem, Task<IPlayerInventory>>..ctor
	|-Func<ServerBrowserTag, bool>..ctor
	|-Func<ServerInfo, Debugging.EntityInfo>..ctor
	|-Func<ServerInfo, FourBitNumber>..ctor
	|-Func<ServerInfo, SevenBitNumber>..ctor
	|-Func<ServerInfo, PathFinder.Point>..ctor
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>..ctor
	|-Func<ServerInfo, Option>..ctor
	|-Func<ServerInfo, InventoryItem>..ctor
	|-Func<ServerInfo, InventoryRecipe.Ingredient>..ctor
	|-Func<ServerInfo, InventoryRecipe>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, KeyValuePair<object, int>>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, Int32Enum>..ctor
	|-Func<ServerInfo, long>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<ServerInfo, float>..ctor
	|-Func<ServerInfo, string>..ctor
	|-Func<ServerInfo, uint>..ctor
	|-Func<ServerInfo, Resolution>..ctor
	|-Func<SkeletonProperties.BoneProperty, bool>..ctor
	|-Func<Skinnable, bool>..ctor
	|-Func<Skinnable, string>..ctor
	|-Func<SkinnedMultiMesh.Part, bool>..ctor
	|-Func<SkinnedMultiMesh.Part, long>..ctor
	|-Func<Achievement, <>f__AnonymousType0<string, string, bool>>..ctor
	|-Func<Achievement, Debugging.EntityInfo>..ctor
	|-Func<Achievement, PathFinder.Point>..ctor
	|-Func<Achievement, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Achievement, Option>..ctor
	|-Func<Achievement, InventoryItem>..ctor
	|-Func<Achievement, InventoryRecipe.Ingredient>..ctor
	|-Func<Achievement, InventoryRecipe>..ctor
	|-Func<Achievement, bool>..ctor
	|-Func<Achievement, KeyValuePair<object, int>>..ctor
	|-Func<Achievement, int>..ctor
	|-Func<Achievement, Int32Enum>..ctor
	|-Func<Achievement, long>..ctor
	|-Func<Achievement, object>..ctor
	|-Func<Achievement, float>..ctor
	|-Func<Achievement, Resolution>..ctor
	|-Func<InventoryDefId, Debugging.EntityInfo>..ctor
	|-Func<InventoryDefId, PathFinder.Point>..ctor
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryDefId, Option>..ctor
	|-Func<InventoryDefId, InventoryDef>..ctor
	|-Func<InventoryDefId, InventoryItem>..ctor
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryDefId, InventoryRecipe>..ctor
	|-Func<InventoryDefId, bool>..ctor
	|-Func<InventoryDefId, KeyValuePair<object, int>>..ctor
	|-Func<InventoryDefId, int>..ctor
	|-Func<InventoryDefId, Int32Enum>..ctor
	|-Func<InventoryDefId, long>..ctor
	|-Func<InventoryDefId, object>..ctor
	|-Func<InventoryDefId, float>..ctor
	|-Func<InventoryDefId, Resolution>..ctor
	|-Func<InventoryItemId, InventoryItemId>..ctor
	|-Func<InventoryItemId, bool>..ctor
	|-Func<ServerInfo, ServerInfo>..ctor
	|-Func<ServerInfo, bool>..ctor
	|-Func<ServerInfo, int>..ctor
	|-Func<ServerInfo, object>..ctor
	|-Func<Friend, Debugging.EntityInfo>..ctor
	|-Func<Friend, PathFinder.Point>..ctor
	|-Func<Friend, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Friend, SteamPlayer>..ctor
	|-Func<Friend, Option>..ctor
	|-Func<Friend, InventoryItem>..ctor
	|-Func<Friend, InventoryRecipe.Ingredient>..ctor
	|-Func<Friend, InventoryRecipe>..ctor
	|-Func<Friend, bool>..ctor
	|-Func<Friend, KeyValuePair<object, int>>..ctor
	|-Func<Friend, int>..ctor
	|-Func<Friend, Int32Enum>..ctor
	|-Func<Friend, long>..ctor
	|-Func<Friend, object>..ctor
	|-Func<Friend, float>..ctor
	|-Func<Friend, Resolution>..ctor
	|-Func<InventoryDef, IPlayerItemDefinition>..ctor
	|-Func<InventoryDef, SteamItemDefinition>..ctor
	|-Func<InventoryDef, InventoryDefId>..ctor
	|-Func<InventoryDef, InventoryRecipe[]>..ctor
	|-Func<InventoryDef, string>..ctor
	|-Func<InventoryItem, Debugging.EntityInfo>..ctor
	|-Func<InventoryItem, FourBitNumber>..ctor
	|-Func<InventoryItem, SevenBitNumber>..ctor
	|-Func<InventoryItem, PathFinder.Point>..ctor
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryItem, SteamItem>..ctor
	|-Func<InventoryItem, Option>..ctor
	|-Func<InventoryItem, InventoryDefId>..ctor
	|-Func<InventoryItem, InventoryItemId>..ctor
	|-Func<InventoryItem, InventoryItem>..ctor
	|-Func<InventoryItem, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryItem, InventoryRecipe>..ctor
	|-Func<InventoryItem, bool>..ctor
	|-Func<InventoryItem, KeyValuePair<object, int>>..ctor
	|-Func<InventoryItem, int>..ctor
	|-Func<InventoryItem, Int32Enum>..ctor
	|-Func<InventoryItem, long>..ctor
	|-Func<InventoryItem, object>..ctor
	|-Func<InventoryItem, float>..ctor
	|-Func<InventoryItem, uint>..ctor
	|-Func<InventoryItem, Resolution>..ctor
	|-Func<InventoryItem.Amount, InventoryItemId>..ctor
	|-Func<InventoryItem.Amount, bool>..ctor
	|-Func<InventoryItem.Amount, uint>..ctor
	|-Func<InventoryRecipe, PlayerItemRecipe>..ctor
	|-Func<InventoryRecipe, InventoryRecipe>..ctor
	|-Func<InventoryRecipe, bool>..ctor
	|-Func<InventoryRecipe, object>..ctor
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>..ctor
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>..ctor
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>..ctor
	|-Func<InventoryRecipe.Ingredient, Option>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryItem>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>..ctor
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>..ctor
	|-Func<InventoryRecipe.Ingredient, bool>..ctor
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>..ctor
	|-Func<InventoryRecipe.Ingredient, int>..ctor
	|-Func<InventoryRecipe.Ingredient, Int32Enum>..ctor
	|-Func<InventoryRecipe.Ingredient, long>..ctor
	|-Func<InventoryRecipe.Ingredient, object>..ctor
	|-Func<InventoryRecipe.Ingredient, float>..ctor
	|-Func<InventoryRecipe.Ingredient, string>..ctor
	|-Func<InventoryRecipe.Ingredient, Resolution>..ctor
	|-Func<InventoryRecipe[], bool>..ctor
	|-Func<InventoryRecipe[], IEnumerable<InventoryRecipe>>..ctor
	|-Func<Item, DateTime>..ctor
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>..ctor
	|-Func<ArraySegment<byte>, object>..ctor
	|-Func<bool, bool>..ctor
	|-Func<byte[], bool>..ctor
	|-Func<byte[], IEnumerable<byte>>..ctor
	|-Func<byte[], int>..ctor
	|-Func<char, bool>..ctor
	|-Func<DictionaryEntry, bool>..ctor
	|-Func<DictionaryEntry, KeyValuePair<object, object>>..ctor
	|-Func<DictionaryEntry, object>..ctor
	|-Func<KeyValuePair<IPAddress, int>, int>..ctor
	|-Func<KeyValuePair<object, int>, bool>..ctor
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, int>, int>..ctor
	|-Func<KeyValuePair<object, long>, long>..ctor
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<object, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<object, object>, Option>..ctor
	|-Func<KeyValuePair<object, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<object, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<object, object>, bool>..ctor
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<object, object>, int>..ctor
	|-Func<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<object, object>, long>..ctor
	|-Func<KeyValuePair<object, object>, object>..ctor
	|-Func<KeyValuePair<object, object>, float>..ctor
	|-Func<KeyValuePair<object, object>, Resolution>..ctor
	|-Func<KeyValuePair<string, Stats.Node>, long>..ctor
	|-Func<KeyValuePair<string, AssetBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, Pool.ICollection>, long>..ctor
	|-Func<KeyValuePair<Type, long>, long>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, bool>..ctor
	|-Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, bool>..ctor
	|-Func<KeyValuePair<uint, FileStorage.CacheData>, uint>..ctor
	|-Func<KeyValuePair<uint, Indexer.Entity>, Indexer.Entity>..ctor
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>..ctor
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>..ctor
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>..ctor
	|-Func<KeyValuePair<uint, object>, Option>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryItem>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>..ctor
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>..ctor
	|-Func<KeyValuePair<uint, object>, bool>..ctor
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>..ctor
	|-Func<KeyValuePair<uint, object>, int>..ctor
	|-Func<KeyValuePair<uint, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<uint, object>, long>..ctor
	|-Func<KeyValuePair<uint, object>, object>..ctor
	|-Func<KeyValuePair<uint, object>, float>..ctor
	|-Func<KeyValuePair<uint, object>, uint>..ctor
	|-Func<KeyValuePair<uint, object>, Resolution>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>..ctor
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>..ctor
	|-Func<KeyValuePair<Transform, int>, int>..ctor
	|-Func<StackFrame, Report.StackTrace.StackFrame>..ctor
	|-Func<double, double>..ctor
	|-Func<Exception, bool>..ctor
	|-Func<Guid, int>..ctor
	|-Func<Guid, object>..ctor
	|-Func<IAsyncResult, ISocket>..ctor
	|-Func<IAsyncResult, Stream>..ctor
	|-Func<IAsyncResult, int>..ctor
	|-Func<IAsyncResult, UdpReceiveResult>..ctor
	|-Func<IAsyncResult, WebResponse>..ctor
	|-Func<FileInfo, bool>..ctor
	|-Func<int, FourBitNumber>..ctor
	|-Func<int, SevenBitNumber>..ctor
	|-Func<int, bool>..ctor
	|-Func<int, int>..ctor
	|-Func<int, object>..ctor
	|-Func<int, float>..ctor
	|-Func<int, Material[]>..ctor
	|-Func<Int32Enum, Debugging.EntityInfo>..ctor
	|-Func<Int32Enum, PathFinder.Point>..ctor
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>..ctor
	|-Func<Int32Enum, Option>..ctor
	|-Func<Int32Enum, InventoryItem>..ctor
	|-Func<Int32Enum, InventoryRecipe.Ingredient>..ctor
	|-Func<Int32Enum, InventoryRecipe>..ctor
	|-Func<Int32Enum, bool>..ctor
	|-Func<Int32Enum, KeyValuePair<object, int>>..ctor
	|-Func<Int32Enum, int>..ctor
	|-Func<Int32Enum, Int32Enum>..ctor
	|-Func<Int32Enum, long>..ctor
	|-Func<Int32Enum, object>..ctor
	|-Func<Int32Enum, float>..ctor
	|-Func<Int32Enum, Resolution>..ctor
	|-Func<long, bool>..ctor
	|-Func<long, long>..ctor
	|-Func<IntPtr, object>..ctor
	|-Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId>..ctor
	|-Func<IGrouping<InventoryDefId, InventoryDef>, uint>..ctor
	|-Func<IGrouping<string, IPlayerInfo>, string>..ctor
	|-Func<IGrouping<string, PrefabData>, List<PrefabData>>..ctor
	|-Func<IGrouping<string, PrefabData>, string>..ctor
	|-Func<IGrouping<string, Animator>, int>..ctor
	|-Func<IGrouping<string, Collider>, int>..ctor
	|-Func<IGrouping<string, LODGroup>, int>..ctor
	|-Func<IGrouping<string, Rigidbody>, int>..ctor
	|-Func<IGrouping<string, Transform>, KeyValuePair<Transform, int>>..ctor
	|-Func<IGrouping<string, Transform>, int>..ctor
	|-Func<IGrouping<Type, Object>, int>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, BaseNetworkable>..ctor
	|-Func<IGrouping<uint, BaseNetworkable>, int>..ctor
	|-Func<IGrouping<AssetBundle, string>, LoadAssetsResult>..ctor
	|-Func<IGrouping<Vector2Int, Resolution>, Resolution>..ctor
	|-Func<SimpleAsyncResult, bool>..ctor
	|-Func<object, Debugging.EntityInfo>..ctor
	|-Func<object, FourBitNumber>..ctor
	|-Func<object, SevenBitNumber>..ctor
	|-Func<object, PathFinder.Point>..ctor
	|-Func<object, PlayerItemRecipe.Ingredient>..ctor
	|-Func<object, PlayerItemRecipe>..ctor
	|-Func<object, ProjectileWeaponMod.Modifier>..ctor
	|-Func<object, Option>..ctor
	|-Func<object, InventoryDefId>..ctor
	|-Func<object, InventoryItemId>..ctor
	|-Func<object, InventoryItem>..ctor
	|-Func<object, InventoryRecipe.Ingredient>..ctor
	|-Func<object, InventoryRecipe>..ctor
	|-Func<object, PublishResult>..ctor
	|-Func<object, bool>..ctor
	|-Func<object, KeyValuePair<object, int>>..ctor
	|-Func<object, DateTime>..ctor
	|-Func<object, DateTimeOffset>..ctor
	|-Func<object, Guid>..ctor
	|-Func<object, int>..ctor
	|-Func<object, Int32Enum>..ctor
	|-Func<object, long>..ctor
	|-Func<object, UdpReceiveResult>..ctor
	|-Func<object, Nullable<ServerInfo>>..ctor
	|-Func<object, Nullable<Image>>..ctor
	|-Func<object, Nullable<InventoryPurchaseResult>>..ctor
	|-Func<object, Nullable<InventoryResult>>..ctor
	|-Func<object, Nullable<Item>>..ctor
	|-Func<object, Nullable<ResultPage>>..ctor
	|-Func<object, Nullable<int>>..ctor
	|-Func<object, Nullable<Int32Enum>>..ctor
	|-Func<object, object>..ctor
	|-Func<object, float>..ctor
	|-Func<object, string>..ctor
	|-Func<object, VoidTaskResult>..ctor
	|-Func<object, Type>..ctor
	|-Func<object, uint>..ctor
	|-Func<object, ulong>..ctor
	|-Func<object, Resolution>..ctor
	|-Func<object[], JsonConverter>..ctor
	|-Func<Assembly, IEnumerable<Type>>..ctor
	|-Func<AssemblyName, Assembly>..ctor
	|-Func<ConstructorInfo, bool>..ctor
	|-Func<FieldInfo, bool>..ctor
	|-Func<FieldInfo, int>..ctor
	|-Func<FieldInfo, ParameterOverride>..ctor
	|-Func<MemberInfo, bool>..ctor
	|-Func<MemberInfo, string>..ctor
	|-Func<ParameterInfo, Type>..ctor
	|-Func<PropertyInfo, bool>..ctor
	|-Func<EnumMemberAttribute, string>..ctor
	|-Func<MemberHolder, MemberInfo[]>..ctor
	|-Func<float, bool>..ctor
	|-Func<float, float>..ctor
	|-Func<string, Report.StackTrace.StackFrame>..ctor
	|-Func<string, InventoryRecipe.Ingredient>..ctor
	|-Func<string, InventoryRecipe>..ctor
	|-Func<string, bool>..ctor
	|-Func<string, Guid>..ctor
	|-Func<string, string>..ctor
	|-Func<string, Match>..ctor
	|-Func<string, AssetBundle>..ctor
	|-Func<string, GameObject>..ctor
	|-Func<string, KeyCode>..ctor
	|-Func<Match, bool>..ctor
	|-Func<Match, string>..ctor
	|-Func<Task<Dictionary<string, string>>, Task<Dictionary<string, string>>>..ctor
	|-Func<Type, BidirectionalDictionary<string, string>>..ctor
	|-Func<Type, ReflectionObject>..ctor
	|-Func<Type, bool>..ctor
	|-Func<Type, IEnumerable<MemberInfo>>..ctor
	|-Func<Type, Func<object[], JsonConverter>>..ctor
	|-Func<Type, Tuple<bool, bool, bool, bool>>..ctor
	|-Func<Type, Type>..ctor
	|-Func<uint, bool>..ctor
	|-Func<uint, uint>..ctor
	|-Func<ulong, bool>..ctor
	|-Func<ulong, ulong>..ctor
	|-Func<ValueTuple<ItemDefinition.AmountType, int>, string>..ctor
	|-Func<ValueTuple<Int32Enum, int>, object>..ctor
	|-Func<KerningPair, uint>..ctor
	|-Func<TMP_Character, uint>..ctor
	|-Func<TMP_GlyphPairAdjustmentRecord, uint>..ctor
	|-Func<TechTreeData.NodeInstance, int>..ctor
	|-Func<TechTreeData.NodeInstance, TechTreeData.NodeInstance>..ctor
	|-Func<Animator, string>..ctor
	|-Func<Collider, bool>..ctor
	|-Func<Collider, string>..ctor
	|-Func<GameObject, ItemBlueprint>..ctor
	|-Func<GameObject, ItemDefinition>..ctor
	|-Func<KeyCode, bool>..ctor
	|-Func<KeyCode, string>..ctor
	|-Func<LODGroup, string>..ctor
	|-Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>..ctor
	|-Func<Object, bool>..ctor
	|-Func<Object, Type>..ctor
	|-Func<Renderer, bool>..ctor
	|-Func<Resolution, bool>..ctor
	|-Func<Resolution, int>..ctor
	|-Func<Resolution, Resolution>..ctor
	|-Func<Resolution, Vector2Int>..ctor
	|-Func<Rigidbody, bool>..ctor
	|-Func<Rigidbody, string>..ctor
	|-Func<Glyph, uint>..ctor
	|-Func<Transform, bool>..ctor
	|-Func<Transform, int>..ctor
	|-Func<Transform, object>..ctor
	|-Func<Transform, string>..ctor
	|-Func<Dropdown.OptionData, bool>..ctor
	|-Func<ILayoutElement, float>..ctor
	|-Func<Toggle, SteamInventoryItem>..ctor
	|-Func<Toggle, bool>..ctor
	|-Func<Wearable, bool>..ctor
	|-Func<WeatherPreset, bool>..ctor
	*/

	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16D0AE0 Offset: 0x16CF0E0 VA: 0x1816D0AE0
	|-Func<Entity.EntityInfo, bool>.Invoke
	|-Func<ItemSkinDirectory.Skin, bool>.Invoke
	|-Func<Option, bool>.Invoke
	|-Func<SkinnedMultiMesh.Part, bool>.Invoke
	|-Func<InventoryItem, FourBitNumber>.Invoke
	|-Func<InventoryItem, SevenBitNumber>.Invoke
	|-Func<InventoryItem, bool>.Invoke
	|
	|-RVA: 0x1B16430 Offset: 0x1B14A30 VA: 0x181B16430
	|-Func<ArraySegment<byte>, WebSocketHttpRequest>.Invoke
	|-Func<ImageStorageEntity.ImageRequest, object>.Invoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.Invoke
	|-Func<ConvertUtils.TypeConvertKey, object>.Invoke
	|-Func<PlayerItemRecipe, long>.Invoke
	|-Func<PlayerItemRecipe, object>.Invoke
	|-Func<ArraySegment<byte>, object>.Invoke
	|-Func<DictionaryEntry, object>.Invoke
	|-Func<KeyValuePair<object, long>, long>.Invoke
	|-Func<KeyValuePair<object, object>, long>.Invoke
	|-Func<KeyValuePair<object, object>, object>.Invoke
	|-Func<KeyValuePair<uint, object>, long>.Invoke
	|-Func<KeyValuePair<uint, object>, object>.Invoke
	|-Func<Guid, object>.Invoke
	|
	|-RVA: 0x19EB690 Offset: 0x19E9C90 VA: 0x1819EB690
	|-Func<Exception, bool>.Invoke
	|-Func<SimpleAsyncResult, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<object, bool>.Invoke
	|
	|-RVA: 0x212C3E0 Offset: 0x212A9E0 VA: 0x18212C3E0
	|-Func<int, int>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|
	|-RVA: 0x2130900 Offset: 0x212EF00 VA: 0x182130900
	|-Func<int, float>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|
	|-RVA: 0x19E89C0 Offset: 0x19E6FC0 VA: 0x1819E89C0
	|-Func<object, string>.Invoke
	|-Func<object[], JsonConverter>.Invoke
	|-Func<string, string>.Invoke
	|-Func<string, GameObject>.Invoke
	|-Func<object, object>.Invoke
	|-Func<AssemblyName, Assembly>.Invoke
	|
	|-RVA: 0x18A45A0 Offset: 0x18A2BA0 VA: 0x1818A45A0
	|-Func<ulong, bool>.Invoke
	|-Func<long, bool>.Invoke
	|
	|-RVA: 0x19E9840 Offset: 0x19E7E40 VA: 0x1819E9840
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-RVA: 0x18A40B0 Offset: 0x18A26B0 VA: 0x1818A40B0
	|-Func<NativeInputUpdateType, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|
	|-RVA: 0x1B969D0 Offset: 0x1B94FD0 VA: 0x181B969D0
	|-Func<Admin.PlayerInfo, object>.Invoke
	|
	|-RVA: 0x1B958B0 Offset: 0x1B93EB0 VA: 0x181B958B0
	|-Func<Admin.ServerConvarInfo, object>.Invoke
	|-Func<InventoryRecipe, object>.Invoke
	|-Func<InventoryRecipe.Ingredient, long>.Invoke
	|-Func<InventoryRecipe.Ingredient, object>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.Invoke
	|
	|-RVA: 0x1B8E790 Offset: 0x1B8CD90 VA: 0x181B8E790
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.Invoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.Invoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.Invoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.Invoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.Invoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x16D04A0 Offset: 0x16CEAA0 VA: 0x1816D04A0
	|-Func<Debugging.EntityInfo, bool>.Invoke
	|-Func<RCon.BannedAddresses, bool>.Invoke
	|-Func<WeightedStringList.Container, bool>.Invoke
	|-Func<GameStat.Stat, bool>.Invoke
	|-Func<PlayerItemRecipe, bool>.Invoke
	|-Func<DictionaryEntry, bool>.Invoke
	|-Func<KeyValuePair<object, int>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|-Func<KeyValuePair<uint, object>, bool>.Invoke
	|
	|-RVA: 0x1B93240 Offset: 0x1B91840 VA: 0x181B93240
	|-Func<Demos.DemoInfo, DateTime>.Invoke
	|-Func<Demos.DemoInfo, TimeSpan>.Invoke
	|-Func<InventoryItem, PathFinder.Point>.Invoke
	|-Func<InventoryItem, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B8F650 Offset: 0x1B8DC50 VA: 0x181B8F650
	|-Func<Demos.DemoInfo, object>.Invoke
	|-Func<SkinnedMultiMesh.Part, long>.Invoke
	|-Func<InventoryItem, long>.Invoke
	|-Func<InventoryItem, object>.Invoke
	|
	|-RVA: 0x16D07E0 Offset: 0x16CEDE0 VA: 0x1816D07E0
	|-Func<BurstCloth.Chain, FourBitNumber>.Invoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.Invoke
	|-Func<BurstCloth.Chain, bool>.Invoke
	|-Func<PathFinder.Point, bool>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.Invoke
	|-Func<Achievement, bool>.Invoke
	|-Func<InventoryItemId, bool>.Invoke
	|-Func<Friend, bool>.Invoke
	|
	|-RVA: 0x1B19500 Offset: 0x1B17B00 VA: 0x181B19500
	|-Func<BurstCloth.Chain, int>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, int>.Invoke
	|
	|-RVA: 0x1B94740 Offset: 0x1B92D40 VA: 0x181B94740
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.Invoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B97900 Offset: 0x1B95F00 VA: 0x181B97900
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.Invoke
	|-Func<InventoryItem.Amount, InventoryItemId>.Invoke
	|
	|-RVA: 0x1B94BE0 Offset: 0x1B931E0 VA: 0x181B94BE0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<SkeletonDefinition.Bone, Resolution>.Invoke
	|
	|-RVA: 0x1B8DF00 Offset: 0x1B8C500 VA: 0x181B8DF00
	|-Func<SkeletonDefinition.Bone, Option>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.Invoke
	|
	|-RVA: 0x1B93F80 Offset: 0x1B92580 VA: 0x181B93F80
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.Invoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D1450 Offset: 0x16CFA50 VA: 0x1816D1450
	|-Func<SkeletonDefinition.Bone, bool>.Invoke
	|-Func<InventoryItem.Amount, bool>.Invoke
	|
	|-RVA: 0x1B94410 Offset: 0x1B92A10 VA: 0x181B94410
	|-Func<SkeletonDefinition.Bone, int>.Invoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8EB10 Offset: 0x1B8D110 VA: 0x181B8EB10
	|-Func<SkeletonDefinition.Bone, long>.Invoke
	|-Func<SkeletonDefinition.Bone, object>.Invoke
	|
	|-RVA: 0x1B8E380 Offset: 0x1B8C980 VA: 0x181B8E380
	|-Func<SkeletonDefinition.Bone, float>.Invoke
	|
	|-RVA: 0x1B92800 Offset: 0x1B90E00 VA: 0x181B92800
	|-Func<WeightedStringList.Container, float>.Invoke
	|-Func<PlayerItemRecipe, float>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<uint, object>, float>.Invoke
	|
	|-RVA: 0x18A7BB0 Offset: 0x18A61B0 VA: 0x1818A7BB0
	|-Func<FourBitNumber, FourBitNumber>.Invoke
	|-Func<FourBitNumber, bool>.Invoke
	|-Func<SevenBitNumber, SevenBitNumber>.Invoke
	|-Func<SevenBitNumber, bool>.Invoke
	|
	|-RVA: 0x1B96360 Offset: 0x1B94960 VA: 0x181B96360
	|-Func<SevenBitNumber, object>.Invoke
	|
	|-RVA: 0x1B955B0 Offset: 0x1B93BB0 VA: 0x181B955B0
	|-Func<PathFinder.Point, PathFinder.Point>.Invoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<Achievement, PathFinder.Point>.Invoke
	|-Func<InventoryItemId, InventoryItemId>.Invoke
	|-Func<Friend, PathFinder.Point>.Invoke
	|
	|-RVA: 0x16D2420 Offset: 0x16D0A20 VA: 0x1816D2420
	|-Func<PetCommandList.PetCommandDesc, bool>.Invoke
	|
	|-RVA: 0x1B902D0 Offset: 0x1B8E8D0 VA: 0x181B902D0
	|-Func<PlayerItemRecipe, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.Invoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B916B0 Offset: 0x1B8FCB0 VA: 0x181B916B0
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<PlayerItemRecipe, Resolution>.Invoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<object, object>, Resolution>.Invoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<KeyValuePair<uint, object>, Resolution>.Invoke
	|
	|-RVA: 0x1B91030 Offset: 0x1B8F630 VA: 0x181B91030
	|-Func<PlayerItemRecipe, Option>.Invoke
	|-Func<PlayerItemRecipe, InventoryItem>.Invoke
	|-Func<KeyValuePair<object, object>, Option>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.Invoke
	|-Func<KeyValuePair<uint, object>, Option>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.Invoke
	|
	|-RVA: 0x1B91370 Offset: 0x1B8F970 VA: 0x181B91370
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.Invoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.Invoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B93CC0 Offset: 0x1B922C0 VA: 0x181B93CC0
	|-Func<PlayerItemRecipe, int>.Invoke
	|-Func<PlayerItemRecipe, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<uint, object>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.Invoke
	|
	|-RVA: 0x19E9170 Offset: 0x19E7770 VA: 0x1819E9170
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Resolution, Resolution>.Invoke
	|
	|-RVA: 0x16D2D70 Offset: 0x16D1370 VA: 0x1816D2D70
	|-Func<ProjectileWeaponMod.Modifier, bool>.Invoke
	|-Func<Resolution, bool>.Invoke
	|
	|-RVA: 0x1B95FB0 Offset: 0x1B945B0 VA: 0x181B95FB0
	|-Func<ProjectileWeaponMod.Modifier, float>.Invoke
	|
	|-RVA: 0x1B96E80 Offset: 0x1B95480 VA: 0x181B96E80
	|-Func<Option, Option>.Invoke
	|-Func<InventoryItem, Option>.Invoke
	|-Func<InventoryItem, InventoryItem>.Invoke
	|
	|-RVA: 0x1B92B40 Offset: 0x1B91140 VA: 0x181B92B40
	|-Func<ServerInfo, Debugging.EntityInfo>.Invoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x18A39F0 Offset: 0x18A1FF0 VA: 0x1818A39F0
	|-Func<ServerInfo, FourBitNumber>.Invoke
	|-Func<ServerInfo, SevenBitNumber>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|-Func<ServerInfo, bool>.Invoke
	|
	|-RVA: 0x1B93610 Offset: 0x1B91C10 VA: 0x181B93610
	|-Func<ServerInfo, PathFinder.Point>.Invoke
	|
	|-RVA: 0x1B91A30 Offset: 0x1B90030 VA: 0x181B91A30
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<ServerInfo, Resolution>.Invoke
	|
	|-RVA: 0x1B8EF60 Offset: 0x1B8D560 VA: 0x181B8EF60
	|-Func<ServerInfo, Option>.Invoke
	|-Func<ServerInfo, InventoryItem>.Invoke
	|
	|-RVA: 0x1B90940 Offset: 0x1B8EF40 VA: 0x181B90940
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.Invoke
	|-Func<ServerInfo, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B95080 Offset: 0x1B93680 VA: 0x181B95080
	|-Func<ServerInfo, int>.Invoke
	|-Func<ServerInfo, Int32Enum>.Invoke
	|
	|-RVA: 0x1B8FA10 Offset: 0x1B8E010 VA: 0x181B8FA10
	|-Func<ServerInfo, long>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|-Func<ServerInfo, object>.Invoke
	|
	|-RVA: 0x1B97D40 Offset: 0x1B96340 VA: 0x181B97D40
	|-Func<ServerInfo, float>.Invoke
	|
	|-RVA: 0x1B92140 Offset: 0x1B90740 VA: 0x181B92140
	|-Func<ServerInfo, uint>.Invoke
	|-Func<ServerInfo, int>.Invoke
	|
	|-RVA: 0x1B97290 Offset: 0x1B95890 VA: 0x181B97290
	|-Func<Achievement, Debugging.EntityInfo>.Invoke
	|-Func<Achievement, KeyValuePair<object, int>>.Invoke
	|-Func<Friend, Debugging.EntityInfo>.Invoke
	|-Func<Friend, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x1B96660 Offset: 0x1B94C60 VA: 0x181B96660
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Achievement, Resolution>.Invoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Friend, Resolution>.Invoke
	|
	|-RVA: 0x1B90610 Offset: 0x1B8EC10 VA: 0x181B90610
	|-Func<Achievement, Option>.Invoke
	|-Func<Achievement, InventoryItem>.Invoke
	|-Func<Friend, Option>.Invoke
	|-Func<Friend, InventoryItem>.Invoke
	|
	|-RVA: 0x1B95C80 Offset: 0x1B94280 VA: 0x181B95C80
	|-Func<Achievement, InventoryRecipe.Ingredient>.Invoke
	|-Func<Achievement, InventoryRecipe>.Invoke
	|-Func<Friend, InventoryRecipe.Ingredient>.Invoke
	|-Func<Friend, InventoryRecipe>.Invoke
	|
	|-RVA: 0x1B900D0 Offset: 0x1B8E6D0 VA: 0x181B900D0
	|-Func<Achievement, int>.Invoke
	|-Func<Achievement, Int32Enum>.Invoke
	|-Func<Friend, int>.Invoke
	|-Func<Friend, Int32Enum>.Invoke
	|
	|-RVA: 0x19EA910 Offset: 0x19E8F10 VA: 0x1819EA910
	|-Func<Achievement, long>.Invoke
	|-Func<Achievement, object>.Invoke
	|-Func<Friend, long>.Invoke
	|-Func<Friend, object>.Invoke
	|-Func<ValueTuple<Int32Enum, int>, object>.Invoke
	|
	|-RVA: 0x1B97600 Offset: 0x1B95C00 VA: 0x181B97600
	|-Func<Achievement, float>.Invoke
	|-Func<Friend, float>.Invoke
	|
	|-RVA: 0x212F070 Offset: 0x212D670 VA: 0x18212F070
	|-Func<InventoryDefId, Debugging.EntityInfo>.Invoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212D490 Offset: 0x212BA90 VA: 0x18212D490
	|-Func<InventoryDefId, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212C5E0 Offset: 0x212ABE0 VA: 0x18212C5E0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryDefId, Resolution>.Invoke
	|
	|-RVA: 0x21305D0 Offset: 0x212EBD0 VA: 0x1821305D0
	|-Func<InventoryDefId, Option>.Invoke
	|-Func<InventoryDefId, InventoryItem>.Invoke
	|
	|-RVA: 0x212DE30 Offset: 0x212C430 VA: 0x18212DE30
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryDefId, InventoryRecipe>.Invoke
	|
	|-RVA: 0x18A6480 Offset: 0x18A4A80 VA: 0x1818A6480
	|-Func<InventoryDefId, bool>.Invoke
	|
	|-RVA: 0x2131220 Offset: 0x212F820 VA: 0x182131220
	|-Func<InventoryDefId, int>.Invoke
	|-Func<InventoryDefId, Int32Enum>.Invoke
	|
	|-RVA: 0x212FF20 Offset: 0x212E520 VA: 0x18212FF20
	|-Func<InventoryDefId, long>.Invoke
	|-Func<InventoryDefId, object>.Invoke
	|
	|-RVA: 0x21334A0 Offset: 0x2131AA0 VA: 0x1821334A0
	|-Func<InventoryDefId, float>.Invoke
	|
	|-RVA: 0x212C950 Offset: 0x212AF50 VA: 0x18212C950
	|-Func<ServerInfo, ServerInfo>.Invoke
	|
	|-RVA: 0x2132630 Offset: 0x2130C30 VA: 0x182132630
	|-Func<InventoryItem, Debugging.EntityInfo>.Invoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x212EC60 Offset: 0x212D260 VA: 0x18212EC60
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryItem, Resolution>.Invoke
	|
	|-RVA: 0x2130210 Offset: 0x212E810 VA: 0x182130210
	|-Func<InventoryItem, InventoryDefId>.Invoke
	|-Func<InventoryItem, uint>.Invoke
	|
	|-RVA: 0x212E500 Offset: 0x212CB00 VA: 0x18212E500
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryItem, InventoryRecipe>.Invoke
	|
	|-RVA: 0x212DB00 Offset: 0x212C100 VA: 0x18212DB00
	|-Func<InventoryItem, int>.Invoke
	|-Func<InventoryItem, Int32Enum>.Invoke
	|
	|-RVA: 0x212E160 Offset: 0x212C760 VA: 0x18212E160
	|-Func<InventoryItem, float>.Invoke
	|
	|-RVA: 0x2133050 Offset: 0x2131650 VA: 0x182133050
	|-Func<InventoryItem.Amount, uint>.Invoke
	|
	|-RVA: 0x212BFE0 Offset: 0x212A5E0 VA: 0x18212BFE0
	|-Func<InventoryRecipe, PlayerItemRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.Invoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.Invoke
	|
	|-RVA: 0x212D090 Offset: 0x212B690 VA: 0x18212D090
	|-Func<InventoryRecipe, InventoryRecipe>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.Invoke
	|
	|-RVA: 0x16D2060 Offset: 0x16D0660 VA: 0x1816D2060
	|-Func<InventoryRecipe, bool>.Invoke
	|-Func<InventoryRecipe.Ingredient, bool>.Invoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.Invoke
	|
	|-RVA: 0x2131620 Offset: 0x212FC20 VA: 0x182131620
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.Invoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.Invoke
	|
	|-RVA: 0x212F710 Offset: 0x212DD10 VA: 0x18212F710
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.Invoke
	|
	|-RVA: 0x212FB20 Offset: 0x212E120 VA: 0x18212FB20
	|-Func<InventoryRecipe.Ingredient, Option>.Invoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.Invoke
	|
	|-RVA: 0x212E910 Offset: 0x212CF10 VA: 0x18212E910
	|-Func<InventoryRecipe.Ingredient, int>.Invoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.Invoke
	|
	|-RVA: 0x2130B00 Offset: 0x212F100 VA: 0x182130B00
	|-Func<InventoryRecipe.Ingredient, float>.Invoke
	|
	|-RVA: 0x2131D20 Offset: 0x2130320 VA: 0x182131D20
	|-Func<Item, DateTime>.Invoke
	|
	|-RVA: 0x18A32F0 Offset: 0x18A18F0 VA: 0x1818A32F0
	|-Func<bool, bool>.Invoke
	|
	|-RVA: 0x18A5C30 Offset: 0x18A4230 VA: 0x1818A5C30
	|-Func<char, bool>.Invoke
	|
	|-RVA: 0x1B17BF0 Offset: 0x1B161F0 VA: 0x181B17BF0
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|-Func<KeyValuePair<uint, object>, uint>.Invoke
	|-Func<Guid, int>.Invoke
	|
	|-RVA: 0x2132A40 Offset: 0x2131040 VA: 0x182132A40
	|-Func<double, double>.Invoke
	|
	|-RVA: 0x146D2D0 Offset: 0x146B8D0 VA: 0x18146D2D0
	|-Func<int, FourBitNumber>.Invoke
	|-Func<int, SevenBitNumber>.Invoke
	|-Func<uint, bool>.Invoke
	|
	|-RVA: 0x2131420 Offset: 0x212FA20 VA: 0x182131420
	|-Func<int, object>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|
	|-RVA: 0x2130EB0 Offset: 0x212F4B0 VA: 0x182130EB0
	|-Func<Int32Enum, Debugging.EntityInfo>.Invoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.Invoke
	|
	|-RVA: 0x2132D50 Offset: 0x2131350 VA: 0x182132D50
	|-Func<Int32Enum, PathFinder.Point>.Invoke
	|
	|-RVA: 0x212D790 Offset: 0x212BD90 VA: 0x18212D790
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<Int32Enum, Resolution>.Invoke
	|
	|-RVA: 0x21319F0 Offset: 0x212FFF0 VA: 0x1821319F0
	|-Func<Int32Enum, Option>.Invoke
	|-Func<Int32Enum, InventoryItem>.Invoke
	|
	|-RVA: 0x212F3E0 Offset: 0x212D9E0 VA: 0x18212F3E0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.Invoke
	|-Func<Int32Enum, InventoryRecipe>.Invoke
	|
	|-RVA: 0x20C8260 Offset: 0x20C6860 VA: 0x1820C8260
	|-Func<Int32Enum, long>.Invoke
	|
	|-RVA: 0x19E8230 Offset: 0x19E6830 VA: 0x1819E8230
	|-Func<long, long>.Invoke
	|-Func<IntPtr, object>.Invoke
	|-Func<ulong, ulong>.Invoke
	|
	|-RVA: 0x19E6DF0 Offset: 0x19E53F0 VA: 0x1819E6DF0
	|-Func<object, Debugging.EntityInfo>.Invoke
	|-Func<object, PlayerItemRecipe>.Invoke
	|-Func<object, KeyValuePair<object, int>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|
	|-RVA: 0x1783F60 Offset: 0x1782560 VA: 0x181783F60
	|-Func<object, FourBitNumber>.Invoke
	|-Func<object, SevenBitNumber>.Invoke
	|
	|-RVA: 0x19E8CF0 Offset: 0x19E72F0 VA: 0x1819E8CF0
	|-Func<object, PathFinder.Point>.Invoke
	|-Func<object, PlayerItemRecipe.Ingredient>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, Nullable<Int32Enum>>.Invoke
	|
	|-RVA: 0x19E7330 Offset: 0x19E5930 VA: 0x1819E7330
	|-Func<object, ProjectileWeaponMod.Modifier>.Invoke
	|-Func<object, Nullable<InventoryResult>>.Invoke
	|-Func<object, Resolution>.Invoke
	|
	|-RVA: 0x19E6960 Offset: 0x19E4F60 VA: 0x1819E6960
	|-Func<object, Option>.Invoke
	|-Func<object, InventoryItem>.Invoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.Invoke
	|-Func<object, Nullable<ResultPage>>.Invoke
	|
	|-RVA: 0x19E7870 Offset: 0x19E5E70 VA: 0x1819E7870
	|-Func<object, InventoryDefId>.Invoke
	|-Func<object, uint>.Invoke
	|
	|-RVA: 0x148B7D0 Offset: 0x1489DD0 VA: 0x18148B7D0
	|-Func<object, InventoryItemId>.Invoke
	|
	|-RVA: 0x19E8530 Offset: 0x19E6B30 VA: 0x1819E8530
	|-Func<object, InventoryRecipe.Ingredient>.Invoke
	|-Func<object, InventoryRecipe>.Invoke
	|-Func<object, PublishResult>.Invoke
	|-Func<object, Nullable<Image>>.Invoke
	|
	|-RVA: 0x19E7C80 Offset: 0x19E6280 VA: 0x1819E7C80
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|
	|-RVA: 0x1476EF0 Offset: 0x14754F0 VA: 0x181476EF0
	|-Func<object, long>.Invoke
	|
	|-RVA: 0x19E9CD0 Offset: 0x19E82D0 VA: 0x1819E9CD0
	|-Func<object, Nullable<ServerInfo>>.Invoke
	|
	|-RVA: 0x19EAC10 Offset: 0x19E9210 VA: 0x1819EAC10
	|-Func<object, Nullable<Item>>.Invoke
	|
	|-RVA: 0x19EBA90 Offset: 0x19EA090 VA: 0x1819EBA90
	|-Func<object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x133AAA0 Offset: 0x13390A0 VA: 0x18133AAA0
	|-Func<object, ulong>.Invoke
	|
	|-RVA: 0x18A42B0 Offset: 0x18A28B0 VA: 0x1818A42B0
	|-Func<float, bool>.Invoke
	|
	|-RVA: 0x19E9550 Offset: 0x19E7B50 VA: 0x1819E9550
	|-Func<float, float>.Invoke
	|
	|-RVA: 0x19E7F40 Offset: 0x19E6540 VA: 0x1819E7F40
	|-Func<uint, uint>.Invoke
	|
	|-RVA: 0x19EA570 Offset: 0x19E8B70 VA: 0x1819EA570
	|-Func<Resolution, int>.Invoke
	|
	|-RVA: 0x19EA1D0 Offset: 0x19E87D0 VA: 0x1819EA1D0
	|-Func<Resolution, Vector2Int>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B8D480 Offset: 0x1B8BA80 VA: 0x181B8D480
	|-Func<Admin.PlayerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8BB00 Offset: 0x1B8A100 VA: 0x181B8BB00
	|-Func<Admin.ServerConvarInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8C200 Offset: 0x1B8A800 VA: 0x181B8C200
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8DA80 Offset: 0x1B8C080 VA: 0x181B8DA80
	|-Func<Debugging.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8CB80 Offset: 0x1B8B180 VA: 0x181B8CB80
	|-Func<Entity.EntityInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8CA80 Offset: 0x1B8B080 VA: 0x181B8CA80
	|-Func<Demos.DemoInfo, DateTime>.BeginInvoke
	|
	|-RVA: 0x1B8C600 Offset: 0x1B8AC00 VA: 0x181B8C600
	|-Func<Demos.DemoInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8CB00 Offset: 0x1B8B100 VA: 0x181B8CB00
	|-Func<Demos.DemoInfo, TimeSpan>.BeginInvoke
	|
	|-RVA: 0x1B8C880 Offset: 0x1B8AE80 VA: 0x181B8C880
	|-Func<BurstCloth.Chain, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8DE80 Offset: 0x1B8C480 VA: 0x181B8DE80
	|-Func<BurstCloth.Chain, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B880 Offset: 0x1B89E80 VA: 0x181B8B880
	|-Func<BurstCloth.Chain, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B680 Offset: 0x1B89C80 VA: 0x181B8B680
	|-Func<BurstCloth.Chain, int>.BeginInvoke
	|
	|-RVA: 0x1B8BC00 Offset: 0x1B8A200 VA: 0x181B8BC00
	|-Func<RCon.BannedAddresses, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C180 Offset: 0x1B8A780 VA: 0x181B8C180
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8C480 Offset: 0x1B8AA80 VA: 0x181B8C480
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B600 Offset: 0x1B89C00 VA: 0x181B8B600
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8D200 Offset: 0x1B8B800 VA: 0x181B8D200
	|-Func<SkeletonDefinition.Bone, Option>.BeginInvoke
	|
	|-RVA: 0x1B8D080 Offset: 0x1B8B680 VA: 0x181B8D080
	|-Func<SkeletonDefinition.Bone, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8D400 Offset: 0x1B8BA00 VA: 0x181B8D400
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8B480 Offset: 0x1B89A80 VA: 0x181B8B480
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8D300 Offset: 0x1B8B900 VA: 0x181B8D300
	|-Func<SkeletonDefinition.Bone, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C980 Offset: 0x1B8AF80 VA: 0x181B8C980
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8C280 Offset: 0x1B8A880 VA: 0x181B8C280
	|-Func<SkeletonDefinition.Bone, int>.BeginInvoke
	|
	|-RVA: 0x1B8D000 Offset: 0x1B8B600 VA: 0x181B8D000
	|-Func<SkeletonDefinition.Bone, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8D900 Offset: 0x1B8BF00 VA: 0x181B8D900
	|-Func<SkeletonDefinition.Bone, long>.BeginInvoke
	|
	|-RVA: 0x1B8C680 Offset: 0x1B8AC80 VA: 0x181B8C680
	|-Func<SkeletonDefinition.Bone, object>.BeginInvoke
	|
	|-RVA: 0x1B8D700 Offset: 0x1B8BD00 VA: 0x181B8D700
	|-Func<SkeletonDefinition.Bone, float>.BeginInvoke
	|
	|-RVA: 0x1B8C780 Offset: 0x1B8AD80 VA: 0x181B8C780
	|-Func<SkeletonDefinition.Bone, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8B200 Offset: 0x1B89800 VA: 0x181B8B200
	|-Func<WeightedStringList.Container, bool>.BeginInvoke
	|
	|-RVA: 0x1B8DD00 Offset: 0x1B8C300 VA: 0x181B8DD00
	|-Func<WeightedStringList.Container, float>.BeginInvoke
	|
	|-RVA: 0x1B8AC00 Offset: 0x1B89200 VA: 0x181B8AC00
	|-Func<GameStat.Stat, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AB80 Offset: 0x1B89180 VA: 0x181B8AB80
	|-Func<ImageStorageEntity.ImageRequest, object>.BeginInvoke
	|
	|-RVA: 0x1B8DB00 Offset: 0x1B8C100 VA: 0x181B8DB00
	|-Func<ItemSkinDirectory.Skin, bool>.BeginInvoke
	|
	|-RVA: 0x1B8BB80 Offset: 0x1B8A180 VA: 0x181B8BB80
	|-Func<FourBitNumber, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B980 Offset: 0x1B89F80 VA: 0x181B8B980
	|-Func<FourBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D100 Offset: 0x1B8B700 VA: 0x181B8D100
	|-Func<SevenBitNumber, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8CE80 Offset: 0x1B8B480 VA: 0x181B8CE80
	|-Func<SevenBitNumber, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B180 Offset: 0x1B89780 VA: 0x181B8B180
	|-Func<SevenBitNumber, object>.BeginInvoke
	|
	|-RVA: 0x1B8D780 Offset: 0x1B8BD80 VA: 0x181B8D780
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8B380 Offset: 0x1B89980 VA: 0x181B8B380
	|-Func<ConvertUtils.TypeConvertKey, object>.BeginInvoke
	|
	|-RVA: 0x1B8D880 Offset: 0x1B8BE80 VA: 0x181B8D880
	|-Func<PathFinder.Point, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8BD00 Offset: 0x1B8A300 VA: 0x181B8BD00
	|-Func<PathFinder.Point, bool>.BeginInvoke
	|
	|-RVA: 0x1B8BF80 Offset: 0x1B8A580 VA: 0x181B8BF80
	|-Func<PetCommandList.PetCommandDesc, bool>.BeginInvoke
	|
	|-RVA: 0x1B8AE00 Offset: 0x1B89400 VA: 0x181B8AE00
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8B100 Offset: 0x1B89700 VA: 0x181B8B100
	|-Func<PlayerItemRecipe, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8BC80 Offset: 0x1B8A280 VA: 0x181B8BC80
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8B000 Offset: 0x1B89600 VA: 0x181B8B000
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8C380 Offset: 0x1B8A980 VA: 0x181B8C380
	|-Func<PlayerItemRecipe, Option>.BeginInvoke
	|
	|-RVA: 0x1B8D580 Offset: 0x1B8BB80 VA: 0x181B8D580
	|-Func<PlayerItemRecipe, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8B580 Offset: 0x1B89B80 VA: 0x181B8B580
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8B300 Offset: 0x1B89900 VA: 0x181B8B300
	|-Func<PlayerItemRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8C080 Offset: 0x1B8A680 VA: 0x181B8C080
	|-Func<PlayerItemRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x1B8B400 Offset: 0x1B89A00 VA: 0x181B8B400
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8CD00 Offset: 0x1B8B300 VA: 0x181B8CD00
	|-Func<PlayerItemRecipe, int>.BeginInvoke
	|
	|-RVA: 0x1B8B080 Offset: 0x1B89680 VA: 0x181B8B080
	|-Func<PlayerItemRecipe, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8CA00 Offset: 0x1B8B000 VA: 0x181B8CA00
	|-Func<PlayerItemRecipe, long>.BeginInvoke
	|
	|-RVA: 0x1B8BE00 Offset: 0x1B8A400 VA: 0x181B8BE00
	|-Func<PlayerItemRecipe, object>.BeginInvoke
	|
	|-RVA: 0x1B8CD80 Offset: 0x1B8B380 VA: 0x181B8CD80
	|-Func<PlayerItemRecipe, float>.BeginInvoke
	|
	|-RVA: 0x1B8AD80 Offset: 0x1B89380 VA: 0x181B8AD80
	|-Func<PlayerItemRecipe, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8C580 Offset: 0x1B8AB80 VA: 0x181B8C580
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8C300 Offset: 0x1B8A900 VA: 0x181B8C300
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B500 Offset: 0x1B89B00 VA: 0x181B8B500
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8D680 Offset: 0x1B8BC80 VA: 0x181B8D680
	|-Func<PlayerItemRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x1B8BA80 Offset: 0x1B8A080 VA: 0x181B8BA80
	|-Func<PlayerItemRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x1B8C700 Offset: 0x1B8AD00 VA: 0x181B8C700
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8AE80 Offset: 0x1B89480 VA: 0x181B8AE80
	|-Func<ProjectileWeaponMod.Modifier, bool>.BeginInvoke
	|
	|-RVA: 0x1B8D980 Offset: 0x1B8BF80 VA: 0x181B8D980
	|-Func<ProjectileWeaponMod.Modifier, float>.BeginInvoke
	|
	|-RVA: 0x1B8DA00 Offset: 0x1B8C000 VA: 0x181B8DA00
	|-Func<Option, Option>.BeginInvoke
	|
	|-RVA: 0x1B8DE00 Offset: 0x1B8C400 VA: 0x181B8DE00
	|-Func<Option, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C000 Offset: 0x1B8A600 VA: 0x181B8C000
	|-Func<ServerInfo, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8B780 Offset: 0x1B89D80 VA: 0x181B8B780
	|-Func<ServerInfo, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8C400 Offset: 0x1B8AA00 VA: 0x181B8C400
	|-Func<ServerInfo, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x1B8B900 Offset: 0x1B89F00 VA: 0x181B8B900
	|-Func<ServerInfo, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8B700 Offset: 0x1B89D00 VA: 0x181B8B700
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8AD00 Offset: 0x1B89300 VA: 0x181B8AD00
	|-Func<ServerInfo, Option>.BeginInvoke
	|
	|-RVA: 0x1B8CF00 Offset: 0x1B8B500 VA: 0x181B8CF00
	|-Func<ServerInfo, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8BD80 Offset: 0x1B8A380 VA: 0x181B8BD80
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8AC80 Offset: 0x1B89280 VA: 0x181B8AC80
	|-Func<ServerInfo, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8D800 Offset: 0x1B8BE00 VA: 0x181B8D800
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x1B8C900 Offset: 0x1B8AF00 VA: 0x181B8C900
	|-Func<ServerInfo, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8D600 Offset: 0x1B8BC00 VA: 0x181B8D600
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x1B8CF80 Offset: 0x1B8B580 VA: 0x181B8CF80
	|-Func<ServerInfo, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8C800 Offset: 0x1B8AE00 VA: 0x181B8C800
	|-Func<ServerInfo, long>.BeginInvoke
	|
	|-RVA: 0x1B8D180 Offset: 0x1B8B780 VA: 0x181B8D180
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x1B8B800 Offset: 0x1B89E00 VA: 0x181B8B800
	|-Func<ServerInfo, float>.BeginInvoke
	|
	|-RVA: 0x1B8C500 Offset: 0x1B8AB00 VA: 0x181B8C500
	|-Func<ServerInfo, uint>.BeginInvoke
	|
	|-RVA: 0x1B8AF80 Offset: 0x1B89580 VA: 0x181B8AF80
	|-Func<ServerInfo, Resolution>.BeginInvoke
	|
	|-RVA: 0x1B8D280 Offset: 0x1B8B880 VA: 0x181B8D280
	|-Func<SkinnedMultiMesh.Part, bool>.BeginInvoke
	|
	|-RVA: 0x1B8CC80 Offset: 0x1B8B280 VA: 0x181B8CC80
	|-Func<SkinnedMultiMesh.Part, long>.BeginInvoke
	|
	|-RVA: 0x1B8DD80 Offset: 0x1B8C380 VA: 0x181B8DD80
	|-Func<Achievement, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x1B8D500 Offset: 0x1B8BB00 VA: 0x181B8D500
	|-Func<Achievement, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x1B8BE80 Offset: 0x1B8A480 VA: 0x181B8BE80
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x1B8B280 Offset: 0x1B89880 VA: 0x181B8B280
	|-Func<Achievement, Option>.BeginInvoke
	|
	|-RVA: 0x1B8CE00 Offset: 0x1B8B400 VA: 0x181B8CE00
	|-Func<Achievement, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x1B8BF00 Offset: 0x1B8A500 VA: 0x181B8BF00
	|-Func<Achievement, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x1B8DB80 Offset: 0x1B8C180 VA: 0x181B8DB80
	|-Func<Achievement, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x1B8AF00 Offset: 0x1B89500 VA: 0x181B8AF00
	|-Func<Achievement, bool>.BeginInvoke
	|
	|-RVA: 0x1B8DC00 Offset: 0x1B8C200 VA: 0x181B8DC00
	|-Func<Achievement, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x1B8C100 Offset: 0x1B8A700 VA: 0x181B8C100
	|-Func<Achievement, int>.BeginInvoke
	|
	|-RVA: 0x1B8CC00 Offset: 0x1B8B200 VA: 0x181B8CC00
	|-Func<Achievement, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1B8D380 Offset: 0x1B8B980 VA: 0x181B8D380
	|-Func<Achievement, long>.BeginInvoke
	|
	|-RVA: 0x1B8AB00 Offset: 0x1B89100 VA: 0x181B8AB00
	|-Func<Achievement, object>.BeginInvoke
	|
	|-RVA: 0x1B8BA00 Offset: 0x1B8A000 VA: 0x181B8BA00
	|-Func<Achievement, float>.BeginInvoke
	|
	|-RVA: 0x1B8DC80 Offset: 0x1B8C280 VA: 0x181B8DC80
	|-Func<Achievement, Resolution>.BeginInvoke
	|
	|-RVA: 0x21280C0 Offset: 0x21266C0 VA: 0x1821280C0
	|-Func<InventoryDefId, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2129C40 Offset: 0x2128240 VA: 0x182129C40
	|-Func<InventoryDefId, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21275C0 Offset: 0x2125BC0 VA: 0x1821275C0
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x21297C0 Offset: 0x2127DC0 VA: 0x1821297C0
	|-Func<InventoryDefId, Option>.BeginInvoke
	|
	|-RVA: 0x2129440 Offset: 0x2127A40 VA: 0x182129440
	|-Func<InventoryDefId, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212B740 Offset: 0x2129D40 VA: 0x18212B740
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127540 Offset: 0x2125B40 VA: 0x182127540
	|-Func<InventoryDefId, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212A5C0 Offset: 0x2128BC0 VA: 0x18212A5C0
	|-Func<InventoryDefId, bool>.BeginInvoke
	|
	|-RVA: 0x212AE40 Offset: 0x2129440 VA: 0x18212AE40
	|-Func<InventoryDefId, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21273C0 Offset: 0x21259C0 VA: 0x1821273C0
	|-Func<InventoryDefId, int>.BeginInvoke
	|
	|-RVA: 0x212AA40 Offset: 0x2129040 VA: 0x18212AA40
	|-Func<InventoryDefId, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2128D40 Offset: 0x2127340 VA: 0x182128D40
	|-Func<InventoryDefId, long>.BeginInvoke
	|
	|-RVA: 0x212B640 Offset: 0x2129C40 VA: 0x18212B640
	|-Func<InventoryDefId, object>.BeginInvoke
	|
	|-RVA: 0x2127DC0 Offset: 0x21263C0 VA: 0x182127DC0
	|-Func<InventoryDefId, float>.BeginInvoke
	|
	|-RVA: 0x2129540 Offset: 0x2127B40 VA: 0x182129540
	|-Func<InventoryDefId, Resolution>.BeginInvoke
	|
	|-RVA: 0x2128B40 Offset: 0x2127140 VA: 0x182128B40
	|-Func<InventoryItemId, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2128040 Offset: 0x2126640 VA: 0x182128040
	|-Func<InventoryItemId, bool>.BeginInvoke
	|
	|-RVA: 0x212A9C0 Offset: 0x2128FC0 VA: 0x18212A9C0
	|-Func<ServerInfo, ServerInfo>.BeginInvoke
	|
	|-RVA: 0x212BCC0 Offset: 0x212A2C0 VA: 0x18212BCC0
	|-Func<ServerInfo, bool>.BeginInvoke
	|
	|-RVA: 0x21292C0 Offset: 0x21278C0 VA: 0x1821292C0
	|-Func<ServerInfo, int>.BeginInvoke
	|
	|-RVA: 0x2127A40 Offset: 0x2126040 VA: 0x182127A40
	|-Func<ServerInfo, object>.BeginInvoke
	|
	|-RVA: 0x212BE40 Offset: 0x212A440 VA: 0x18212BE40
	|-Func<Friend, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21299C0 Offset: 0x2127FC0 VA: 0x1821299C0
	|-Func<Friend, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x21289C0 Offset: 0x2126FC0 VA: 0x1821289C0
	|-Func<Friend, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212B440 Offset: 0x2129A40 VA: 0x18212B440
	|-Func<Friend, Option>.BeginInvoke
	|
	|-RVA: 0x212AFC0 Offset: 0x21295C0 VA: 0x18212AFC0
	|-Func<Friend, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x21279C0 Offset: 0x2125FC0 VA: 0x1821279C0
	|-Func<Friend, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x21281C0 Offset: 0x21267C0 VA: 0x1821281C0
	|-Func<Friend, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212B5C0 Offset: 0x2129BC0 VA: 0x18212B5C0
	|-Func<Friend, bool>.BeginInvoke
	|
	|-RVA: 0x212AEC0 Offset: 0x21294C0 VA: 0x18212AEC0
	|-Func<Friend, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x212A240 Offset: 0x2128840 VA: 0x18212A240
	|-Func<Friend, int>.BeginInvoke
	|
	|-RVA: 0x212AB40 Offset: 0x2129140 VA: 0x18212AB40
	|-Func<Friend, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212B4C0 Offset: 0x2129AC0 VA: 0x18212B4C0
	|-Func<Friend, long>.BeginInvoke
	|
	|-RVA: 0x2129DC0 Offset: 0x21283C0 VA: 0x182129DC0
	|-Func<Friend, object>.BeginInvoke
	|
	|-RVA: 0x2129B40 Offset: 0x2128140 VA: 0x182129B40
	|-Func<Friend, float>.BeginInvoke
	|
	|-RVA: 0x21298C0 Offset: 0x2127EC0 VA: 0x1821298C0
	|-Func<Friend, Resolution>.BeginInvoke
	|
	|-RVA: 0x21284C0 Offset: 0x2126AC0 VA: 0x1821284C0
	|-Func<InventoryItem, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x212B9C0 Offset: 0x2129FC0 VA: 0x18212B9C0
	|-Func<InventoryItem, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x212B6C0 Offset: 0x2129CC0 VA: 0x18212B6C0
	|-Func<InventoryItem, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x2128CC0 Offset: 0x21272C0 VA: 0x182128CC0
	|-Func<InventoryItem, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212A940 Offset: 0x2128F40 VA: 0x18212A940
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2129A40 Offset: 0x2128040 VA: 0x182129A40
	|-Func<InventoryItem, Option>.BeginInvoke
	|
	|-RVA: 0x212A4C0 Offset: 0x2128AC0 VA: 0x18212A4C0
	|-Func<InventoryItem, InventoryDefId>.BeginInvoke
	|
	|-RVA: 0x2127940 Offset: 0x2125F40 VA: 0x182127940
	|-Func<InventoryItem, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x212B940 Offset: 0x2129F40 VA: 0x18212B940
	|-Func<InventoryItem, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212ACC0 Offset: 0x21292C0 VA: 0x18212ACC0
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2128140 Offset: 0x2126740 VA: 0x182128140
	|-Func<InventoryItem, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129040 Offset: 0x2127640 VA: 0x182129040
	|-Func<InventoryItem, bool>.BeginInvoke
	|
	|-RVA: 0x2128A40 Offset: 0x2127040 VA: 0x182128A40
	|-Func<InventoryItem, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2129BC0 Offset: 0x21281C0 VA: 0x182129BC0
	|-Func<InventoryItem, int>.BeginInvoke
	|
	|-RVA: 0x212AAC0 Offset: 0x21290C0 VA: 0x18212AAC0
	|-Func<InventoryItem, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x21286C0 Offset: 0x2126CC0 VA: 0x1821286C0
	|-Func<InventoryItem, long>.BeginInvoke
	|
	|-RVA: 0x2129840 Offset: 0x2127E40 VA: 0x182129840
	|-Func<InventoryItem, object>.BeginInvoke
	|
	|-RVA: 0x2127E40 Offset: 0x2126440 VA: 0x182127E40
	|-Func<InventoryItem, float>.BeginInvoke
	|
	|-RVA: 0x212B1C0 Offset: 0x21297C0 VA: 0x18212B1C0
	|-Func<InventoryItem, uint>.BeginInvoke
	|
	|-RVA: 0x212A0C0 Offset: 0x21286C0 VA: 0x18212A0C0
	|-Func<InventoryItem, Resolution>.BeginInvoke
	|
	|-RVA: 0x212A840 Offset: 0x2128E40 VA: 0x18212A840
	|-Func<InventoryItem.Amount, InventoryItemId>.BeginInvoke
	|
	|-RVA: 0x2128EC0 Offset: 0x21274C0 VA: 0x182128EC0
	|-Func<InventoryItem.Amount, bool>.BeginInvoke
	|
	|-RVA: 0x212B3C0 Offset: 0x21299C0 VA: 0x18212B3C0
	|-Func<InventoryItem.Amount, uint>.BeginInvoke
	|
	|-RVA: 0x2128C40 Offset: 0x2127240 VA: 0x182128C40
	|-Func<InventoryRecipe, PlayerItemRecipe>.BeginInvoke
	|
	|-RVA: 0x21277C0 Offset: 0x2125DC0 VA: 0x1821277C0
	|-Func<InventoryRecipe, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x21285C0 Offset: 0x2126BC0 VA: 0x1821285C0
	|-Func<InventoryRecipe, bool>.BeginInvoke
	|
	|-RVA: 0x2128640 Offset: 0x2126C40 VA: 0x182128640
	|-Func<InventoryRecipe, object>.BeginInvoke
	|
	|-RVA: 0x2128F40 Offset: 0x2127540 VA: 0x182128F40
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21282C0 Offset: 0x21268C0 VA: 0x1821282C0
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2129640 Offset: 0x2127C40 VA: 0x182129640
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2128840 Offset: 0x2126E40 VA: 0x182128840
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2127840 Offset: 0x2125E40 VA: 0x182127840
	|-Func<InventoryRecipe.Ingredient, Option>.BeginInvoke
	|
	|-RVA: 0x2129E40 Offset: 0x2128440 VA: 0x182129E40
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212B0C0 Offset: 0x21296C0 VA: 0x18212B0C0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2127AC0 Offset: 0x21260C0 VA: 0x182127AC0
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2127D40 Offset: 0x2126340 VA: 0x182127D40
	|-Func<InventoryRecipe.Ingredient, bool>.BeginInvoke
	|
	|-RVA: 0x2129940 Offset: 0x2127F40 VA: 0x182129940
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21278C0 Offset: 0x2125EC0 VA: 0x1821278C0
	|-Func<InventoryRecipe.Ingredient, int>.BeginInvoke
	|
	|-RVA: 0x2129CC0 Offset: 0x21282C0 VA: 0x182129CC0
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212A440 Offset: 0x2128A40 VA: 0x18212A440
	|-Func<InventoryRecipe.Ingredient, long>.BeginInvoke
	|
	|-RVA: 0x212A640 Offset: 0x2128C40 VA: 0x18212A640
	|-Func<InventoryRecipe.Ingredient, object>.BeginInvoke
	|
	|-RVA: 0x2129F40 Offset: 0x2128540 VA: 0x182129F40
	|-Func<InventoryRecipe.Ingredient, float>.BeginInvoke
	|
	|-RVA: 0x21276C0 Offset: 0x2125CC0 VA: 0x1821276C0
	|-Func<InventoryRecipe.Ingredient, Resolution>.BeginInvoke
	|
	|-RVA: 0x2128740 Offset: 0x2126D40 VA: 0x182128740
	|-Func<Item, DateTime>.BeginInvoke
	|
	|-RVA: 0x212B7C0 Offset: 0x2129DC0 VA: 0x18212B7C0
	|-Func<ArraySegment<byte>, object>.BeginInvoke
	|
	|-RVA: 0x212A040 Offset: 0x2128640 VA: 0x18212A040
	|-Func<bool, bool>.BeginInvoke
	|
	|-RVA: 0x212A1C0 Offset: 0x21287C0 VA: 0x18212A1C0
	|-Func<char, bool>.BeginInvoke
	|
	|-RVA: 0x21290C0 Offset: 0x21276C0 VA: 0x1821290C0
	|-Func<DictionaryEntry, bool>.BeginInvoke
	|
	|-RVA: 0x212ABC0 Offset: 0x21291C0 VA: 0x18212ABC0
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x212A140 Offset: 0x2128740 VA: 0x18212A140
	|-Func<DictionaryEntry, object>.BeginInvoke
	|
	|-RVA: 0x212BC40 Offset: 0x212A240 VA: 0x18212BC40
	|-Func<KeyValuePair<object, int>, bool>.BeginInvoke
	|
	|-RVA: 0x212A7C0 Offset: 0x2128DC0 VA: 0x18212A7C0
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x21293C0 Offset: 0x21279C0 VA: 0x1821293C0
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-RVA: 0x21295C0 Offset: 0x2127BC0 VA: 0x1821295C0
	|-Func<KeyValuePair<object, long>, long>.BeginInvoke
	|
	|-RVA: 0x2127640 Offset: 0x2125C40 VA: 0x182127640
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21294C0 Offset: 0x2127AC0 VA: 0x1821294C0
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x2128BC0 Offset: 0x21271C0 VA: 0x182128BC0
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x2127EC0 Offset: 0x21264C0 VA: 0x182127EC0
	|-Func<KeyValuePair<object, object>, Option>.BeginInvoke
	|
	|-RVA: 0x212B2C0 Offset: 0x21298C0 VA: 0x18212B2C0
	|-Func<KeyValuePair<object, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2129FC0 Offset: 0x21285C0 VA: 0x182129FC0
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x212B140 Offset: 0x2129740 VA: 0x18212B140
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212A6C0 Offset: 0x2128CC0 VA: 0x18212A6C0
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-RVA: 0x2128E40 Offset: 0x2127440 VA: 0x182128E40
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x2127BC0 Offset: 0x21261C0 VA: 0x182127BC0
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-RVA: 0x212BA40 Offset: 0x212A040 VA: 0x18212BA40
	|-Func<KeyValuePair<object, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2129140 Offset: 0x2127740 VA: 0x182129140
	|-Func<KeyValuePair<object, object>, long>.BeginInvoke
	|
	|-RVA: 0x2127440 Offset: 0x2125A40 VA: 0x182127440
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-RVA: 0x212BB40 Offset: 0x212A140 VA: 0x18212BB40
	|-Func<KeyValuePair<object, object>, float>.BeginInvoke
	|
	|-RVA: 0x2127B40 Offset: 0x2126140 VA: 0x182127B40
	|-Func<KeyValuePair<object, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x212B040 Offset: 0x2129640 VA: 0x18212B040
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x21287C0 Offset: 0x2126DC0 VA: 0x1821287C0
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212BAC0 Offset: 0x212A0C0 VA: 0x18212BAC0
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212AC40 Offset: 0x2129240 VA: 0x18212AC40
	|-Func<KeyValuePair<uint, object>, Option>.BeginInvoke
	|
	|-RVA: 0x2129340 Offset: 0x2127940 VA: 0x182129340
	|-Func<KeyValuePair<uint, object>, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x212BEC0 Offset: 0x212A4C0 VA: 0x18212BEC0
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2129D40 Offset: 0x2128340 VA: 0x182129D40
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x212BBC0 Offset: 0x212A1C0 VA: 0x18212BBC0
	|-Func<KeyValuePair<uint, object>, bool>.BeginInvoke
	|
	|-RVA: 0x212B8C0 Offset: 0x2129EC0 VA: 0x18212B8C0
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x212AF40 Offset: 0x2129540 VA: 0x18212AF40
	|-Func<KeyValuePair<uint, object>, int>.BeginInvoke
	|
	|-RVA: 0x2127C40 Offset: 0x2126240 VA: 0x182127C40
	|-Func<KeyValuePair<uint, object>, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212A2C0 Offset: 0x21288C0 VA: 0x18212A2C0
	|-Func<KeyValuePair<uint, object>, long>.BeginInvoke
	|
	|-RVA: 0x212A340 Offset: 0x2128940 VA: 0x18212A340
	|-Func<KeyValuePair<uint, object>, object>.BeginInvoke
	|
	|-RVA: 0x2128340 Offset: 0x2126940 VA: 0x182128340
	|-Func<KeyValuePair<uint, object>, float>.BeginInvoke
	|
	|-RVA: 0x2128AC0 Offset: 0x21270C0 VA: 0x182128AC0
	|-Func<KeyValuePair<uint, object>, uint>.BeginInvoke
	|
	|-RVA: 0x212B540 Offset: 0x2129B40 VA: 0x18212B540
	|-Func<KeyValuePair<uint, object>, Resolution>.BeginInvoke
	|
	|-RVA: 0x21274C0 Offset: 0x2125AC0 VA: 0x1821274C0
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.BeginInvoke
	|
	|-RVA: 0x212B240 Offset: 0x2129840 VA: 0x18212B240
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.BeginInvoke
	|
	|-RVA: 0x2127740 Offset: 0x2125D40 VA: 0x182127740
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.BeginInvoke
	|
	|-RVA: 0x2129740 Offset: 0x2127D40 VA: 0x182129740
	|-Func<double, double>.BeginInvoke
	|
	|-RVA: 0x2127F40 Offset: 0x2126540 VA: 0x182127F40
	|-Func<Guid, int>.BeginInvoke
	|
	|-RVA: 0x21296C0 Offset: 0x2127CC0 VA: 0x1821296C0
	|-Func<Guid, object>.BeginInvoke
	|
	|-RVA: 0x2127CC0 Offset: 0x21262C0 VA: 0x182127CC0
	|-Func<int, FourBitNumber>.BeginInvoke
	|
	|-RVA: 0x21283C0 Offset: 0x21269C0 VA: 0x1821283C0
	|-Func<int, SevenBitNumber>.BeginInvoke
	|
	|-RVA: 0x2128240 Offset: 0x2126840 VA: 0x182128240
	|-Func<int, bool>.BeginInvoke
	|
	|-RVA: 0x212A3C0 Offset: 0x21289C0 VA: 0x18212A3C0
	|-Func<int, int>.BeginInvoke
	|
	|-RVA: 0x2128DC0 Offset: 0x21273C0 VA: 0x182128DC0
	|-Func<int, object>.BeginInvoke
	|
	|-RVA: 0x212B840 Offset: 0x2129E40 VA: 0x18212B840
	|-Func<int, float>.BeginInvoke
	|
	|-RVA: 0x2128540 Offset: 0x2126B40 VA: 0x182128540
	|-Func<Int32Enum, Debugging.EntityInfo>.BeginInvoke
	|
	|-RVA: 0x2128440 Offset: 0x2126A40 VA: 0x182128440
	|-Func<Int32Enum, PathFinder.Point>.BeginInvoke
	|
	|-RVA: 0x212AD40 Offset: 0x2129340 VA: 0x18212AD40
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.BeginInvoke
	|
	|-RVA: 0x212B340 Offset: 0x2129940 VA: 0x18212B340
	|-Func<Int32Enum, Option>.BeginInvoke
	|
	|-RVA: 0x2129240 Offset: 0x2127840 VA: 0x182129240
	|-Func<Int32Enum, InventoryItem>.BeginInvoke
	|
	|-RVA: 0x2127FC0 Offset: 0x21265C0 VA: 0x182127FC0
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.BeginInvoke
	|
	|-RVA: 0x2128FC0 Offset: 0x21275C0 VA: 0x182128FC0
	|-Func<Int32Enum, InventoryRecipe>.BeginInvoke
	|
	|-RVA: 0x2129EC0 Offset: 0x21284C0 VA: 0x182129EC0
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-RVA: 0x21288C0 Offset: 0x2126EC0 VA: 0x1821288C0
	|-Func<Int32Enum, KeyValuePair<object, int>>.BeginInvoke
	|
	|-RVA: 0x212A540 Offset: 0x2128B40 VA: 0x18212A540
	|-Func<Int32Enum, int>.BeginInvoke
	|
	|-RVA: 0x212A740 Offset: 0x2128D40 VA: 0x18212A740
	|-Func<Int32Enum, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x212ADC0 Offset: 0x21293C0 VA: 0x18212ADC0
	|-Func<Int32Enum, long>.BeginInvoke
	|
	|-RVA: 0x2128940 Offset: 0x2126F40 VA: 0x182128940
	|-Func<Int32Enum, object>.BeginInvoke
	|
	|-RVA: 0x212BDC0 Offset: 0x212A3C0 VA: 0x18212BDC0
	|-Func<Int32Enum, float>.BeginInvoke
	|
	|-RVA: 0x2129AC0 Offset: 0x21280C0 VA: 0x182129AC0
	|-Func<Int32Enum, Resolution>.BeginInvoke
	|
	|-RVA: 0x212A8C0 Offset: 0x2128EC0 VA: 0x18212A8C0
	|-Func<long, bool>.BeginInvoke
	|
	|-RVA: 0x21291C0 Offset: 0x21277C0 VA: 0x1821291C0
	|-Func<long, long>.BeginInvoke
	|
	|-RVA: 0x212BD40 Offset: 0x212A340 VA: 0x18212BD40
	|-Func<IntPtr, object>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Func<object, Debugging.EntityInfo>.BeginInvoke
	|-Func<object, FourBitNumber>.BeginInvoke
	|-Func<object, SevenBitNumber>.BeginInvoke
	|-Func<object, PathFinder.Point>.BeginInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.BeginInvoke
	|-Func<object, PlayerItemRecipe>.BeginInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.BeginInvoke
	|-Func<object, Option>.BeginInvoke
	|-Func<object, InventoryDefId>.BeginInvoke
	|-Func<object, InventoryItemId>.BeginInvoke
	|-Func<object, InventoryItem>.BeginInvoke
	|-Func<object, InventoryRecipe.Ingredient>.BeginInvoke
	|-Func<object, InventoryRecipe>.BeginInvoke
	|-Func<object, PublishResult>.BeginInvoke
	|-Func<object, bool>.BeginInvoke
	|-Func<object, KeyValuePair<object, int>>.BeginInvoke
	|-Func<object, DateTime>.BeginInvoke
	|-Func<object, DateTimeOffset>.BeginInvoke
	|-Func<object, Guid>.BeginInvoke
	|-Func<object, int>.BeginInvoke
	|-Func<object, Int32Enum>.BeginInvoke
	|-Func<object, long>.BeginInvoke
	|-Func<object, UdpReceiveResult>.BeginInvoke
	|-Func<object, Nullable<ServerInfo>>.BeginInvoke
	|-Func<object, Nullable<Image>>.BeginInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.BeginInvoke
	|-Func<object, Nullable<InventoryResult>>.BeginInvoke
	|-Func<object, Nullable<Item>>.BeginInvoke
	|-Func<object, Nullable<ResultPage>>.BeginInvoke
	|-Func<object, Nullable<int>>.BeginInvoke
	|-Func<object, Nullable<Int32Enum>>.BeginInvoke
	|-Func<object, object>.BeginInvoke
	|-Func<object, float>.BeginInvoke
	|-Func<object, VoidTaskResult>.BeginInvoke
	|-Func<object, uint>.BeginInvoke
	|-Func<object, ulong>.BeginInvoke
	|-Func<object, Resolution>.BeginInvoke
	|
	|-RVA: 0x19E6510 Offset: 0x19E4B10 VA: 0x1819E6510
	|-Func<float, bool>.BeginInvoke
	|
	|-RVA: 0x19E6410 Offset: 0x19E4A10 VA: 0x1819E6410
	|-Func<float, float>.BeginInvoke
	|
	|-RVA: 0x19E6210 Offset: 0x19E4810 VA: 0x1819E6210
	|-Func<uint, bool>.BeginInvoke
	|
	|-RVA: 0x19E6290 Offset: 0x19E4890 VA: 0x1819E6290
	|-Func<uint, uint>.BeginInvoke
	|
	|-RVA: 0x19E6690 Offset: 0x19E4C90 VA: 0x1819E6690
	|-Func<ulong, bool>.BeginInvoke
	|
	|-RVA: 0x19E6490 Offset: 0x19E4A90 VA: 0x1819E6490
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x19E6310 Offset: 0x19E4910 VA: 0x1819E6310
	|-Func<ValueTuple<Int32Enum, int>, object>.BeginInvoke
	|
	|-RVA: 0x19E6710 Offset: 0x19E4D10 VA: 0x1819E6710
	|-Func<Resolution, bool>.BeginInvoke
	|
	|-RVA: 0x19E6590 Offset: 0x19E4B90 VA: 0x1819E6590
	|-Func<Resolution, int>.BeginInvoke
	|
	|-RVA: 0x19E6610 Offset: 0x19E4C10 VA: 0x1819E6610
	|-Func<Resolution, Resolution>.BeginInvoke
	|
	|-RVA: 0x19E6390 Offset: 0x19E4990 VA: 0x1819E6390
	|-Func<Resolution, Vector2Int>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Func<Admin.PlayerInfo, object>.EndInvoke
	|-Func<Admin.ServerConvarInfo, object>.EndInvoke
	|-Func<Demos.DemoInfo, object>.EndInvoke
	|-Func<SkeletonDefinition.Bone, object>.EndInvoke
	|-Func<ImageStorageEntity.ImageRequest, object>.EndInvoke
	|-Func<SevenBitNumber, object>.EndInvoke
	|-Func<DefaultSerializationBinder.TypeNameKey, object>.EndInvoke
	|-Func<ConvertUtils.TypeConvertKey, object>.EndInvoke
	|-Func<PlayerItemRecipe, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Achievement, object>.EndInvoke
	|-Func<InventoryDefId, object>.EndInvoke
	|-Func<ServerInfo, object>.EndInvoke
	|-Func<Friend, object>.EndInvoke
	|-Func<InventoryItem, object>.EndInvoke
	|-Func<InventoryRecipe, object>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, object>.EndInvoke
	|-Func<ArraySegment<byte>, object>.EndInvoke
	|-Func<DictionaryEntry, object>.EndInvoke
	|-Func<KeyValuePair<object, object>, object>.EndInvoke
	|-Func<KeyValuePair<uint, object>, object>.EndInvoke
	|-Func<Guid, object>.EndInvoke
	|-Func<int, object>.EndInvoke
	|-Func<Int32Enum, object>.EndInvoke
	|-Func<IntPtr, object>.EndInvoke
	|-Func<object, object>.EndInvoke
	|-Func<ValueTuple<Int32Enum, int>, object>.EndInvoke
	|
	|-RVA: 0x12214E0 Offset: 0x121FAE0 VA: 0x1812214E0
	|-Func<Debugging.EntityInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Debugging.EntityInfo>.EndInvoke
	|-Func<SkeletonDefinition.Bone, KeyValuePair<object, int>>.EndInvoke
	|-Func<PlayerItemRecipe, Debugging.EntityInfo>.EndInvoke
	|-Func<PlayerItemRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, KeyValuePair<object, int>>.EndInvoke
	|-Func<ServerInfo, Debugging.EntityInfo>.EndInvoke
	|-Func<ServerInfo, KeyValuePair<object, int>>.EndInvoke
	|-Func<Achievement, Debugging.EntityInfo>.EndInvoke
	|-Func<Achievement, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryDefId, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryDefId, KeyValuePair<object, int>>.EndInvoke
	|-Func<Friend, Debugging.EntityInfo>.EndInvoke
	|-Func<Friend, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryItem, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryItem, KeyValuePair<object, int>>.EndInvoke
	|-Func<InventoryRecipe, PlayerItemRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Debugging.EntityInfo>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, KeyValuePair<object, int>>.EndInvoke
	|-Func<DictionaryEntry, KeyValuePair<object, object>>.EndInvoke
	|-Func<KeyValuePair<object, int>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<object, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Debugging.EntityInfo>.EndInvoke
	|-Func<KeyValuePair<uint, object>, KeyValuePair<object, int>>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>.EndInvoke
	|-Func<Int32Enum, Debugging.EntityInfo>.EndInvoke
	|-Func<Int32Enum, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, Debugging.EntityInfo>.EndInvoke
	|-Func<object, PlayerItemRecipe>.EndInvoke
	|-Func<object, KeyValuePair<object, int>>.EndInvoke
	|-Func<object, DateTimeOffset>.EndInvoke
	|-Func<object, Guid>.EndInvoke
	|-Func<object, UdpReceiveResult>.EndInvoke
	|
	|-RVA: 0xFF70B0 Offset: 0xFF56B0 VA: 0x180FF70B0
	|-Func<Debugging.EntityInfo, bool>.EndInvoke
	|-Func<Entity.EntityInfo, bool>.EndInvoke
	|-Func<BurstCloth.Chain, FourBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, SevenBitNumber>.EndInvoke
	|-Func<BurstCloth.Chain, bool>.EndInvoke
	|-Func<RCon.BannedAddresses, bool>.EndInvoke
	|-Func<SkeletonDefinition.Bone, bool>.EndInvoke
	|-Func<WeightedStringList.Container, bool>.EndInvoke
	|-Func<GameStat.Stat, bool>.EndInvoke
	|-Func<ItemSkinDirectory.Skin, bool>.EndInvoke
	|-Func<FourBitNumber, FourBitNumber>.EndInvoke
	|-Func<FourBitNumber, bool>.EndInvoke
	|-Func<SevenBitNumber, SevenBitNumber>.EndInvoke
	|-Func<SevenBitNumber, bool>.EndInvoke
	|-Func<PathFinder.Point, bool>.EndInvoke
	|-Func<PetCommandList.PetCommandDesc, bool>.EndInvoke
	|-Func<PlayerItemRecipe, bool>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, FourBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, SevenBitNumber>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, bool>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, bool>.EndInvoke
	|-Func<Option, bool>.EndInvoke
	|-Func<ServerInfo, FourBitNumber>.EndInvoke
	|-Func<ServerInfo, SevenBitNumber>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, bool>.EndInvoke
	|-Func<Achievement, bool>.EndInvoke
	|-Func<InventoryDefId, bool>.EndInvoke
	|-Func<InventoryItemId, bool>.EndInvoke
	|-Func<ServerInfo, bool>.EndInvoke
	|-Func<Friend, bool>.EndInvoke
	|-Func<InventoryItem, FourBitNumber>.EndInvoke
	|-Func<InventoryItem, SevenBitNumber>.EndInvoke
	|-Func<InventoryItem, bool>.EndInvoke
	|-Func<InventoryItem.Amount, bool>.EndInvoke
	|-Func<InventoryRecipe, bool>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, bool>.EndInvoke
	|-Func<bool, bool>.EndInvoke
	|-Func<char, bool>.EndInvoke
	|-Func<DictionaryEntry, bool>.EndInvoke
	|-Func<KeyValuePair<object, int>, bool>.EndInvoke
	|-Func<KeyValuePair<object, object>, bool>.EndInvoke
	|-Func<KeyValuePair<uint, object>, bool>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>.EndInvoke
	|-Func<int, FourBitNumber>.EndInvoke
	|-Func<int, SevenBitNumber>.EndInvoke
	|-Func<int, bool>.EndInvoke
	|-Func<Int32Enum, bool>.EndInvoke
	|-Func<long, bool>.EndInvoke
	|-Func<object, FourBitNumber>.EndInvoke
	|-Func<object, SevenBitNumber>.EndInvoke
	|-Func<object, bool>.EndInvoke
	|-Func<object, VoidTaskResult>.EndInvoke
	|-Func<float, bool>.EndInvoke
	|-Func<uint, bool>.EndInvoke
	|-Func<ulong, bool>.EndInvoke
	|-Func<Resolution, bool>.EndInvoke
	|
	|-RVA: 0x1221E30 Offset: 0x1220430 VA: 0x181221E30
	|-Func<Demos.DemoInfo, DateTime>.EndInvoke
	|-Func<Demos.DemoInfo, TimeSpan>.EndInvoke
	|-Func<SkeletonDefinition.Bone, PathFinder.Point>.EndInvoke
	|-Func<SkeletonDefinition.Bone, long>.EndInvoke
	|-Func<PathFinder.Point, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, PathFinder.Point>.EndInvoke
	|-Func<PlayerItemRecipe, long>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, PathFinder.Point>.EndInvoke
	|-Func<ServerInfo, long>.EndInvoke
	|-Func<SkinnedMultiMesh.Part, long>.EndInvoke
	|-Func<Achievement, PathFinder.Point>.EndInvoke
	|-Func<Achievement, long>.EndInvoke
	|-Func<InventoryDefId, PathFinder.Point>.EndInvoke
	|-Func<InventoryDefId, long>.EndInvoke
	|-Func<InventoryItemId, InventoryItemId>.EndInvoke
	|-Func<Friend, PathFinder.Point>.EndInvoke
	|-Func<Friend, long>.EndInvoke
	|-Func<InventoryItem, PathFinder.Point>.EndInvoke
	|-Func<InventoryItem, InventoryItemId>.EndInvoke
	|-Func<InventoryItem, long>.EndInvoke
	|-Func<InventoryItem.Amount, InventoryItemId>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PathFinder.Point>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, long>.EndInvoke
	|-Func<Item, DateTime>.EndInvoke
	|-Func<KeyValuePair<object, long>, long>.EndInvoke
	|-Func<KeyValuePair<object, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<object, object>, long>.EndInvoke
	|-Func<KeyValuePair<uint, object>, PathFinder.Point>.EndInvoke
	|-Func<KeyValuePair<uint, object>, long>.EndInvoke
	|-Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>.EndInvoke
	|-Func<Int32Enum, PathFinder.Point>.EndInvoke
	|-Func<Int32Enum, long>.EndInvoke
	|-Func<long, long>.EndInvoke
	|-Func<object, PathFinder.Point>.EndInvoke
	|-Func<object, PlayerItemRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryItemId>.EndInvoke
	|-Func<object, DateTime>.EndInvoke
	|-Func<object, long>.EndInvoke
	|-Func<object, Nullable<int>>.EndInvoke
	|-Func<object, Nullable<Int32Enum>>.EndInvoke
	|-Func<object, ulong>.EndInvoke
	|-Func<ulong, ulong>.EndInvoke
	|-Func<Resolution, Vector2Int>.EndInvoke
	|
	|-RVA: 0xB9AFA0 Offset: 0xB995A0 VA: 0x180B9AFA0
	|-Func<BurstCloth.Chain, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, int>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe, int>.EndInvoke
	|-Func<PlayerItemRecipe, Int32Enum>.EndInvoke
	|-Func<PlayerItemRecipe.Ingredient, int>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<ServerInfo, Int32Enum>.EndInvoke
	|-Func<ServerInfo, uint>.EndInvoke
	|-Func<Achievement, int>.EndInvoke
	|-Func<Achievement, Int32Enum>.EndInvoke
	|-Func<InventoryDefId, int>.EndInvoke
	|-Func<InventoryDefId, Int32Enum>.EndInvoke
	|-Func<ServerInfo, int>.EndInvoke
	|-Func<Friend, int>.EndInvoke
	|-Func<Friend, Int32Enum>.EndInvoke
	|-Func<InventoryItem, InventoryDefId>.EndInvoke
	|-Func<InventoryItem, int>.EndInvoke
	|-Func<InventoryItem, Int32Enum>.EndInvoke
	|-Func<InventoryItem, uint>.EndInvoke
	|-Func<InventoryItem.Amount, uint>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, int>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<object, int>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, int>.EndInvoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, int>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Int32Enum>.EndInvoke
	|-Func<KeyValuePair<uint, object>, uint>.EndInvoke
	|-Func<Guid, int>.EndInvoke
	|-Func<int, int>.EndInvoke
	|-Func<Int32Enum, int>.EndInvoke
	|-Func<Int32Enum, Int32Enum>.EndInvoke
	|-Func<object, InventoryDefId>.EndInvoke
	|-Func<object, int>.EndInvoke
	|-Func<object, Int32Enum>.EndInvoke
	|-Func<object, uint>.EndInvoke
	|-Func<uint, uint>.EndInvoke
	|-Func<Resolution, int>.EndInvoke
	|
	|-RVA: 0x1977ED0 Offset: 0x19764D0 VA: 0x181977ED0
	|-Func<SkeletonDefinition.Bone, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<SkeletonDefinition.Bone, Resolution>.EndInvoke
	|-Func<PlayerItemRecipe, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<PlayerItemRecipe, Resolution>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<ServerInfo, Resolution>.EndInvoke
	|-Func<Achievement, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Achievement, Resolution>.EndInvoke
	|-Func<InventoryDefId, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryDefId, Resolution>.EndInvoke
	|-Func<Friend, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Friend, Resolution>.EndInvoke
	|-Func<InventoryItem, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryItem, Resolution>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Resolution>.EndInvoke
	|-Func<KeyValuePair<object, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<object, object>, Resolution>.EndInvoke
	|-Func<KeyValuePair<uint, object>, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Resolution>.EndInvoke
	|-Func<Int32Enum, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<Int32Enum, Resolution>.EndInvoke
	|-Func<object, ProjectileWeaponMod.Modifier>.EndInvoke
	|-Func<object, Nullable<InventoryResult>>.EndInvoke
	|-Func<object, Resolution>.EndInvoke
	|-Func<Resolution, Resolution>.EndInvoke
	|
	|-RVA: 0x19E6800 Offset: 0x19E4E00 VA: 0x1819E6800
	|-Func<SkeletonDefinition.Bone, Option>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryItem>.EndInvoke
	|-Func<PlayerItemRecipe, Option>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryItem>.EndInvoke
	|-Func<Option, Option>.EndInvoke
	|-Func<ServerInfo, Option>.EndInvoke
	|-Func<ServerInfo, InventoryItem>.EndInvoke
	|-Func<Achievement, Option>.EndInvoke
	|-Func<Achievement, InventoryItem>.EndInvoke
	|-Func<InventoryDefId, Option>.EndInvoke
	|-Func<InventoryDefId, InventoryItem>.EndInvoke
	|-Func<Friend, Option>.EndInvoke
	|-Func<Friend, InventoryItem>.EndInvoke
	|-Func<InventoryItem, Option>.EndInvoke
	|-Func<InventoryItem, InventoryItem>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, Option>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<object, object>, Option>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryItem>.EndInvoke
	|-Func<KeyValuePair<uint, object>, Option>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryItem>.EndInvoke
	|-Func<Int32Enum, Option>.EndInvoke
	|-Func<Int32Enum, InventoryItem>.EndInvoke
	|-Func<object, Option>.EndInvoke
	|-Func<object, InventoryItem>.EndInvoke
	|-Func<object, Nullable<InventoryPurchaseResult>>.EndInvoke
	|-Func<object, Nullable<ResultPage>>.EndInvoke
	|
	|-RVA: 0x19E6920 Offset: 0x19E4F20 VA: 0x1819E6920
	|-Func<SkeletonDefinition.Bone, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<SkeletonDefinition.Bone, InventoryRecipe>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<PlayerItemRecipe, InventoryRecipe>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<ServerInfo, InventoryRecipe>.EndInvoke
	|-Func<Achievement, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Achievement, InventoryRecipe>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryDefId, InventoryRecipe>.EndInvoke
	|-Func<Friend, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Friend, InventoryRecipe>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryItem, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe, InventoryRecipe>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<object, object>, InventoryRecipe>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<KeyValuePair<uint, object>, InventoryRecipe>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<Int32Enum, InventoryRecipe>.EndInvoke
	|-Func<object, InventoryRecipe.Ingredient>.EndInvoke
	|-Func<object, InventoryRecipe>.EndInvoke
	|-Func<object, PublishResult>.EndInvoke
	|-Func<object, Nullable<Image>>.EndInvoke
	|
	|-RVA: 0x19E6840 Offset: 0x19E4E40 VA: 0x1819E6840
	|-Func<SkeletonDefinition.Bone, float>.EndInvoke
	|-Func<WeightedStringList.Container, float>.EndInvoke
	|-Func<PlayerItemRecipe, float>.EndInvoke
	|-Func<ProjectileWeaponMod.Modifier, float>.EndInvoke
	|-Func<ServerInfo, float>.EndInvoke
	|-Func<Achievement, float>.EndInvoke
	|-Func<InventoryDefId, float>.EndInvoke
	|-Func<Friend, float>.EndInvoke
	|-Func<InventoryItem, float>.EndInvoke
	|-Func<InventoryRecipe.Ingredient, float>.EndInvoke
	|-Func<KeyValuePair<object, object>, float>.EndInvoke
	|-Func<KeyValuePair<uint, object>, float>.EndInvoke
	|-Func<int, float>.EndInvoke
	|-Func<Int32Enum, float>.EndInvoke
	|-Func<object, float>.EndInvoke
	|-Func<float, float>.EndInvoke
	|
	|-RVA: 0x212BF40 Offset: 0x212A540 VA: 0x18212BF40
	|-Func<ServerInfo, ServerInfo>.EndInvoke
	|
	|-RVA: 0x212BFB0 Offset: 0x212A5B0 VA: 0x18212BFB0
	|-Func<double, double>.EndInvoke
	|
	|-RVA: 0x19E6790 Offset: 0x19E4D90 VA: 0x1819E6790
	|-Func<object, Nullable<ServerInfo>>.EndInvoke
	|
	|-RVA: 0x19E6870 Offset: 0x19E4E70 VA: 0x1819E6870
	|-Func<object, Nullable<Item>>.EndInvoke
	*/

}

public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 161
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-Converter<object, object>..ctor
	*/

	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A600 Offset: 0xD58C00 VA: 0x180D5A600
	|-Converter<Type, string>.Invoke
	|-Converter<object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-Converter<object, object>.BeginInvoke
	*/

	public virtual TOutput EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-Converter<object, object>.EndInvoke
	*/

}

internal struct __DTString // TypeDefIndex: 231
{	internal string Value; // 0x0
	internal int Index; // 0x8
	internal int len; // 0xC
	internal char m_current; // 0x10
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static char[] WhiteSpaceChecks; // 0x0

	internal CompareInfo CompareInfo { get; }


	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	internal CompareInfo get_CompareInfo() { }

	internal bool GetNext() { }

	internal bool AtEnd() { }

	internal bool Advance(int count) { }

	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	internal bool MatchSpecifiedWord(string target) { }

	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	internal bool Match(string str) { }

	internal bool Match(char ch) { }

	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	internal int GetRepeatCount() { }

	internal bool GetNextDigit() { }

	internal char GetChar() { }

	internal int GetDigit() { }

	internal void SkipWhiteSpaces() { }

	internal bool SkipWhiteSpaceCurrent() { }

	internal void TrimTail() { }

	internal void RemoveTrailingInQuoteSpaces() { }

	internal void RemoveLeadingInQuoteSpaces() { }

	internal DTSubString GetSubString() { }

	internal void ConsumeSubString(DTSubString sub) { }

	private static void .cctor() { }

}

internal class __ComObject // TypeDefIndex: 429
{
	private void .ctor() { }

}

internal static class __Error // TypeDefIndex: 615
{
	internal static void EndOfFile() { }

	internal static void FileNotOpen() { }

	internal static void StreamIsClosed() { }

	internal static void MemoryStreamNotExpandable() { }

	internal static void ReaderClosed() { }

	internal static void ReadNotSupported() { }

	internal static void WrongAsyncResult() { }

	internal static void EndReadCalledTwice() { }

	internal static void EndWriteCalledTwice() { }

	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	internal static void WriteNotSupported() { }

	internal static void WriterClosed() { }

}

internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 627
{	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19D0BF0 Offset: 0x19CF1F0 VA: 0x1819D0BF0
	|-Iterator<object>..ctor
	*/

	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Iterator<object>.get_Current
	*/

	protected abstract Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.Clone
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19EFDA0 Offset: 0x19EE3A0 VA: 0x1819EFDA0
	|-Iterator<object>.Dispose
	*/

	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CF9B0 Offset: 0x19CDFB0 VA: 0x1819CF9B0
	|-Iterator<object>.Dispose
	*/

	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CFA70 Offset: 0x19CE070 VA: 0x1819CFA70
	|-Iterator<object>.GetEnumerator
	*/

	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.MoveNext
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355360 Offset: 0x1353960 VA: 0x181355360
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16456C0 Offset: 0x1643CC0 VA: 0x1816456C0
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19EFE20 Offset: 0x19EE420 VA: 0x1819EFE20
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/

}

internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 629
{
	internal abstract bool IsResultIncluded(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	internal abstract TSource CreateObject(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.CreateObject
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/

}

internal static class _ThreadPoolWaitCallback // TypeDefIndex: 814
{
	internal static bool PerformWaitCallback() { }

}

public class Task<TResult> : Task // TypeDefIndex: 842
{	internal TResult m_result; // 0x0
	private static readonly TaskFactory<TResult> s_Factory; // 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; // 0x0

	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }


	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A97F40 Offset: 0x1A96540 VA: 0x181A97F40
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A96160 Offset: 0x1A94760 VA: 0x181A96160
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A968C0 Offset: 0x1A94EC0 VA: 0x181A968C0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A96460 Offset: 0x1A94A60 VA: 0x181A96460
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A96C40 Offset: 0x1A95240 VA: 0x181A96C40
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A95DF0 Offset: 0x1A943F0 VA: 0x181A95DF0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A972D0 Offset: 0x1A958D0 VA: 0x181A972D0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A97C10 Offset: 0x1A96210 VA: 0x181A97C10
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A961C0 Offset: 0x1A947C0 VA: 0x181A961C0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A96100 Offset: 0x1A94700 VA: 0x181A96100
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A43B30 Offset: 0x1A42130 VA: 0x181A43B30
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A43310 Offset: 0x1A41910 VA: 0x181A43310
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A42E70 Offset: 0x1A41470 VA: 0x181A42E70
	|-Task<object>..ctor
	|-Task<Task>..ctor
	|
	|-RVA: 0x1A43370 Offset: 0x1A41970 VA: 0x181A43370
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A96CA0 Offset: 0x1A952A0 VA: 0x181A96CA0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A96E10 Offset: 0x1A95410 VA: 0x181A96E10
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A97D00 Offset: 0x1A96300 VA: 0x181A97D00
	|-Task<int>..ctor
	|
	|-RVA: 0x1A97EB0 Offset: 0x1A964B0 VA: 0x181A97EB0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A95B10 Offset: 0x1A94110 VA: 0x181A95B10
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A963D0 Offset: 0x1A949D0 VA: 0x181A963D0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A95FE0 Offset: 0x1A945E0 VA: 0x181A95FE0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A96070 Offset: 0x1A94670 VA: 0x181A96070
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A94A50 Offset: 0x1A93050 VA: 0x181A94A50
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A94F20 Offset: 0x1A93520 VA: 0x181A94F20
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A43280 Offset: 0x1A41880 VA: 0x181A43280
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A434F0 Offset: 0x1A41AF0 VA: 0x181A434F0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A43980 Offset: 0x1A41F80 VA: 0x181A43980
	|-Task<object>..ctor
	|
	|-RVA: 0x1A43C30 Offset: 0x1A42230 VA: 0x181A43C30
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A958B0 Offset: 0x1A93EB0 VA: 0x181A958B0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A94330 Offset: 0x1A92930 VA: 0x181A94330
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A94AE0 Offset: 0x1A930E0 VA: 0x181A94AE0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A97C70 Offset: 0x1A96270 VA: 0x181A97C70
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A97330 Offset: 0x1A95930 VA: 0x181A97330
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A97230 Offset: 0x1A95830 VA: 0x181A97230
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A96220 Offset: 0x1A94820 VA: 0x181A96220
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A95D60 Offset: 0x1A94360 VA: 0x181A95D60
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A97410 Offset: 0x1A95A10 VA: 0x181A97410
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A94E90 Offset: 0x1A93490 VA: 0x181A94E90
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A436A0 Offset: 0x1A41CA0 VA: 0x181A436A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A42580 Offset: 0x1A40B80 VA: 0x181A42580
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A42FF0 Offset: 0x1A415F0 VA: 0x181A42FF0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A42DF0 Offset: 0x1A413F0 VA: 0x181A42DF0
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A97FA0 Offset: 0x1A965A0 VA: 0x181A97FA0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A94FB0 Offset: 0x1A935B0 VA: 0x181A94FB0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A943B0 Offset: 0x1A929B0 VA: 0x181A943B0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A97180 Offset: 0x1A95780 VA: 0x181A97180
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A95250 Offset: 0x1A93850 VA: 0x181A95250
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A956D0 Offset: 0x1A93CD0 VA: 0x181A956D0
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A95F30 Offset: 0x1A94530 VA: 0x181A95F30
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A97B60 Offset: 0x1A96160 VA: 0x181A97B60
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A94B60 Offset: 0x1A93160 VA: 0x181A94B60
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A95A60 Offset: 0x1A94060 VA: 0x181A95A60
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A43720 Offset: 0x1A41D20 VA: 0x181A43720
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A42600 Offset: 0x1A40C00 VA: 0x181A42600
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A42AA0 Offset: 0x1A410A0 VA: 0x181A42AA0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A43B90 Offset: 0x1A42190 VA: 0x181A43B90
	|-Task<VoidTaskResult>..ctor
	*/

	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A96FC0 Offset: 0x1A955C0 VA: 0x181A96FC0
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A970A0 Offset: 0x1A956A0 VA: 0x181A970A0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A947B0 Offset: 0x1A92DB0 VA: 0x181A947B0
	|-Task<int>..ctor
	|
	|-RVA: 0x1A94890 Offset: 0x1A92E90 VA: 0x181A94890
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A94970 Offset: 0x1A92F70 VA: 0x181A94970
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A95430 Offset: 0x1A93A30 VA: 0x181A95430
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A967E0 Offset: 0x1A94DE0 VA: 0x181A967E0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A95050 Offset: 0x1A93650 VA: 0x181A95050
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A94C90 Offset: 0x1A93290 VA: 0x181A94C90
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A96D30 Offset: 0x1A95330 VA: 0x181A96D30
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A431A0 Offset: 0x1A417A0 VA: 0x181A431A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A427C0 Offset: 0x1A40DC0 VA: 0x181A427C0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A42B50 Offset: 0x1A41150 VA: 0x181A42B50
	|-Task<object>..ctor
	|
	|-RVA: 0x1A428A0 Offset: 0x1A40EA0 VA: 0x181A428A0
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A95C80 Offset: 0x1A94280 VA: 0x181A95C80
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A97A80 Offset: 0x1A96080 VA: 0x181A97A80
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A96A40 Offset: 0x1A95040 VA: 0x181A96A40
	|-Task<int>..ctor
	|
	|-RVA: 0x1A965E0 Offset: 0x1A94BE0 VA: 0x181A965E0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A95BA0 Offset: 0x1A941A0 VA: 0x181A95BA0
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A95E50 Offset: 0x1A94450 VA: 0x181A95E50
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A95350 Offset: 0x1A93950 VA: 0x181A95350
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A95510 Offset: 0x1A93B10 VA: 0x181A95510
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A979A0 Offset: 0x1A95FA0 VA: 0x181A979A0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A955F0 Offset: 0x1A93BF0 VA: 0x181A955F0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A42D10 Offset: 0x1A41310 VA: 0x181A42D10
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A437C0 Offset: 0x1A41DC0 VA: 0x181A437C0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A438A0 Offset: 0x1A41EA0 VA: 0x181A438A0
	|-Task<object>..ctor
	|
	|-RVA: 0x1A42C30 Offset: 0x1A41230 VA: 0x181A42C30
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A97D90 Offset: 0x1A96390 VA: 0x181A97D90
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A97520 Offset: 0x1A95B20 VA: 0x181A97520
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A94450 Offset: 0x1A92A50 VA: 0x181A94450
	|-Task<int>..ctor
	|
	|-RVA: 0x1A97880 Offset: 0x1A95E80 VA: 0x181A97880
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A95130 Offset: 0x1A93730 VA: 0x181A95130
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A94570 Offset: 0x1A92B70 VA: 0x181A94570
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A966C0 Offset: 0x1A94CC0 VA: 0x181A966C0
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A94210 Offset: 0x1A92810 VA: 0x181A94210
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A94690 Offset: 0x1A92C90 VA: 0x181A94690
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A98050 Offset: 0x1A96650 VA: 0x181A98050
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A43080 Offset: 0x1A41680 VA: 0x181A43080
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A43CC0 Offset: 0x1A422C0 VA: 0x181A43CC0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A43A10 Offset: 0x1A42010 VA: 0x181A43A10
	|-Task<object>..ctor
	|
	|-RVA: 0x1A43580 Offset: 0x1A41B80 VA: 0x181A43580
	|-Task<VoidTaskResult>..ctor
	*/

	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A95790 Offset: 0x1A93D90 VA: 0x181A95790
	|-Task<PublishResult>..ctor
	|
	|-RVA: 0x1A962B0 Offset: 0x1A948B0 VA: 0x181A962B0
	|-Task<bool>..ctor
	|
	|-RVA: 0x1A95940 Offset: 0x1A93F40 VA: 0x181A95940
	|-Task<int>..ctor
	|
	|-RVA: 0x1A97640 Offset: 0x1A95C40 VA: 0x181A97640
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0x1A94D70 Offset: 0x1A93370 VA: 0x181A94D70
	|-Task<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x1A97760 Offset: 0x1A95D60 VA: 0x181A97760
	|-Task<Nullable<Image>>..ctor
	|
	|-RVA: 0x1A96920 Offset: 0x1A94F20 VA: 0x181A96920
	|-Task<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1A96B20 Offset: 0x1A95120 VA: 0x181A96B20
	|-Task<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1A96EA0 Offset: 0x1A954A0 VA: 0x181A96EA0
	|-Task<Nullable<Item>>..ctor
	|
	|-RVA: 0x1A964C0 Offset: 0x1A94AC0 VA: 0x181A964C0
	|-Task<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1A426A0 Offset: 0x1A40CA0 VA: 0x181A426A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1A42ED0 Offset: 0x1A414D0 VA: 0x181A42ED0
	|-Task<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1A42980 Offset: 0x1A40F80 VA: 0x181A42980
	|-Task<object>..ctor
	|
	|-RVA: 0x1A433D0 Offset: 0x1A419D0 VA: 0x181A433D0
	|-Task<VoidTaskResult>..ctor
	*/

	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A938F0 Offset: 0x1A91EF0 VA: 0x181A938F0
	|-Task<PublishResult>.StartNew
	|
	|-RVA: 0x1A92B70 Offset: 0x1A91170 VA: 0x181A92B70
	|-Task<bool>.StartNew
	|
	|-RVA: 0x1A92930 Offset: 0x1A90F30 VA: 0x181A92930
	|-Task<int>.StartNew
	|
	|-RVA: 0x1A92FF0 Offset: 0x1A915F0 VA: 0x181A92FF0
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A92DB0 Offset: 0x1A913B0 VA: 0x181A92DB0
	|-Task<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A936B0 Offset: 0x1A91CB0 VA: 0x181A936B0
	|-Task<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A926F0 Offset: 0x1A90CF0 VA: 0x181A926F0
	|-Task<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A924B0 Offset: 0x1A90AB0 VA: 0x181A924B0
	|-Task<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A93470 Offset: 0x1A91A70 VA: 0x181A93470
	|-Task<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A93230 Offset: 0x1A91830 VA: 0x181A93230
	|-Task<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A41CF0 Offset: 0x1A402F0 VA: 0x181A41CF0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A41630 Offset: 0x1A3FC30 VA: 0x181A41630
	|-Task<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A41870 Offset: 0x1A3FE70 VA: 0x181A41870
	|-Task<object>.StartNew
	|
	|-RVA: 0x1A41AB0 Offset: 0x1A400B0 VA: 0x181A41AB0
	|-Task<VoidTaskResult>.StartNew
	*/

	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A94150 Offset: 0x1A92750 VA: 0x181A94150
	|-Task<PublishResult>.TrySetResult
	|
	|-RVA: 0x1A421D0 Offset: 0x1A407D0 VA: 0x181A421D0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x1A93B30 Offset: 0x1A92130 VA: 0x181A93B30
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x1A93CA0 Offset: 0x1A922A0 VA: 0x181A93CA0
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-RVA: 0x1A93EB0 Offset: 0x1A924B0 VA: 0x181A93EB0
	|-Task<Nullable<ServerInfo>>.TrySetResult
	|
	|-RVA: 0x1A93FC0 Offset: 0x1A925C0 VA: 0x181A93FC0
	|-Task<Nullable<Image>>.TrySetResult
	|
	|-RVA: 0x1A93BE0 Offset: 0x1A921E0 VA: 0x181A93BE0
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetResult
	|-Task<Nullable<ResultPage>>.TrySetResult
	|
	|-RVA: 0x1A94090 Offset: 0x1A92690 VA: 0x181A94090
	|-Task<Nullable<InventoryResult>>.TrySetResult
	|
	|-RVA: 0x1A93D60 Offset: 0x1A92360 VA: 0x181A93D60
	|-Task<Nullable<Item>>.TrySetResult
	|
	|-RVA: 0x1A42060 Offset: 0x1A40660 VA: 0x181A42060
	|-Task<Nullable<int>>.TrySetResult
	|-Task<Nullable<Int32Enum>>.TrySetResult
	|
	|-RVA: 0x1A42110 Offset: 0x1A40710 VA: 0x181A42110
	|-Task<object>.TrySetResult
	|-Task<Task>.TrySetResult
	*/

	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A91670 Offset: 0x1A8FC70 VA: 0x181A91670
	|-Task<PublishResult>.DangerousSetResult
	|
	|-RVA: 0x1A41160 Offset: 0x1A3F760 VA: 0x181A41160
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1A91420 Offset: 0x1A8FA20 VA: 0x181A91420
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x1A91480 Offset: 0x1A8FA80 VA: 0x181A91480
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-RVA: 0x1A91560 Offset: 0x1A8FB60 VA: 0x181A91560
	|-Task<Nullable<ServerInfo>>.DangerousSetResult
	|
	|-RVA: 0x1A916F0 Offset: 0x1A8FCF0 VA: 0x181A916F0
	|-Task<Nullable<Image>>.DangerousSetResult
	|
	|-RVA: 0x1A914F0 Offset: 0x1A8FAF0 VA: 0x181A914F0
	|-Task<Nullable<InventoryPurchaseResult>>.DangerousSetResult
	|-Task<Nullable<ResultPage>>.DangerousSetResult
	|
	|-RVA: 0x1A913B0 Offset: 0x1A8F9B0 VA: 0x181A913B0
	|-Task<Nullable<InventoryResult>>.DangerousSetResult
	|
	|-RVA: 0x1A91230 Offset: 0x1A8F830 VA: 0x181A91230
	|-Task<Nullable<Item>>.DangerousSetResult
	|
	|-RVA: 0x1A411C0 Offset: 0x1A3F7C0 VA: 0x181A411C0
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<Nullable<Int32Enum>>.DangerousSetResult
	|
	|-RVA: 0x1A41220 Offset: 0x1A3F820 VA: 0x181A41220
	|-Task<object>.DangerousSetResult
	*/

	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A43DE0 Offset: 0x1A423E0 VA: 0x181A43DE0
	|-Task<ISocket>.get_Result
	|-Task<SteamInventoryCrafting.MarketPrice>.get_Result
	|-Task<Nullable<int>>.get_Result
	|-Task<Nullable<Int32Enum>>.get_Result
	|-Task<object>.get_Result
	|-Task<Task>.get_Result
	|
	|-RVA: 0x1A98670 Offset: 0x1A96C70 VA: 0x181A98670
	|-Task<PublishResult>.get_Result
	|-Task<Nullable<Image>>.get_Result
	|
	|-RVA: 0x1A43E50 Offset: 0x1A42450 VA: 0x181A43E50
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1A98600 Offset: 0x1A96C00 VA: 0x181A98600
	|-Task<int>.get_Result
	|
	|-RVA: 0x1A984E0 Offset: 0x1A96AE0 VA: 0x181A984E0
	|-Task<UdpReceiveResult>.get_Result
	|
	|-RVA: 0x1A98710 Offset: 0x1A96D10 VA: 0x181A98710
	|-Task<Nullable<ServerInfo>>.get_Result
	|
	|-RVA: 0x1A98570 Offset: 0x1A96B70 VA: 0x181A98570
	|-Task<Nullable<InventoryPurchaseResult>>.get_Result
	|-Task<Nullable<ResultPage>>.get_Result
	|
	|-RVA: 0x1A982D0 Offset: 0x1A968D0 VA: 0x181A982D0
	|-Task<Nullable<InventoryResult>>.get_Result
	|
	|-RVA: 0x1A98370 Offset: 0x1A96970 VA: 0x181A98370
	|-Task<Nullable<Item>>.get_Result
	*/

	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A98190 Offset: 0x1A96790 VA: 0x181A98190
	|-Task<PublishResult>.get_ResultOnSuccess
	|-Task<Nullable<Image>>.get_ResultOnSuccess
	|
	|-RVA: 0x77B220 Offset: 0x779820 VA: 0x18077B220
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x8D9600 Offset: 0x8D7C00 VA: 0x1808D9600
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x105EBD0 Offset: 0x105D1D0 VA: 0x18105EBD0
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0x1A98270 Offset: 0x1A96870 VA: 0x181A98270
	|-Task<Nullable<ServerInfo>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A98250 Offset: 0x1A96850 VA: 0x181A98250
	|-Task<Nullable<InventoryPurchaseResult>>.get_ResultOnSuccess
	|-Task<Nullable<ResultPage>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A98170 Offset: 0x1A96770 VA: 0x181A98170
	|-Task<Nullable<InventoryResult>>.get_ResultOnSuccess
	|
	|-RVA: 0x1A981B0 Offset: 0x1A967B0 VA: 0x181A981B0
	|-Task<Nullable<Item>>.get_ResultOnSuccess
	|
	|-RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<Nullable<Int32Enum>>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	*/

	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A91770 Offset: 0x1A8FD70 VA: 0x181A91770
	|-Task<PublishResult>.GetResultCore
	|-Task<Nullable<Image>>.GetResultCore
	|
	|-RVA: 0x1A412B0 Offset: 0x1A3F8B0 VA: 0x181A412B0
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x1A91AA0 Offset: 0x1A900A0 VA: 0x181A91AA0
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x1A91A10 Offset: 0x1A90010 VA: 0x181A91A10
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-RVA: 0x1A91930 Offset: 0x1A8FF30 VA: 0x181A91930
	|-Task<Nullable<ServerInfo>>.GetResultCore
	|
	|-RVA: 0x1A91810 Offset: 0x1A8FE10 VA: 0x181A91810
	|-Task<Nullable<InventoryPurchaseResult>>.GetResultCore
	|-Task<Nullable<ResultPage>>.GetResultCore
	|
	|-RVA: 0x1A918A0 Offset: 0x1A8FEA0 VA: 0x181A918A0
	|-Task<Nullable<InventoryResult>>.GetResultCore
	|
	|-RVA: 0x1A91B10 Offset: 0x1A90110 VA: 0x181A91B10
	|-Task<Nullable<Item>>.GetResultCore
	|
	|-RVA: 0x1A41330 Offset: 0x1A3F930 VA: 0x181A41330
	|-Task<Nullable<int>>.GetResultCore
	|-Task<Nullable<Int32Enum>>.GetResultCore
	|-Task<object>.GetResultCore
	*/

	internal bool TrySetException(object exceptionObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41FE0 Offset: 0x1A405E0 VA: 0x181A41FE0
	|-Task<PublishResult>.TrySetException
	|-Task<bool>.TrySetException
	|-Task<int>.TrySetException
	|-Task<UdpReceiveResult>.TrySetException
	|-Task<Nullable<ServerInfo>>.TrySetException
	|-Task<Nullable<Image>>.TrySetException
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetException
	|-Task<Nullable<InventoryResult>>.TrySetException
	|-Task<Nullable<Item>>.TrySetException
	|-Task<Nullable<ResultPage>>.TrySetException
	|-Task<Nullable<int>>.TrySetException
	|-Task<Nullable<Int32Enum>>.TrySetException
	|-Task<object>.TrySetException
	|-Task<VoidTaskResult>.TrySetException
	*/

	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41F30 Offset: 0x1A40530 VA: 0x181A41F30
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41F60 Offset: 0x1A40560 VA: 0x181A41F60
	|-Task<PublishResult>.TrySetCanceled
	|-Task<bool>.TrySetCanceled
	|-Task<int>.TrySetCanceled
	|-Task<UdpReceiveResult>.TrySetCanceled
	|-Task<Nullable<ServerInfo>>.TrySetCanceled
	|-Task<Nullable<Image>>.TrySetCanceled
	|-Task<Nullable<InventoryPurchaseResult>>.TrySetCanceled
	|-Task<Nullable<InventoryResult>>.TrySetCanceled
	|-Task<Nullable<Item>>.TrySetCanceled
	|-Task<Nullable<ResultPage>>.TrySetCanceled
	|-Task<Nullable<int>>.TrySetCanceled
	|-Task<Nullable<Int32Enum>>.TrySetCanceled
	|-Task<object>.TrySetCanceled
	|-Task<VoidTaskResult>.TrySetCanceled
	*/

	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1182790 Offset: 0x1180D90 VA: 0x181182790
	|-Task<Stream>.get_Factory
	|-Task<int>.get_Factory
	|-Task<UdpReceiveResult>.get_Factory
	|-Task<WebResponse>.get_Factory
	|-Task<PublishResult>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<Nullable<ServerInfo>>.get_Factory
	|-Task<Nullable<Image>>.get_Factory
	|-Task<Nullable<InventoryPurchaseResult>>.get_Factory
	|-Task<Nullable<InventoryResult>>.get_Factory
	|-Task<Nullable<Item>>.get_Factory
	|-Task<Nullable<ResultPage>>.get_Factory
	|-Task<Nullable<int>>.get_Factory
	|-Task<Nullable<Int32Enum>>.get_Factory
	|-Task<object>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A923C0 Offset: 0x1A909C0 VA: 0x181A923C0
	|-Task<PublishResult>.InnerInvoke
	|
	|-RVA: 0x1A41560 Offset: 0x1A3FB60 VA: 0x181A41560
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1A91EE0 Offset: 0x1A904E0 VA: 0x181A91EE0
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x1A922D0 Offset: 0x1A908D0 VA: 0x181A922D0
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-RVA: 0x1A920A0 Offset: 0x1A906A0 VA: 0x181A920A0
	|-Task<Nullable<ServerInfo>>.InnerInvoke
	|
	|-RVA: 0x1A91C20 Offset: 0x1A90220 VA: 0x181A91C20
	|-Task<Nullable<Image>>.InnerInvoke
	|
	|-RVA: 0x1A91FB0 Offset: 0x1A905B0 VA: 0x181A91FB0
	|-Task<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-Task<Nullable<ResultPage>>.InnerInvoke
	|
	|-RVA: 0x1A921E0 Offset: 0x1A907E0 VA: 0x181A921E0
	|-Task<Nullable<InventoryResult>>.InnerInvoke
	|
	|-RVA: 0x1A91D10 Offset: 0x1A90310 VA: 0x181A91D10
	|-Task<Nullable<Item>>.InnerInvoke
	|
	|-RVA: 0x1A413B0 Offset: 0x1A3F9B0 VA: 0x181A413B0
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<Nullable<Int32Enum>>.InnerInvoke
	|
	|-RVA: 0x1A41480 Offset: 0x1A3FA80 VA: 0x181A41480
	|-Task<object>.InnerInvoke
	|-Task<Task>.InnerInvoke
	*/

	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41280 Offset: 0x1A3F880 VA: 0x181A41280
	|-Task<CompanionSubscription.Status>.GetAwaiter
	|-Task<IAuthTicket>.GetAwaiter
	|-Task<IPlayerInfo>.GetAwaiter
	|-Task<IPlayerInventory>.GetAwaiter
	|-Task<IPlayerInventory[]>.GetAwaiter
	|-Task<MP3Stream>.GetAwaiter
	|-Task<SteamInventoryCrafting.MarketPrice>.GetAwaiter
	|-Task<AuthTicket>.GetAwaiter
	|-Task<InventoryDef[]>.GetAwaiter
	|-Task<PublishResult>.GetAwaiter
	|-Task<byte[]>.GetAwaiter
	|-Task<Dictionary<string, string>>.GetAwaiter
	|-Task<List<IPlayerItemDefinition>>.GetAwaiter
	|-Task<Stream>.GetAwaiter
	|-Task<HttpResponseMessage>.GetAwaiter
	|-Task<UdpReceiveResult>.GetAwaiter
	|-Task<Nullable<ServerInfo>>.GetAwaiter
	|-Task<Nullable<Image>>.GetAwaiter
	|-Task<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-Task<Nullable<InventoryResult>>.GetAwaiter
	|-Task<Nullable<Item>>.GetAwaiter
	|-Task<Nullable<ResultPage>>.GetAwaiter
	|-Task<string>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<Nullable<Int32Enum>>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	*/

	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A40670 Offset: 0x1A3EC70 VA: 0x181A40670
	|-Task<AsyncProtocolResult>.ConfigureAwait
	|-Task<Stream>.ConfigureAwait
	|-Task<HttpResponseMessage>.ConfigureAwait
	|-Task<WebResponse>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<string>.ConfigureAwait
	|-Task<PublishResult>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<UdpReceiveResult>.ConfigureAwait
	|-Task<Nullable<ServerInfo>>.ConfigureAwait
	|-Task<Nullable<Image>>.ConfigureAwait
	|-Task<Nullable<InventoryPurchaseResult>>.ConfigureAwait
	|-Task<Nullable<InventoryResult>>.ConfigureAwait
	|-Task<Nullable<Item>>.ConfigureAwait
	|-Task<Nullable<ResultPage>>.ConfigureAwait
	|-Task<Nullable<Int32Enum>>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<Task>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	*/

	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A40D30 Offset: 0x1A3F330 VA: 0x181A40D30
	|-Task<ISocket>.ContinueWith
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A8FEA0 Offset: 0x1A8E4A0 VA: 0x181A8FEA0
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A90580 Offset: 0x1A8EB80 VA: 0x181A90580
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A904C0 Offset: 0x1A8EAC0 VA: 0x181A904C0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A8FF60 Offset: 0x1A8E560 VA: 0x181A8FF60
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A90400 Offset: 0x1A8EA00 VA: 0x181A90400
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A8F810 Offset: 0x1A8DE10 VA: 0x181A8F810
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A90EC0 Offset: 0x1A8F4C0 VA: 0x181A90EC0
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A90C10 Offset: 0x1A8F210 VA: 0x181A90C10
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A91170 Offset: 0x1A8F770 VA: 0x181A91170
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A8F750 Offset: 0x1A8DD50 VA: 0x181A8F750
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A40FE0 Offset: 0x1A3F5E0 VA: 0x181A40FE0
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A40A80 Offset: 0x1A3F080 VA: 0x181A40A80
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A410A0 Offset: 0x1A3F6A0 VA: 0x181A410A0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A90640 Offset: 0x1A8EC40 VA: 0x181A90640
	|-Task<PublishResult>.ContinueWith
	|
	|-RVA: 0x1A90F80 Offset: 0x1A8F580 VA: 0x181A90F80
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1A8FCB0 Offset: 0x1A8E2B0 VA: 0x181A8FCB0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1A8FAC0 Offset: 0x1A8E0C0 VA: 0x181A8FAC0
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0x1A90020 Offset: 0x1A8E620 VA: 0x181A90020
	|-Task<Nullable<ServerInfo>>.ContinueWith
	|
	|-RVA: 0x1A8F8D0 Offset: 0x1A8DED0 VA: 0x181A8F8D0
	|-Task<Nullable<Image>>.ContinueWith
	|
	|-RVA: 0x1A90210 Offset: 0x1A8E810 VA: 0x181A90210
	|-Task<Nullable<InventoryPurchaseResult>>.ContinueWith
	|
	|-RVA: 0x1A90A20 Offset: 0x1A8F020 VA: 0x181A90A20
	|-Task<Nullable<InventoryResult>>.ContinueWith
	|
	|-RVA: 0x1A90CD0 Offset: 0x1A8F2D0 VA: 0x181A90CD0
	|-Task<Nullable<Item>>.ContinueWith
	|
	|-RVA: 0x1A90830 Offset: 0x1A8EE30 VA: 0x181A90830
	|-Task<Nullable<ResultPage>>.ContinueWith
	|
	|-RVA: 0x1A40B40 Offset: 0x1A3F140 VA: 0x181A40B40
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1A406A0 Offset: 0x1A3ECA0 VA: 0x181A406A0
	|-Task<Nullable<Int32Enum>>.ContinueWith
	|
	|-RVA: 0x1A40890 Offset: 0x1A3EE90 VA: 0x181A40890
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1A40DF0 Offset: 0x1A3F3F0 VA: 0x181A40DF0
	|-Task<VoidTaskResult>.ContinueWith
	*/

	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9DF0 Offset: 0xED83F0 VA: 0x180ED9DF0
	|-Task<Dictionary<string, string>>.ContinueWith<Task<Dictionary<string, string>>>
	|-Task<object>.ContinueWith<object>
	*/

	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9EA0 Offset: 0xED84A0 VA: 0x180ED9EA0
	|-Task<object>.ContinueWith<object>
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A42280 Offset: 0x1A40880 VA: 0x181A42280
	|-Task<PublishResult>..cctor
	|-Task<bool>..cctor
	|-Task<int>..cctor
	|-Task<UdpReceiveResult>..cctor
	|-Task<Nullable<ServerInfo>>..cctor
	|-Task<Nullable<Image>>..cctor
	|-Task<Nullable<InventoryPurchaseResult>>..cctor
	|-Task<Nullable<InventoryResult>>..cctor
	|-Task<Nullable<Item>>..cctor
	|-Task<Nullable<ResultPage>>..cctor
	|-Task<Nullable<int>>..cctor
	|-Task<Nullable<Int32Enum>>..cctor
	|-Task<object>..cctor
	|-Task<VoidTaskResult>..cctor
	*/

}

public class TaskFactory<TResult> // TypeDefIndex: 845
{
public class TaskFactory<TResult> // TypeDefIndex: 845
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8F710 Offset: 0x1A8DD10 VA: 0x181A8F710
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8F690 Offset: 0x1A8DC90 VA: 0x181A8F690
	|-TaskFactory<PublishResult>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<Nullable<ServerInfo>>..ctor
	|-TaskFactory<Nullable<Image>>..ctor
	|-TaskFactory<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskFactory<Nullable<InventoryResult>>..ctor
	|-TaskFactory<Nullable<Item>>..ctor
	|-TaskFactory<Nullable<ResultPage>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<Int32Enum>>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	*/

	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8F150 Offset: 0x1A8D750 VA: 0x181A8F150
	|-TaskFactory<PublishResult>.StartNew
	|
	|-RVA: 0x1A8EAC0 Offset: 0x1A8D0C0 VA: 0x181A8EAC0
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1A8E970 Offset: 0x1A8CF70 VA: 0x181A8E970
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x1A8E6D0 Offset: 0x1A8CCD0 VA: 0x181A8E6D0
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0x1A8F2A0 Offset: 0x1A8D8A0 VA: 0x181A8F2A0
	|-TaskFactory<Nullable<ServerInfo>>.StartNew
	|
	|-RVA: 0x1A8F3F0 Offset: 0x1A8D9F0 VA: 0x181A8F3F0
	|-TaskFactory<Nullable<Image>>.StartNew
	|
	|-RVA: 0x1A8E580 Offset: 0x1A8CB80 VA: 0x181A8E580
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.StartNew
	|
	|-RVA: 0x1A8F000 Offset: 0x1A8D600 VA: 0x181A8F000
	|-TaskFactory<Nullable<InventoryResult>>.StartNew
	|
	|-RVA: 0x1A8EEB0 Offset: 0x1A8D4B0 VA: 0x181A8EEB0
	|-TaskFactory<Nullable<Item>>.StartNew
	|
	|-RVA: 0x1A8E820 Offset: 0x1A8CE20 VA: 0x181A8E820
	|-TaskFactory<Nullable<ResultPage>>.StartNew
	|
	|-RVA: 0x1A8ED60 Offset: 0x1A8D360 VA: 0x181A8ED60
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x1A8EC10 Offset: 0x1A8D210 VA: 0x181A8EC10
	|-TaskFactory<Nullable<Int32Enum>>.StartNew
	|
	|-RVA: 0x1A8E430 Offset: 0x1A8CA30 VA: 0x181A8E430
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x1A8F540 Offset: 0x1A8DB40 VA: 0x181A8F540
	|-TaskFactory<VoidTaskResult>.StartNew
	*/

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A846C0 Offset: 0x1A82CC0 VA: 0x181A846C0
	|-TaskFactory<PublishResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A85A30 Offset: 0x1A84030 VA: 0x181A85A30
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A85040 Offset: 0x1A83640 VA: 0x181A85040
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A85EC0 Offset: 0x1A844C0 VA: 0x181A85EC0
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A854D0 Offset: 0x1A83AD0 VA: 0x181A854D0
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A84B80 Offset: 0x1A83180 VA: 0x181A84B80
	|-TaskFactory<Nullable<Image>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A87BA0 Offset: 0x1A861A0 VA: 0x181A87BA0
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A86C80 Offset: 0x1A85280 VA: 0x181A86C80
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A87120 Offset: 0x1A85720 VA: 0x181A87120
	|-TaskFactory<Nullable<Item>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A86360 Offset: 0x1A84960 VA: 0x181A86360
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A87730 Offset: 0x1A85D30 VA: 0x181A87730
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A86810 Offset: 0x1A84E10 VA: 0x181A86810
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A83DC0 Offset: 0x1A823C0 VA: 0x181A83DC0
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1A84250 Offset: 0x1A82850 VA: 0x181A84250
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	*/

	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A8E3E0 Offset: 0x1A8C9E0 VA: 0x181A8E3E0
	|-TaskFactory<Stream>.FromAsync
	|-TaskFactory<UdpReceiveResult>.FromAsync
	|-TaskFactory<WebResponse>.FromAsync
	|-TaskFactory<PublishResult>.FromAsync
	|-TaskFactory<bool>.FromAsync
	|-TaskFactory<int>.FromAsync
	|-TaskFactory<Nullable<ServerInfo>>.FromAsync
	|-TaskFactory<Nullable<Image>>.FromAsync
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsync
	|-TaskFactory<Nullable<InventoryResult>>.FromAsync
	|-TaskFactory<Nullable<Item>>.FromAsync
	|-TaskFactory<Nullable<ResultPage>>.FromAsync
	|-TaskFactory<Nullable<int>>.FromAsync
	|-TaskFactory<Nullable<Int32Enum>>.FromAsync
	|-TaskFactory<object>.FromAsync
	|-TaskFactory<VoidTaskResult>.FromAsync
	*/

	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A89590 Offset: 0x1A87B90 VA: 0x181A89590
	|-TaskFactory<PublishResult>.FromAsyncImpl
	|
	|-RVA: 0x1A8DCF0 Offset: 0x1A8C2F0 VA: 0x181A8DCF0
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1A8B310 Offset: 0x1A89910 VA: 0x181A8B310
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x1A8D5F0 Offset: 0x1A8BBF0 VA: 0x181A8D5F0
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0x1A8AB90 Offset: 0x1A89190 VA: 0x181A8AB90
	|-TaskFactory<Nullable<ServerInfo>>.FromAsyncImpl
	|
	|-RVA: 0x1A88050 Offset: 0x1A86650 VA: 0x181A88050
	|-TaskFactory<Nullable<Image>>.FromAsyncImpl
	|
	|-RVA: 0x1A8C0F0 Offset: 0x1A8A6F0 VA: 0x181A8C0F0
	|-TaskFactory<Nullable<InventoryPurchaseResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A89CC0 Offset: 0x1A882C0 VA: 0x181A89CC0
	|-TaskFactory<Nullable<InventoryResult>>.FromAsyncImpl
	|
	|-RVA: 0x1A8A3E0 Offset: 0x1A889E0 VA: 0x181A8A3E0
	|-TaskFactory<Nullable<Item>>.FromAsyncImpl
	|
	|-RVA: 0x1A88E70 Offset: 0x1A87470 VA: 0x181A88E70
	|-TaskFactory<Nullable<ResultPage>>.FromAsyncImpl
	|
	|-RVA: 0x1A8BA00 Offset: 0x1A8A000 VA: 0x181A8BA00
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x1A8C810 Offset: 0x1A8AE10 VA: 0x181A8C810
	|-TaskFactory<Nullable<Int32Enum>>.FromAsyncImpl
	|
	|-RVA: 0x1A88780 Offset: 0x1A86D80 VA: 0x181A88780
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x1A8CF00 Offset: 0x1A8B500 VA: 0x181A8CF00
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	*/

	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B450 Offset: 0x1579A50 VA: 0x18157B450
	|-TaskFactory<int>.FromAsync<byte[], int>
	|-TaskFactory<int>.FromAsync<object, int>
	|
	|-RVA: 0x157B4B0 Offset: 0x1579AB0 VA: 0x18157B4B0
	|-TaskFactory<object>.FromAsync<object, object>
	*/

	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157A2C0 Offset: 0x15788C0 VA: 0x18157A2C0
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x157A900 Offset: 0x1578F00 VA: 0x18157A900
	|-TaskFactory<object>.FromAsyncImpl<object, object>
	*/

	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AF40 Offset: 0x1579540 VA: 0x18157AF40
	|-TaskFactory<int>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x157B2A0 Offset: 0x15798A0 VA: 0x18157B2A0
	|-TaskFactory<object>.FromAsyncTrim<object, object>
	|
	|-RVA: 0x157B0F0 Offset: 0x15796F0 VA: 0x18157B0F0
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<Stream, Stream.ReadWriteParameters>
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	*/

}

internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 868
{	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0


	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4D340 Offset: 0x1A4B940 VA: 0x181A4D340
	|-UnwrapPromise<object>..ctor
	*/

	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4CCA0 Offset: 0x1A4B2A0 VA: 0x181A4CCA0
	|-UnwrapPromise<object>.Invoke
	*/

	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4CC40 Offset: 0x1A4B240 VA: 0x181A4CC40
	|-UnwrapPromise<object>.InvokeCore
	*/

	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4CA00 Offset: 0x1A4B000 VA: 0x181A4CA00
	|-UnwrapPromise<object>.InvokeCoreAsync
	*/

	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4CE10 Offset: 0x1A4B410 VA: 0x181A4CE10
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	*/

	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4D070 Offset: 0x1A4B670 VA: 0x181A4D070
	|-UnwrapPromise<object>.TrySetFromTask
	*/

	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A4CFC0 Offset: 0x1A4B5C0 VA: 0x181A4CFC0
	|-UnwrapPromise<object>.ProcessInnerTask
	*/

}

public class TaskCompletionSource<TResult> // TypeDefIndex: 871
{	private readonly Task<TResult> m_task; // 0x0

	public Task<TResult> Task { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368930 Offset: 0x1366F30 VA: 0x181368930
	|-TaskCompletionSource<HttpResponseMessage>..ctor
	|-TaskCompletionSource<object>..ctor
	*/

	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-TaskCompletionSource<HttpResponseMessage>.get_Task
	|-TaskCompletionSource<object>.get_Task
	*/

	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368820 Offset: 0x1366E20 VA: 0x181368820
	|-TaskCompletionSource<object>.SpinUntilCompleted
	*/

	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368900 Offset: 0x1366F00 VA: 0x181368900
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368880 Offset: 0x1366E80 VA: 0x181368880
	|-TaskCompletionSource<object>.TrySetCanceled
	*/

	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368780 Offset: 0x1366D80 VA: 0x181368780
	|-TaskCompletionSource<HttpResponseMessage>.SetCanceled
	|-TaskCompletionSource<object>.SetCanceled
	*/

}

internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 873
{	private Task<TAntecedentResult> m_antecedent; // 0x0


	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364320 Offset: 0x1362920 VA: 0x181364320
	|-ContinuationTaskFromResultTask<PublishResult>..ctor
	|
	|-RVA: 0x13648C0 Offset: 0x1362EC0 VA: 0x1813648C0
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x13646E0 Offset: 0x1362CE0 VA: 0x1813646E0
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x1364410 Offset: 0x1362A10 VA: 0x181364410
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-RVA: 0x13645F0 Offset: 0x1362BF0 VA: 0x1813645F0
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>..ctor
	|
	|-RVA: 0x13647D0 Offset: 0x1362DD0 VA: 0x1813647D0
	|-ContinuationTaskFromResultTask<Nullable<Image>>..ctor
	|
	|-RVA: 0x1364230 Offset: 0x1362830 VA: 0x181364230
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>..ctor
	|
	|-RVA: 0x1363F60 Offset: 0x1362560 VA: 0x181363F60
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>..ctor
	|
	|-RVA: 0x1364050 Offset: 0x1362650 VA: 0x181364050
	|-ContinuationTaskFromResultTask<Nullable<Item>>..ctor
	|
	|-RVA: 0x13649B0 Offset: 0x1362FB0 VA: 0x1813649B0
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>..ctor
	|
	|-RVA: 0x1364140 Offset: 0x1362740 VA: 0x181364140
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x1363D80 Offset: 0x1362380 VA: 0x181363D80
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>..ctor
	|
	|-RVA: 0x1363E70 Offset: 0x1362470 VA: 0x181363E70
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x1364500 Offset: 0x1362B00 VA: 0x181364500
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363C70 Offset: 0x1362270 VA: 0x181363C70
	|-ContinuationTaskFromResultTask<PublishResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|-ContinuationTaskFromResultTask<UdpReceiveResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ServerInfo>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Image>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryPurchaseResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<InventoryResult>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Item>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<ResultPage>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<Int32Enum>>.InnerInvoke
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	*/

}

internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 874
{	private Task<TAntecedentResult> m_antecedent; // 0x0


	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1363AE0 Offset: 0x13620E0 VA: 0x181363AE0
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	*/

	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13639C0 Offset: 0x1361FC0 VA: 0x1813639C0
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	*/

}

internal sealed class __BinaryWriter // TypeDefIndex: 1105
{	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8


	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	internal void WriteBegin() { }

	internal void WriteEnd() { }

	internal void WriteBoolean(bool value) { }

	internal void WriteByte(byte value) { }

	private void WriteBytes(byte[] value) { }

	private void WriteBytes(byte[] byteA, int offset, int size) { }

	internal void WriteChar(char value) { }

	internal void WriteChars(char[] value) { }

	internal void WriteDecimal(Decimal value) { }

	internal void WriteSingle(float value) { }

	internal void WriteDouble(double value) { }

	internal void WriteInt16(short value) { }

	internal void WriteInt32(int value) { }

	internal void WriteInt64(long value) { }

	internal void WriteSByte(sbyte value) { }

	internal void WriteString(string value) { }

	internal void WriteTimeSpan(TimeSpan value) { }

	internal void WriteDateTime(DateTime value) { }

	internal void WriteUInt16(ushort value) { }

	internal void WriteUInt32(uint value) { }

	internal void WriteUInt64(ulong value) { }

	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteSerializationHeaderEnd() { }

	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	internal void WriteMethodCall() { }

	internal void WriteMethodReturn() { }

	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	internal void WriteObjectString(int objectId, string value) { }

	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	private void WriteArrayAsBytes(Array array, int typeLength) { }

	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	internal void WriteDelayedNullItem() { }

	internal void WriteItemEnd() { }

	private void InternalWriteItemNull() { }

	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}

internal sealed class __BinaryParser // TypeDefIndex: 1116
{	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }


	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	internal SizedArray get_ObjectMapIdTable() { }

	internal SizedArray get_AssemIdToAssemblyTable() { }

	internal ParseRecord get_prs() { }

	internal void Run() { }

	internal void ReadBegin() { }

	internal void ReadEnd() { }

	internal bool ReadBoolean() { }

	internal byte ReadByte() { }

	internal byte[] ReadBytes(int length) { }

	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	internal char ReadChar() { }

	internal char[] ReadChars(int length) { }

	internal Decimal ReadDecimal() { }

	internal float ReadSingle() { }

	internal double ReadDouble() { }

	internal short ReadInt16() { }

	internal int ReadInt32() { }

	internal long ReadInt64() { }

	internal sbyte ReadSByte() { }

	internal string ReadString() { }

	internal TimeSpan ReadTimeSpan() { }

	internal DateTime ReadDateTime() { }

	internal ushort ReadUInt16() { }

	internal uint ReadUInt32() { }

	internal ulong ReadUInt64() { }

	internal void ReadSerializationHeaderRecord() { }

	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObject() { }

	internal void ReadCrossAppDomainMap() { }

	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadMemberPrimitiveTyped() { }

	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadArrayAsBytes(ParseRecord pr) { }

	private void ReadMemberPrimitiveUnTyped() { }

	private void ReadMemberReference() { }

	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadMessageEnd() { }

	internal object ReadValue(InternalPrimitiveTypeE code) { }

	private ObjectProgress GetOp() { }

	private void PutOp(ObjectProgress op) { }

	private static void .cctor() { }

}

public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1291
{	private readonly Task<TResult> m_task; // 0x0

	public bool IsCompleted { get; }


	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	|-TaskAwaiter<PublishResult>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<UdpReceiveResult>..ctor
	|-TaskAwaiter<Nullable<ServerInfo>>..ctor
	|-TaskAwaiter<Nullable<Image>>..ctor
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>..ctor
	|-TaskAwaiter<Nullable<InventoryResult>>..ctor
	|-TaskAwaiter<Nullable<Item>>..ctor
	|-TaskAwaiter<Nullable<ResultPage>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<Nullable<Int32Enum>>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BEE0 Offset: 0x14B2E0 VA: 0x18014BEE0
	|-TaskAwaiter<CompanionSubscription.Status>.get_IsCompleted
	|-TaskAwaiter<IAuthTicket>.get_IsCompleted
	|-TaskAwaiter<IPlayerInfo>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory>.get_IsCompleted
	|-TaskAwaiter<IPlayerInventory[]>.get_IsCompleted
	|-TaskAwaiter<MP3Stream>.get_IsCompleted
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.get_IsCompleted
	|-TaskAwaiter<AuthTicket>.get_IsCompleted
	|-TaskAwaiter<InventoryDef[]>.get_IsCompleted
	|-TaskAwaiter<PublishResult>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<byte[]>.get_IsCompleted
	|-TaskAwaiter<Dictionary<string, string>>.get_IsCompleted
	|-TaskAwaiter<List<IPlayerItemDefinition>>.get_IsCompleted
	|-TaskAwaiter<Stream>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<HttpResponseMessage>.get_IsCompleted
	|-TaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Image>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Item>>.get_IsCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<string>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C820 Offset: 0x14BC20 VA: 0x18014C820
	|-TaskAwaiter<PublishResult>.OnCompleted
	|-TaskAwaiter<bool>.OnCompleted
	|-TaskAwaiter<int>.OnCompleted
	|-TaskAwaiter<UdpReceiveResult>.OnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.OnCompleted
	|-TaskAwaiter<Nullable<Image>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.OnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.OnCompleted
	|-TaskAwaiter<Nullable<Item>>.OnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.OnCompleted
	|-TaskAwaiter<Nullable<int>>.OnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.OnCompleted
	|-TaskAwaiter<object>.OnCompleted
	|-TaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C850 Offset: 0x14BC50 VA: 0x18014C850
	|-TaskAwaiter<PublishResult>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ServerInfo>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Image>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<InventoryResult>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Item>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<ResultPage>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<Int32Enum>>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4080 Offset: 0x1E3480 VA: 0x1801E4080
	|-TaskAwaiter<CompanionSubscription.Status>.GetResult
	|-TaskAwaiter<IAuthTicket>.GetResult
	|-TaskAwaiter<IPlayerInfo>.GetResult
	|-TaskAwaiter<IPlayerInventory>.GetResult
	|-TaskAwaiter<IPlayerInventory[]>.GetResult
	|-TaskAwaiter<MP3Stream>.GetResult
	|-TaskAwaiter<SteamInventoryCrafting.MarketPrice>.GetResult
	|-TaskAwaiter<AuthTicket>.GetResult
	|-TaskAwaiter<InventoryDef[]>.GetResult
	|-TaskAwaiter<byte[]>.GetResult
	|-TaskAwaiter<Dictionary<string, string>>.GetResult
	|-TaskAwaiter<List<IPlayerItemDefinition>>.GetResult
	|-TaskAwaiter<Stream>.GetResult
	|-TaskAwaiter<HttpResponseMessage>.GetResult
	|-TaskAwaiter<string>.GetResult
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1E3330 Offset: 0x1E2730 VA: 0x1801E3330
	|-TaskAwaiter<PublishResult>.GetResult
	|-TaskAwaiter<Nullable<Image>>.GetResult
	|
	|-RVA: 0x1E34B0 Offset: 0x1E28B0 VA: 0x1801E34B0
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0x1E3560 Offset: 0x1E2960 VA: 0x1801E3560
	|-TaskAwaiter<Nullable<ServerInfo>>.GetResult
	|
	|-RVA: 0x1E33F0 Offset: 0x1E27F0 VA: 0x1801E33F0
	|-TaskAwaiter<Nullable<InventoryPurchaseResult>>.GetResult
	|-TaskAwaiter<Nullable<ResultPage>>.GetResult
	|
	|-RVA: 0x1E37A0 Offset: 0x1E2BA0 VA: 0x1801E37A0
	|-TaskAwaiter<Nullable<InventoryResult>>.GetResult
	|
	|-RVA: 0x1E3660 Offset: 0x1E2A60 VA: 0x1801E3660
	|-TaskAwaiter<Nullable<Item>>.GetResult
	|
	|-RVA: 0x1E4070 Offset: 0x1E3470 VA: 0x1801E4070
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E32A0 Offset: 0x1E26A0 VA: 0x1801E32A0
	|-TaskAwaiter<int>.GetResult
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<Nullable<Int32Enum>>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	*/

}

public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1294
{	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0


	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3230 Offset: 0x1E2630 VA: 0x1801E3230
	|-ConfiguredTaskAwaitable<PublishResult>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Image>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Item>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	*/

	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B590 Offset: 0x14A990 VA: 0x18014B590
	|-ConfiguredTaskAwaitable<AsyncProtocolResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Stream>.GetAwaiter
	|-ConfiguredTaskAwaitable<HttpResponseMessage>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebResponse>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<string>.GetAwaiter
	|-ConfiguredTaskAwaitable<PublishResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<UdpReceiveResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ServerInfo>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Image>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryPurchaseResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<InventoryResult>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Item>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<ResultPage>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<Int32Enum>>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<Task>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	*/

}

internal struct ConcurrentSet<KeyType, ItemType> // TypeDefIndex: 1507
{	private ItemType[] items; // 0x0


	public ItemType TryGet(KeyType key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B470 Offset: 0x22A870 VA: 0x18022B470
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.TryGet
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.TryGet
	|
	|-RVA: 0x22B530 Offset: 0x22A930 VA: 0x18022B530
	|-ConcurrentSet<object, object>.TryGet
	*/

	public ItemType GetOrAdd(ItemType newItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B460 Offset: 0x22A860 VA: 0x18022B460
	|-ConcurrentSet<KeyValuePair<object, Int32Enum>, object>.GetOrAdd
	|-ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo>.GetOrAdd
	|-ConcurrentSet<object, object>.GetOrAdd
	*/

}

internal abstract class ConcurrentSetItem<KeyType, ItemType> // TypeDefIndex: 1508
{
	public abstract int Compare(ItemType other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	public abstract int Compare(KeyType key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcurrentSetItem<object, object>.Compare
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-ConcurrentSetItem<KeyValuePair<object, Int32Enum>, object>..ctor
	|-ConcurrentSetItem<KeyValuePair<string, EventTags>, NameInfo>..ctor
	|-ConcurrentSetItem<object, object>..ctor
	*/

}

internal sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType> // TypeDefIndex: 1524
{	private readonly PropertyAnalysis[] properties; // 0x0
	private readonly PropertyAccessor<ContainerType>[] accessors; // 0x0


	public void .ctor(TypeAnalysis typeAnalysis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B528C0 Offset: 0x1B50EC0 VA: 0x181B528C0
	|-InvokeTypeInfo<bool>..ctor
	|-InvokeTypeInfo<byte>..ctor
	|-InvokeTypeInfo<char>..ctor
	|-InvokeTypeInfo<KeyValuePair<object, object>>..ctor
	|-InvokeTypeInfo<DateTime>..ctor
	|-InvokeTypeInfo<DateTimeOffset>..ctor
	|-InvokeTypeInfo<Decimal>..ctor
	|-InvokeTypeInfo<EmptyStruct>..ctor
	|-InvokeTypeInfo<double>..ctor
	|-InvokeTypeInfo<Guid>..ctor
	|-InvokeTypeInfo<short>..ctor
	|-InvokeTypeInfo<int>..ctor
	|-InvokeTypeInfo<long>..ctor
	|-InvokeTypeInfo<IntPtr>..ctor
	|-InvokeTypeInfo<object>..ctor
	|-InvokeTypeInfo<sbyte>..ctor
	|-InvokeTypeInfo<float>..ctor
	|-InvokeTypeInfo<TimeSpan>..ctor
	|-InvokeTypeInfo<ushort>..ctor
	|-InvokeTypeInfo<uint>..ctor
	|-InvokeTypeInfo<ulong>..ctor
	|-InvokeTypeInfo<UIntPtr>..ctor
	*/

	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52280 Offset: 0x1B50880 VA: 0x181B52280
	|-InvokeTypeInfo<bool>.WriteMetadata
	|-InvokeTypeInfo<byte>.WriteMetadata
	|-InvokeTypeInfo<char>.WriteMetadata
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteMetadata
	|-InvokeTypeInfo<DateTime>.WriteMetadata
	|-InvokeTypeInfo<DateTimeOffset>.WriteMetadata
	|-InvokeTypeInfo<Decimal>.WriteMetadata
	|-InvokeTypeInfo<EmptyStruct>.WriteMetadata
	|-InvokeTypeInfo<double>.WriteMetadata
	|-InvokeTypeInfo<Guid>.WriteMetadata
	|-InvokeTypeInfo<short>.WriteMetadata
	|-InvokeTypeInfo<int>.WriteMetadata
	|-InvokeTypeInfo<long>.WriteMetadata
	|-InvokeTypeInfo<IntPtr>.WriteMetadata
	|-InvokeTypeInfo<object>.WriteMetadata
	|-InvokeTypeInfo<sbyte>.WriteMetadata
	|-InvokeTypeInfo<float>.WriteMetadata
	|-InvokeTypeInfo<TimeSpan>.WriteMetadata
	|-InvokeTypeInfo<ushort>.WriteMetadata
	|-InvokeTypeInfo<uint>.WriteMetadata
	|-InvokeTypeInfo<ulong>.WriteMetadata
	|-InvokeTypeInfo<UIntPtr>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B521F0 Offset: 0x1B507F0 VA: 0x181B521F0
	|-InvokeTypeInfo<bool>.WriteData
	|-InvokeTypeInfo<byte>.WriteData
	|-InvokeTypeInfo<char>.WriteData
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteData
	|-InvokeTypeInfo<DateTime>.WriteData
	|-InvokeTypeInfo<DateTimeOffset>.WriteData
	|-InvokeTypeInfo<Decimal>.WriteData
	|-InvokeTypeInfo<EmptyStruct>.WriteData
	|-InvokeTypeInfo<double>.WriteData
	|-InvokeTypeInfo<Guid>.WriteData
	|-InvokeTypeInfo<short>.WriteData
	|-InvokeTypeInfo<int>.WriteData
	|-InvokeTypeInfo<long>.WriteData
	|-InvokeTypeInfo<IntPtr>.WriteData
	|-InvokeTypeInfo<object>.WriteData
	|-InvokeTypeInfo<sbyte>.WriteData
	|-InvokeTypeInfo<float>.WriteData
	|-InvokeTypeInfo<TimeSpan>.WriteData
	|-InvokeTypeInfo<ushort>.WriteData
	|-InvokeTypeInfo<uint>.WriteData
	|-InvokeTypeInfo<ulong>.WriteData
	|-InvokeTypeInfo<UIntPtr>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B503F0 Offset: 0x1B4E9F0 VA: 0x181B503F0
	|-InvokeTypeInfo<bool>.GetData
	|
	|-RVA: 0x1B51070 Offset: 0x1B4F670 VA: 0x181B51070
	|-InvokeTypeInfo<byte>.GetData
	|
	|-RVA: 0x1B4F270 Offset: 0x1B4D870 VA: 0x181B4F270
	|-InvokeTypeInfo<char>.GetData
	|
	|-RVA: 0x1B50DF0 Offset: 0x1B4F3F0 VA: 0x181B50DF0
	|-InvokeTypeInfo<KeyValuePair<object, object>>.GetData
	|
	|-RVA: 0x1B4ED70 Offset: 0x1B4D370 VA: 0x181B4ED70
	|-InvokeTypeInfo<DateTime>.GetData
	|
	|-RVA: 0x1B4FEF0 Offset: 0x1B4E4F0 VA: 0x181B4FEF0
	|-InvokeTypeInfo<DateTimeOffset>.GetData
	|
	|-RVA: 0x1B4EFF0 Offset: 0x1B4D5F0 VA: 0x181B4EFF0
	|-InvokeTypeInfo<Decimal>.GetData
	|
	|-RVA: 0x1B4F770 Offset: 0x1B4DD70 VA: 0x181B4F770
	|-InvokeTypeInfo<EmptyStruct>.GetData
	|
	|-RVA: 0x1B512F0 Offset: 0x1B4F8F0 VA: 0x181B512F0
	|-InvokeTypeInfo<double>.GetData
	|
	|-RVA: 0x1B4F9F0 Offset: 0x1B4DFF0 VA: 0x181B4F9F0
	|-InvokeTypeInfo<Guid>.GetData
	|
	|-RVA: 0x1B517F0 Offset: 0x1B4FDF0 VA: 0x181B517F0
	|-InvokeTypeInfo<short>.GetData
	|
	|-RVA: 0x1B4F4F0 Offset: 0x1B4DAF0 VA: 0x181B4F4F0
	|-InvokeTypeInfo<int>.GetData
	|
	|-RVA: 0x1B4EAF0 Offset: 0x1B4D0F0 VA: 0x181B4EAF0
	|-InvokeTypeInfo<long>.GetData
	|
	|-RVA: 0x1B50670 Offset: 0x1B4EC70 VA: 0x181B50670
	|-InvokeTypeInfo<IntPtr>.GetData
	|
	|-RVA: 0x1B51A70 Offset: 0x1B50070 VA: 0x181B51A70
	|-InvokeTypeInfo<object>.GetData
	|
	|-RVA: 0x1B4FC70 Offset: 0x1B4E270 VA: 0x181B4FC70
	|-InvokeTypeInfo<sbyte>.GetData
	|
	|-RVA: 0x1B50B70 Offset: 0x1B4F170 VA: 0x181B50B70
	|-InvokeTypeInfo<float>.GetData
	|
	|-RVA: 0x1B51F70 Offset: 0x1B50570 VA: 0x181B51F70
	|-InvokeTypeInfo<TimeSpan>.GetData
	|
	|-RVA: 0x1B50170 Offset: 0x1B4E770 VA: 0x181B50170
	|-InvokeTypeInfo<ushort>.GetData
	|
	|-RVA: 0x1B508F0 Offset: 0x1B4EEF0 VA: 0x181B508F0
	|-InvokeTypeInfo<uint>.GetData
	|
	|-RVA: 0x1B51570 Offset: 0x1B4FB70 VA: 0x181B51570
	|-InvokeTypeInfo<ulong>.GetData
	|
	|-RVA: 0x1B51CF0 Offset: 0x1B502F0 VA: 0x181B51CF0
	|-InvokeTypeInfo<UIntPtr>.GetData
	*/

	public override void WriteObjectData(TraceLoggingDataCollector collector, object valueObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B524B0 Offset: 0x1B50AB0 VA: 0x181B524B0
	|-InvokeTypeInfo<bool>.WriteObjectData
	|-InvokeTypeInfo<byte>.WriteObjectData
	|-InvokeTypeInfo<EmptyStruct>.WriteObjectData
	|-InvokeTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B526B0 Offset: 0x1B50CB0 VA: 0x181B526B0
	|-InvokeTypeInfo<char>.WriteObjectData
	|-InvokeTypeInfo<short>.WriteObjectData
	|-InvokeTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B52400 Offset: 0x1B50A00 VA: 0x181B52400
	|-InvokeTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-InvokeTypeInfo<DateTimeOffset>.WriteObjectData
	|-InvokeTypeInfo<Decimal>.WriteObjectData
	|-InvokeTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B52600 Offset: 0x1B50C00 VA: 0x181B52600
	|-InvokeTypeInfo<DateTime>.WriteObjectData
	|-InvokeTypeInfo<long>.WriteObjectData
	|-InvokeTypeInfo<IntPtr>.WriteObjectData
	|-InvokeTypeInfo<TimeSpan>.WriteObjectData
	|-InvokeTypeInfo<ulong>.WriteObjectData
	|-InvokeTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B52350 Offset: 0x1B50950 VA: 0x181B52350
	|-InvokeTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B52810 Offset: 0x1B50E10 VA: 0x181B52810
	|-InvokeTypeInfo<int>.WriteObjectData
	|-InvokeTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B52560 Offset: 0x1B50B60 VA: 0x181B52560
	|-InvokeTypeInfo<object>.WriteObjectData
	|
	|-RVA: 0x1B52760 Offset: 0x1B50D60 VA: 0x181B52760
	|-InvokeTypeInfo<float>.WriteObjectData
	*/

}

internal abstract class PropertyAccessor<ContainerType> // TypeDefIndex: 1526
{
	public abstract void Write(TraceLoggingDataCollector collector, ref ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.Write
	*/

	public abstract object GetData(ContainerType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyAccessor<object>.GetData
	*/

	public static PropertyAccessor<ContainerType> Create(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B56C00 Offset: 0x1B55200 VA: 0x181B56C00
	|-PropertyAccessor<bool>.Create
	|
	|-RVA: 0x1B54890 Offset: 0x1B52E90 VA: 0x181B54890
	|-PropertyAccessor<byte>.Create
	|
	|-RVA: 0x1B55850 Offset: 0x1B53E50 VA: 0x181B55850
	|-PropertyAccessor<char>.Create
	|
	|-RVA: 0x1B56FF0 Offset: 0x1B555F0 VA: 0x181B56FF0
	|-PropertyAccessor<KeyValuePair<object, object>>.Create
	|
	|-RVA: 0x1B58790 Offset: 0x1B56D90 VA: 0x181B58790
	|-PropertyAccessor<DateTime>.Create
	|
	|-RVA: 0x1B55070 Offset: 0x1B53670 VA: 0x181B55070
	|-PropertyAccessor<DateTimeOffset>.Create
	|
	|-RVA: 0x1B540B0 Offset: 0x1B526B0 VA: 0x181B540B0
	|-PropertyAccessor<Decimal>.Create
	|
	|-RVA: 0x1B54C80 Offset: 0x1B53280 VA: 0x181B54C80
	|-PropertyAccessor<EmptyStruct>.Create
	|
	|-RVA: 0x1B534E0 Offset: 0x1B51AE0 VA: 0x181B534E0
	|-PropertyAccessor<double>.Create
	|
	|-RVA: 0x1B57FB0 Offset: 0x1B565B0 VA: 0x181B57FB0
	|-PropertyAccessor<Guid>.Create
	|
	|-RVA: 0x1B57BC0 Offset: 0x1B561C0 VA: 0x181B57BC0
	|-PropertyAccessor<short>.Create
	|
	|-RVA: 0x1B55C40 Offset: 0x1B54240 VA: 0x181B55C40
	|-PropertyAccessor<int>.Create
	|
	|-RVA: 0x1B55460 Offset: 0x1B53A60 VA: 0x181B55460
	|-PropertyAccessor<long>.Create
	|
	|-RVA: 0x1B573E0 Offset: 0x1B559E0 VA: 0x181B573E0
	|-PropertyAccessor<IntPtr>.Create
	|
	|-RVA: 0x1B583A0 Offset: 0x1B569A0 VA: 0x181B583A0
	|-PropertyAccessor<object>.Create
	|
	|-RVA: 0x1B544A0 Offset: 0x1B52AA0 VA: 0x181B544A0
	|-PropertyAccessor<sbyte>.Create
	|
	|-RVA: 0x1B56030 Offset: 0x1B54630 VA: 0x181B56030
	|-PropertyAccessor<float>.Create
	|
	|-RVA: 0x1B56810 Offset: 0x1B54E10 VA: 0x181B56810
	|-PropertyAccessor<TimeSpan>.Create
	|
	|-RVA: 0x1B56420 Offset: 0x1B54A20 VA: 0x181B56420
	|-PropertyAccessor<ushort>.Create
	|
	|-RVA: 0x1B53CC0 Offset: 0x1B522C0 VA: 0x181B53CC0
	|-PropertyAccessor<uint>.Create
	|
	|-RVA: 0x1B538D0 Offset: 0x1B51ED0 VA: 0x181B538D0
	|-PropertyAccessor<ulong>.Create
	|
	|-RVA: 0x1B577D0 Offset: 0x1B55DD0 VA: 0x181B577D0
	|-PropertyAccessor<UIntPtr>.Create
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-PropertyAccessor<bool>..ctor
	|-PropertyAccessor<byte>..ctor
	|-PropertyAccessor<char>..ctor
	|-PropertyAccessor<KeyValuePair<object, object>>..ctor
	|-PropertyAccessor<DateTime>..ctor
	|-PropertyAccessor<DateTimeOffset>..ctor
	|-PropertyAccessor<Decimal>..ctor
	|-PropertyAccessor<EmptyStruct>..ctor
	|-PropertyAccessor<double>..ctor
	|-PropertyAccessor<Guid>..ctor
	|-PropertyAccessor<short>..ctor
	|-PropertyAccessor<int>..ctor
	|-PropertyAccessor<long>..ctor
	|-PropertyAccessor<IntPtr>..ctor
	|-PropertyAccessor<object>..ctor
	|-PropertyAccessor<sbyte>..ctor
	|-PropertyAccessor<float>..ctor
	|-PropertyAccessor<TimeSpan>..ctor
	|-PropertyAccessor<ushort>..ctor
	|-PropertyAccessor<uint>..ctor
	|-PropertyAccessor<ulong>..ctor
	|-PropertyAccessor<UIntPtr>..ctor
	*/

}

internal class NonGenericProperytWriter<ContainerType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1527
{	private readonly TraceLoggingTypeInfo typeInfo; // 0x0
	private readonly MethodInfo getterInfo; // 0x0


	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B53450 Offset: 0x1B51A50 VA: 0x181B53450
	|-NonGenericProperytWriter<bool>..ctor
	|-NonGenericProperytWriter<byte>..ctor
	|-NonGenericProperytWriter<char>..ctor
	|-NonGenericProperytWriter<KeyValuePair<object, object>>..ctor
	|-NonGenericProperytWriter<DateTime>..ctor
	|-NonGenericProperytWriter<DateTimeOffset>..ctor
	|-NonGenericProperytWriter<Decimal>..ctor
	|-NonGenericProperytWriter<EmptyStruct>..ctor
	|-NonGenericProperytWriter<double>..ctor
	|-NonGenericProperytWriter<Guid>..ctor
	|-NonGenericProperytWriter<short>..ctor
	|-NonGenericProperytWriter<int>..ctor
	|-NonGenericProperytWriter<long>..ctor
	|-NonGenericProperytWriter<IntPtr>..ctor
	|-NonGenericProperytWriter<object>..ctor
	|-NonGenericProperytWriter<sbyte>..ctor
	|-NonGenericProperytWriter<float>..ctor
	|-NonGenericProperytWriter<TimeSpan>..ctor
	|-NonGenericProperytWriter<ushort>..ctor
	|-NonGenericProperytWriter<uint>..ctor
	|-NonGenericProperytWriter<ulong>..ctor
	|-NonGenericProperytWriter<UIntPtr>..ctor
	*/

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52FD0 Offset: 0x1B515D0 VA: 0x181B52FD0
	|-NonGenericProperytWriter<bool>.Write
	|-NonGenericProperytWriter<byte>.Write
	|-NonGenericProperytWriter<EmptyStruct>.Write
	|-NonGenericProperytWriter<sbyte>.Write
	|
	|-RVA: 0x1B53080 Offset: 0x1B51680 VA: 0x181B53080
	|-NonGenericProperytWriter<char>.Write
	|-NonGenericProperytWriter<short>.Write
	|-NonGenericProperytWriter<ushort>.Write
	|
	|-RVA: 0x1B531E0 Offset: 0x1B517E0 VA: 0x181B531E0
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.Write
	|-NonGenericProperytWriter<DateTimeOffset>.Write
	|-NonGenericProperytWriter<Decimal>.Write
	|-NonGenericProperytWriter<Guid>.Write
	|
	|-RVA: 0x1B52F20 Offset: 0x1B51520 VA: 0x181B52F20
	|-NonGenericProperytWriter<DateTime>.Write
	|-NonGenericProperytWriter<long>.Write
	|-NonGenericProperytWriter<IntPtr>.Write
	|-NonGenericProperytWriter<TimeSpan>.Write
	|-NonGenericProperytWriter<ulong>.Write
	|-NonGenericProperytWriter<UIntPtr>.Write
	|
	|-RVA: 0x1B53130 Offset: 0x1B51730 VA: 0x181B53130
	|-NonGenericProperytWriter<double>.Write
	|
	|-RVA: 0x1B53290 Offset: 0x1B51890 VA: 0x181B53290
	|-NonGenericProperytWriter<int>.Write
	|-NonGenericProperytWriter<uint>.Write
	|
	|-RVA: 0x1B533F0 Offset: 0x1B519F0 VA: 0x181B533F0
	|-NonGenericProperytWriter<object>.Write
	|
	|-RVA: 0x1B53340 Offset: 0x1B51940 VA: 0x181B53340
	|-NonGenericProperytWriter<float>.Write
	*/

	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B52DA0 Offset: 0x1B513A0 VA: 0x181B52DA0
	|-NonGenericProperytWriter<bool>.GetData
	|-NonGenericProperytWriter<byte>.GetData
	|-NonGenericProperytWriter<EmptyStruct>.GetData
	|-NonGenericProperytWriter<sbyte>.GetData
	|
	|-RVA: 0x1B52D30 Offset: 0x1B51330 VA: 0x181B52D30
	|-NonGenericProperytWriter<char>.GetData
	|-NonGenericProperytWriter<short>.GetData
	|-NonGenericProperytWriter<ushort>.GetData
	|
	|-RVA: 0x1B52C50 Offset: 0x1B51250 VA: 0x181B52C50
	|-NonGenericProperytWriter<KeyValuePair<object, object>>.GetData
	|-NonGenericProperytWriter<DateTimeOffset>.GetData
	|-NonGenericProperytWriter<Decimal>.GetData
	|-NonGenericProperytWriter<Guid>.GetData
	|
	|-RVA: 0x1B52BE0 Offset: 0x1B511E0 VA: 0x181B52BE0
	|-NonGenericProperytWriter<DateTime>.GetData
	|-NonGenericProperytWriter<long>.GetData
	|-NonGenericProperytWriter<IntPtr>.GetData
	|-NonGenericProperytWriter<TimeSpan>.GetData
	|-NonGenericProperytWriter<ulong>.GetData
	|-NonGenericProperytWriter<UIntPtr>.GetData
	|
	|-RVA: 0x1B52CC0 Offset: 0x1B512C0 VA: 0x181B52CC0
	|-NonGenericProperytWriter<double>.GetData
	|
	|-RVA: 0x1B52EB0 Offset: 0x1B514B0 VA: 0x181B52EB0
	|-NonGenericProperytWriter<int>.GetData
	|-NonGenericProperytWriter<uint>.GetData
	|
	|-RVA: 0x1B52E80 Offset: 0x1B51480 VA: 0x181B52E80
	|-NonGenericProperytWriter<object>.GetData
	|
	|-RVA: 0x1B52E10 Offset: 0x1B51410 VA: 0x181B52E10
	|-NonGenericProperytWriter<float>.GetData
	*/

}

internal class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType> // TypeDefIndex: 1528
{	private readonly TraceLoggingTypeInfo<ValueType> valueTypeInfo; // 0x0
	private readonly ClassPropertyWriter.Getter<ContainerType, ValueType> getter; // 0x0


	public void .ctor(PropertyAnalysis property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C1820 Offset: 0x20BFE20 VA: 0x1820C1820
	|-ClassPropertyWriter<bool, int>..ctor
	|
	|-RVA: 0x20C4C20 Offset: 0x20C3220 VA: 0x1820C4C20
	|-ClassPropertyWriter<bool, long>..ctor
	|
	|-RVA: 0x20C52A0 Offset: 0x20C38A0 VA: 0x1820C52A0
	|-ClassPropertyWriter<bool, object>..ctor
	|
	|-RVA: 0x20C1EA0 Offset: 0x20C04A0 VA: 0x1820C1EA0
	|-ClassPropertyWriter<byte, int>..ctor
	|
	|-RVA: 0x20C5E00 Offset: 0x20C4400 VA: 0x1820C5E00
	|-ClassPropertyWriter<byte, long>..ctor
	|
	|-RVA: 0x20C5100 Offset: 0x20C3700 VA: 0x1820C5100
	|-ClassPropertyWriter<byte, object>..ctor
	|
	|-RVA: 0x20C1B60 Offset: 0x20C0160 VA: 0x1820C1B60
	|-ClassPropertyWriter<char, int>..ctor
	|
	|-RVA: 0x20C45A0 Offset: 0x20C2BA0 VA: 0x1820C45A0
	|-ClassPropertyWriter<char, long>..ctor
	|
	|-RVA: 0x20C2D40 Offset: 0x20C1340 VA: 0x1820C2D40
	|-ClassPropertyWriter<char, object>..ctor
	|
	|-RVA: 0x20C4260 Offset: 0x20C2860 VA: 0x1820C4260
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x20C2520 Offset: 0x20C0B20 VA: 0x1820C2520
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x20C2040 Offset: 0x20C0640 VA: 0x1820C2040
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x20C21E0 Offset: 0x20C07E0 VA: 0x1820C21E0
	|-ClassPropertyWriter<DateTime, int>..ctor
	|
	|-RVA: 0x20C55E0 Offset: 0x20C3BE0 VA: 0x1820C55E0
	|-ClassPropertyWriter<DateTime, long>..ctor
	|
	|-RVA: 0x20C19C0 Offset: 0x20BFFC0 VA: 0x1820C19C0
	|-ClassPropertyWriter<DateTime, object>..ctor
	|
	|-RVA: 0x20C3700 Offset: 0x20C1D00 VA: 0x1820C3700
	|-ClassPropertyWriter<DateTimeOffset, int>..ctor
	|
	|-RVA: 0x20C2380 Offset: 0x20C0980 VA: 0x1820C2380
	|-ClassPropertyWriter<DateTimeOffset, long>..ctor
	|
	|-RVA: 0x20C4A80 Offset: 0x20C3080 VA: 0x1820C4A80
	|-ClassPropertyWriter<DateTimeOffset, object>..ctor
	|
	|-RVA: 0x20C3080 Offset: 0x20C1680 VA: 0x1820C3080
	|-ClassPropertyWriter<Decimal, int>..ctor
	|
	|-RVA: 0x20C5440 Offset: 0x20C3A40 VA: 0x1820C5440
	|-ClassPropertyWriter<Decimal, long>..ctor
	|
	|-RVA: 0x20C5AC0 Offset: 0x20C40C0 VA: 0x1820C5AC0
	|-ClassPropertyWriter<Decimal, object>..ctor
	|
	|-RVA: 0x20C3560 Offset: 0x20C1B60 VA: 0x1820C3560
	|-ClassPropertyWriter<EmptyStruct, int>..ctor
	|
	|-RVA: 0x20C38A0 Offset: 0x20C1EA0 VA: 0x1820C38A0
	|-ClassPropertyWriter<EmptyStruct, long>..ctor
	|
	|-RVA: 0x20C33C0 Offset: 0x20C19C0 VA: 0x1820C33C0
	|-ClassPropertyWriter<EmptyStruct, object>..ctor
	|
	|-RVA: 0x20C3F20 Offset: 0x20C2520 VA: 0x1820C3F20
	|-ClassPropertyWriter<double, int>..ctor
	|
	|-RVA: 0x20C48E0 Offset: 0x20C2EE0 VA: 0x1820C48E0
	|-ClassPropertyWriter<double, long>..ctor
	|
	|-RVA: 0x20C5780 Offset: 0x20C3D80 VA: 0x1820C5780
	|-ClassPropertyWriter<double, object>..ctor
	|
	|-RVA: 0x20C40C0 Offset: 0x20C26C0 VA: 0x1820C40C0
	|-ClassPropertyWriter<Guid, int>..ctor
	|
	|-RVA: 0x20C3A40 Offset: 0x20C2040 VA: 0x1820C3A40
	|-ClassPropertyWriter<Guid, long>..ctor
	|
	|-RVA: 0x20C4F60 Offset: 0x20C3560 VA: 0x1820C4F60
	|-ClassPropertyWriter<Guid, object>..ctor
	|
	|-RVA: 0x20C2A00 Offset: 0x20C1000 VA: 0x1820C2A00
	|-ClassPropertyWriter<short, int>..ctor
	|
	|-RVA: 0x20C2EE0 Offset: 0x20C14E0 VA: 0x1820C2EE0
	|-ClassPropertyWriter<short, long>..ctor
	|
	|-RVA: 0x20C26C0 Offset: 0x20C0CC0 VA: 0x1820C26C0
	|-ClassPropertyWriter<short, object>..ctor
	|
	|-RVA: 0x20C1D00 Offset: 0x20C0300 VA: 0x1820C1D00
	|-ClassPropertyWriter<int, int>..ctor
	|
	|-RVA: 0x20C5920 Offset: 0x20C3F20 VA: 0x1820C5920
	|-ClassPropertyWriter<int, long>..ctor
	|
	|-RVA: 0x20C4DC0 Offset: 0x20C33C0 VA: 0x1820C4DC0
	|-ClassPropertyWriter<int, object>..ctor
	|
	|-RVA: 0x20C1680 Offset: 0x20BFC80 VA: 0x1820C1680
	|-ClassPropertyWriter<long, int>..ctor
	|
	|-RVA: 0x20C3220 Offset: 0x20C1820 VA: 0x1820C3220
	|-ClassPropertyWriter<long, long>..ctor
	|
	|-RVA: 0x20C3D80 Offset: 0x20C2380 VA: 0x1820C3D80
	|-ClassPropertyWriter<long, object>..ctor
	|
	|-RVA: 0x20C4740 Offset: 0x20C2D40 VA: 0x1820C4740
	|-ClassPropertyWriter<IntPtr, int>..ctor
	|
	|-RVA: 0x20C5FA0 Offset: 0x20C45A0 VA: 0x1820C5FA0
	|-ClassPropertyWriter<IntPtr, long>..ctor
	|
	|-RVA: 0x20C5C60 Offset: 0x20C4260 VA: 0x1820C5C60
	|-ClassPropertyWriter<IntPtr, object>..ctor
	|
	|-RVA: 0x20C2860 Offset: 0x20C0E60 VA: 0x1820C2860
	|-ClassPropertyWriter<object, int>..ctor
	|
	|-RVA: 0x20C3BE0 Offset: 0x20C21E0 VA: 0x1820C3BE0
	|-ClassPropertyWriter<object, long>..ctor
	|
	|-RVA: 0x20C2BA0 Offset: 0x20C11A0 VA: 0x1820C2BA0
	|-ClassPropertyWriter<object, object>..ctor
	|
	|-RVA: 0x20C4400 Offset: 0x20C2A00 VA: 0x1820C4400
	|-ClassPropertyWriter<sbyte, int>..ctor
	|
	|-RVA: 0x20C6140 Offset: 0x20C4740 VA: 0x1820C6140
	|-ClassPropertyWriter<sbyte, long>..ctor
	|
	|-RVA: 0x1B10250 Offset: 0x1B0E850 VA: 0x181B10250
	|-ClassPropertyWriter<sbyte, object>..ctor
	|
	|-RVA: 0x1B11F90 Offset: 0x1B10590 VA: 0x181B11F90
	|-ClassPropertyWriter<float, int>..ctor
	|
	|-RVA: 0x1B11910 Offset: 0x1B0FF10 VA: 0x181B11910
	|-ClassPropertyWriter<float, long>..ctor
	|
	|-RVA: 0x1B103F0 Offset: 0x1B0E9F0 VA: 0x181B103F0
	|-ClassPropertyWriter<float, object>..ctor
	|
	|-RVA: 0x1B11430 Offset: 0x1B0FA30 VA: 0x181B11430
	|-ClassPropertyWriter<TimeSpan, int>..ctor
	|
	|-RVA: 0x1B11770 Offset: 0x1B0FD70 VA: 0x181B11770
	|-ClassPropertyWriter<TimeSpan, long>..ctor
	|
	|-RVA: 0x1B10DB0 Offset: 0x1B0F3B0 VA: 0x181B10DB0
	|-ClassPropertyWriter<TimeSpan, object>..ctor
	|
	|-RVA: 0x1B108D0 Offset: 0x1B0EED0 VA: 0x181B108D0
	|-ClassPropertyWriter<ushort, int>..ctor
	|
	|-RVA: 0x1B10A70 Offset: 0x1B0F070 VA: 0x181B10A70
	|-ClassPropertyWriter<ushort, long>..ctor
	|
	|-RVA: 0x1B11DF0 Offset: 0x1B103F0 VA: 0x181B11DF0
	|-ClassPropertyWriter<ushort, object>..ctor
	|
	|-RVA: 0x1B11AB0 Offset: 0x1B100B0 VA: 0x181B11AB0
	|-ClassPropertyWriter<uint, int>..ctor
	|
	|-RVA: 0x1B11C50 Offset: 0x1B10250 VA: 0x181B11C50
	|-ClassPropertyWriter<uint, long>..ctor
	|
	|-RVA: 0x1B10F50 Offset: 0x1B0F550 VA: 0x181B10F50
	|-ClassPropertyWriter<uint, object>..ctor
	|
	|-RVA: 0x1B110F0 Offset: 0x1B0F6F0 VA: 0x181B110F0
	|-ClassPropertyWriter<ulong, int>..ctor
	|
	|-RVA: 0x1B11290 Offset: 0x1B0F890 VA: 0x181B11290
	|-ClassPropertyWriter<ulong, long>..ctor
	|
	|-RVA: 0x1B10730 Offset: 0x1B0ED30 VA: 0x181B10730
	|-ClassPropertyWriter<ulong, object>..ctor
	|
	|-RVA: 0x1B10590 Offset: 0x1B0EB90 VA: 0x181B10590
	|-ClassPropertyWriter<UIntPtr, int>..ctor
	|
	|-RVA: 0x1B10C10 Offset: 0x1B0F210 VA: 0x181B10C10
	|-ClassPropertyWriter<UIntPtr, long>..ctor
	|
	|-RVA: 0x1B115D0 Offset: 0x1B0FBD0 VA: 0x181B115D0
	|-ClassPropertyWriter<UIntPtr, object>..ctor
	*/

	public override void Write(TraceLoggingDataCollector collector, ref ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C13E0 Offset: 0x20BF9E0 VA: 0x1820C13E0
	|-ClassPropertyWriter<bool, int>.Write
	|-ClassPropertyWriter<byte, int>.Write
	|-ClassPropertyWriter<sbyte, int>.Write
	|
	|-RVA: 0x1B0FDF0 Offset: 0x1B0E3F0 VA: 0x181B0FDF0
	|-ClassPropertyWriter<bool, long>.Write
	|-ClassPropertyWriter<bool, object>.Write
	|-ClassPropertyWriter<byte, long>.Write
	|-ClassPropertyWriter<byte, object>.Write
	|-ClassPropertyWriter<sbyte, long>.Write
	|-ClassPropertyWriter<sbyte, object>.Write
	|
	|-RVA: 0x1B10090 Offset: 0x1B0E690 VA: 0x181B10090
	|-ClassPropertyWriter<char, int>.Write
	|-ClassPropertyWriter<short, int>.Write
	|-ClassPropertyWriter<ushort, int>.Write
	|
	|-RVA: 0x1B0FD80 Offset: 0x1B0E380 VA: 0x181B0FD80
	|-ClassPropertyWriter<char, long>.Write
	|-ClassPropertyWriter<char, object>.Write
	|-ClassPropertyWriter<short, long>.Write
	|-ClassPropertyWriter<short, object>.Write
	|-ClassPropertyWriter<ushort, long>.Write
	|-ClassPropertyWriter<ushort, object>.Write
	|
	|-RVA: 0x20C1360 Offset: 0x20BF960 VA: 0x1820C1360
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.Write
	|-ClassPropertyWriter<DateTimeOffset, int>.Write
	|-ClassPropertyWriter<Decimal, int>.Write
	|-ClassPropertyWriter<Guid, int>.Write
	|
	|-RVA: 0x20C1270 Offset: 0x20BF870 VA: 0x1820C1270
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.Write
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.Write
	|-ClassPropertyWriter<DateTimeOffset, long>.Write
	|-ClassPropertyWriter<DateTimeOffset, object>.Write
	|-ClassPropertyWriter<Decimal, long>.Write
	|-ClassPropertyWriter<Decimal, object>.Write
	|-ClassPropertyWriter<Guid, long>.Write
	|-ClassPropertyWriter<Guid, object>.Write
	|
	|-RVA: 0x1B10100 Offset: 0x1B0E700 VA: 0x181B10100
	|-ClassPropertyWriter<DateTime, int>.Write
	|-ClassPropertyWriter<TimeSpan, int>.Write
	|
	|-RVA: 0x1B10170 Offset: 0x1B0E770 VA: 0x181B10170
	|-ClassPropertyWriter<DateTime, long>.Write
	|-ClassPropertyWriter<DateTime, object>.Write
	|-ClassPropertyWriter<TimeSpan, long>.Write
	|-ClassPropertyWriter<TimeSpan, object>.Write
	|
	|-RVA: 0x20C1610 Offset: 0x20BFC10 VA: 0x1820C1610
	|-ClassPropertyWriter<EmptyStruct, int>.Write
	|
	|-RVA: 0x20C12F0 Offset: 0x20BF8F0 VA: 0x1820C12F0
	|-ClassPropertyWriter<EmptyStruct, long>.Write
	|-ClassPropertyWriter<EmptyStruct, object>.Write
	|
	|-RVA: 0x20C15A0 Offset: 0x20BFBA0 VA: 0x1820C15A0
	|-ClassPropertyWriter<double, int>.Write
	|
	|-RVA: 0x20C14C0 Offset: 0x20BFAC0 VA: 0x1820C14C0
	|-ClassPropertyWriter<double, long>.Write
	|-ClassPropertyWriter<double, object>.Write
	|
	|-RVA: 0x1B101E0 Offset: 0x1B0E7E0 VA: 0x181B101E0
	|-ClassPropertyWriter<int, int>.Write
	|-ClassPropertyWriter<uint, int>.Write
	|
	|-RVA: 0x1B0FF40 Offset: 0x1B0E540 VA: 0x181B0FF40
	|-ClassPropertyWriter<int, long>.Write
	|-ClassPropertyWriter<int, object>.Write
	|-ClassPropertyWriter<uint, long>.Write
	|-ClassPropertyWriter<uint, object>.Write
	|
	|-RVA: 0x1B10020 Offset: 0x1B0E620 VA: 0x181B10020
	|-ClassPropertyWriter<long, int>.Write
	|-ClassPropertyWriter<IntPtr, int>.Write
	|-ClassPropertyWriter<ulong, int>.Write
	|-ClassPropertyWriter<UIntPtr, int>.Write
	|
	|-RVA: 0x1B0FED0 Offset: 0x1B0E4D0 VA: 0x181B0FED0
	|-ClassPropertyWriter<long, long>.Write
	|-ClassPropertyWriter<long, object>.Write
	|-ClassPropertyWriter<IntPtr, long>.Write
	|-ClassPropertyWriter<IntPtr, object>.Write
	|-ClassPropertyWriter<ulong, long>.Write
	|-ClassPropertyWriter<ulong, object>.Write
	|-ClassPropertyWriter<UIntPtr, long>.Write
	|-ClassPropertyWriter<UIntPtr, object>.Write
	|
	|-RVA: 0x20C1530 Offset: 0x20BFB30 VA: 0x1820C1530
	|-ClassPropertyWriter<object, int>.Write
	|
	|-RVA: 0x20C1450 Offset: 0x20BFA50 VA: 0x1820C1450
	|-ClassPropertyWriter<object, long>.Write
	|-ClassPropertyWriter<object, object>.Write
	|
	|-RVA: 0x1B0FFB0 Offset: 0x1B0E5B0 VA: 0x181B0FFB0
	|-ClassPropertyWriter<float, int>.Write
	|
	|-RVA: 0x1B0FE60 Offset: 0x1B0E460 VA: 0x181B0FE60
	|-ClassPropertyWriter<float, long>.Write
	|-ClassPropertyWriter<float, object>.Write
	*/

	public override object GetData(ContainerType container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B0FB90 Offset: 0x1B0E190 VA: 0x181B0FB90
	|-ClassPropertyWriter<bool, int>.GetData
	|-ClassPropertyWriter<byte, int>.GetData
	|-ClassPropertyWriter<char, int>.GetData
	|-ClassPropertyWriter<EmptyStruct, int>.GetData
	|-ClassPropertyWriter<short, int>.GetData
	|-ClassPropertyWriter<int, int>.GetData
	|-ClassPropertyWriter<sbyte, int>.GetData
	|-ClassPropertyWriter<ushort, int>.GetData
	|-ClassPropertyWriter<uint, int>.GetData
	|
	|-RVA: 0x1B0FAF0 Offset: 0x1B0E0F0 VA: 0x181B0FAF0
	|-ClassPropertyWriter<bool, long>.GetData
	|-ClassPropertyWriter<byte, long>.GetData
	|-ClassPropertyWriter<char, long>.GetData
	|-ClassPropertyWriter<DateTime, long>.GetData
	|-ClassPropertyWriter<EmptyStruct, long>.GetData
	|-ClassPropertyWriter<short, long>.GetData
	|-ClassPropertyWriter<int, long>.GetData
	|-ClassPropertyWriter<long, long>.GetData
	|-ClassPropertyWriter<IntPtr, long>.GetData
	|-ClassPropertyWriter<sbyte, long>.GetData
	|-ClassPropertyWriter<TimeSpan, long>.GetData
	|-ClassPropertyWriter<ushort, long>.GetData
	|-ClassPropertyWriter<uint, long>.GetData
	|-ClassPropertyWriter<ulong, long>.GetData
	|-ClassPropertyWriter<UIntPtr, long>.GetData
	|
	|-RVA: 0x1B0FB60 Offset: 0x1B0E160 VA: 0x181B0FB60
	|-ClassPropertyWriter<bool, object>.GetData
	|-ClassPropertyWriter<byte, object>.GetData
	|-ClassPropertyWriter<char, object>.GetData
	|-ClassPropertyWriter<DateTime, object>.GetData
	|-ClassPropertyWriter<EmptyStruct, object>.GetData
	|-ClassPropertyWriter<short, object>.GetData
	|-ClassPropertyWriter<int, object>.GetData
	|-ClassPropertyWriter<long, object>.GetData
	|-ClassPropertyWriter<IntPtr, object>.GetData
	|-ClassPropertyWriter<sbyte, object>.GetData
	|-ClassPropertyWriter<TimeSpan, object>.GetData
	|-ClassPropertyWriter<ushort, object>.GetData
	|-ClassPropertyWriter<uint, object>.GetData
	|-ClassPropertyWriter<ulong, object>.GetData
	|-ClassPropertyWriter<UIntPtr, object>.GetData
	|
	|-RVA: 0x20C0F90 Offset: 0x20BF590 VA: 0x1820C0F90
	|-ClassPropertyWriter<KeyValuePair<object, object>, int>.GetData
	|-ClassPropertyWriter<DateTimeOffset, int>.GetData
	|-ClassPropertyWriter<Decimal, int>.GetData
	|-ClassPropertyWriter<Guid, int>.GetData
	|
	|-RVA: 0x20C1040 Offset: 0x20BF640 VA: 0x1820C1040
	|-ClassPropertyWriter<KeyValuePair<object, object>, long>.GetData
	|-ClassPropertyWriter<DateTimeOffset, long>.GetData
	|-ClassPropertyWriter<Decimal, long>.GetData
	|-ClassPropertyWriter<Guid, long>.GetData
	|
	|-RVA: 0x20C1000 Offset: 0x20BF600 VA: 0x1820C1000
	|-ClassPropertyWriter<KeyValuePair<object, object>, object>.GetData
	|-ClassPropertyWriter<DateTimeOffset, object>.GetData
	|-ClassPropertyWriter<Decimal, object>.GetData
	|-ClassPropertyWriter<Guid, object>.GetData
	|
	|-RVA: 0x1B0FC00 Offset: 0x1B0E200 VA: 0x181B0FC00
	|-ClassPropertyWriter<DateTime, int>.GetData
	|-ClassPropertyWriter<long, int>.GetData
	|-ClassPropertyWriter<IntPtr, int>.GetData
	|-ClassPropertyWriter<TimeSpan, int>.GetData
	|-ClassPropertyWriter<ulong, int>.GetData
	|-ClassPropertyWriter<UIntPtr, int>.GetData
	|
	|-RVA: 0x20C1180 Offset: 0x20BF780 VA: 0x1820C1180
	|-ClassPropertyWriter<double, int>.GetData
	|
	|-RVA: 0x1B0FCE0 Offset: 0x1B0E2E0 VA: 0x181B0FCE0
	|-ClassPropertyWriter<double, long>.GetData
	|-ClassPropertyWriter<float, long>.GetData
	|
	|-RVA: 0x1B0FD50 Offset: 0x1B0E350 VA: 0x181B0FD50
	|-ClassPropertyWriter<double, object>.GetData
	|-ClassPropertyWriter<float, object>.GetData
	|
	|-RVA: 0x20C11F0 Offset: 0x20BF7F0 VA: 0x1820C11F0
	|-ClassPropertyWriter<object, int>.GetData
	|
	|-RVA: 0x20C1100 Offset: 0x20BF700 VA: 0x1820C1100
	|-ClassPropertyWriter<object, long>.GetData
	|
	|-RVA: 0x20C10C0 Offset: 0x20BF6C0 VA: 0x1820C10C0
	|-ClassPropertyWriter<object, object>.GetData
	|
	|-RVA: 0x1B0FC70 Offset: 0x1B0E270 VA: 0x181B0FC70
	|-ClassPropertyWriter<float, int>.GetData
	*/

}

internal sealed class NullTypeInfo<DataType> : TraceLoggingTypeInfo<DataType> // TypeDefIndex: 1531
{
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B534B0 Offset: 0x1B51AB0 VA: 0x181B534B0
	|-NullTypeInfo<EmptyStruct>.WriteMetadata
	|-NullTypeInfo<object>.WriteMetadata
	*/

	public override void WriteData(TraceLoggingDataCollector collector, ref DataType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-NullTypeInfo<EmptyStruct>.WriteData
	|-NullTypeInfo<object>.WriteData
	*/

	public override object GetData(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x511990 Offset: 0x50FF90 VA: 0x180511990
	|-NullTypeInfo<EmptyStruct>.GetData
	|-NullTypeInfo<object>.GetData
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117B000 Offset: 0x1179600 VA: 0x18117B000
	|-NullTypeInfo<EmptyStruct>..ctor
	|-NullTypeInfo<object>..ctor
	*/

}

internal abstract class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo // TypeDefIndex: 1590
{	private static TraceLoggingTypeInfo<DataType> instance; // 0x0

	public static TraceLoggingTypeInfo<DataType> Instance { get; }


	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58F70 Offset: 0x1B57570 VA: 0x181B58F70
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9D240 Offset: 0x1B9B840 VA: 0x181B9D240
	|-TraceLoggingTypeInfo<bool[]>..ctor
	|-TraceLoggingTypeInfo<byte[]>..ctor
	|-TraceLoggingTypeInfo<char[]>..ctor
	|-TraceLoggingTypeInfo<double[]>..ctor
	|-TraceLoggingTypeInfo<Guid[]>..ctor
	|-TraceLoggingTypeInfo<short[]>..ctor
	|-TraceLoggingTypeInfo<int[]>..ctor
	|-TraceLoggingTypeInfo<long[]>..ctor
	|-TraceLoggingTypeInfo<IntPtr[]>..ctor
	|-TraceLoggingTypeInfo<object>..ctor
	|-TraceLoggingTypeInfo<sbyte[]>..ctor
	|-TraceLoggingTypeInfo<float[]>..ctor
	|-TraceLoggingTypeInfo<string>..ctor
	|-TraceLoggingTypeInfo<ushort[]>..ctor
	|-TraceLoggingTypeInfo<uint[]>..ctor
	|-TraceLoggingTypeInfo<ulong[]>..ctor
	|-TraceLoggingTypeInfo<UIntPtr[]>..ctor
	|
	|-RVA: 0x1B9C190 Offset: 0x1B9A790 VA: 0x181B9C190
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9C020 Offset: 0x1B9A620 VA: 0x181B9C020
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9D040 Offset: 0x1B9B640 VA: 0x181B9D040
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9CFB0 Offset: 0x1B9B5B0 VA: 0x181B9CFB0
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9CB60 Offset: 0x1B9B160 VA: 0x181B9CB60
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9CBF0 Offset: 0x1B9B1F0 VA: 0x181B9CBF0
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9BEB0 Offset: 0x1B9A4B0 VA: 0x181B9BEB0
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9C3E0 Offset: 0x1B9A9E0 VA: 0x181B9C3E0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9D690 Offset: 0x1B9BC90 VA: 0x181B9D690
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9D520 Offset: 0x1B9BB20 VA: 0x181B9D520
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9C630 Offset: 0x1B9AC30 VA: 0x181B9C630
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9C960 Offset: 0x1B9AF60 VA: 0x181B9C960
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9D0D0 Offset: 0x1B9B6D0 VA: 0x181B9D0D0
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9CC80 Offset: 0x1B9B280 VA: 0x181B9CC80
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9D3B0 Offset: 0x1B9B9B0 VA: 0x181B9D3B0
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9BA60 Offset: 0x1B9A060 VA: 0x181B9BA60
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9D800 Offset: 0x1B9BE00 VA: 0x181B9D800
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9C9F0 Offset: 0x1B9AFF0 VA: 0x181B9C9F0
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9BC60 Offset: 0x1B9A260 VA: 0x181B9BC60
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9BAF0 Offset: 0x1B9A0F0 VA: 0x181B9BAF0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	protected void .ctor(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58E90 Offset: 0x1B57490 VA: 0x181B58E90
	|-TraceLoggingTypeInfo<bool>..ctor
	|
	|-RVA: 0x1B9D5B0 Offset: 0x1B9BBB0 VA: 0x181B9D5B0
	|-TraceLoggingTypeInfo<byte>..ctor
	|
	|-RVA: 0x1B9C6C0 Offset: 0x1B9ACC0 VA: 0x181B9C6C0
	|-TraceLoggingTypeInfo<char>..ctor
	|
	|-RVA: 0x1B9C470 Offset: 0x1B9AA70 VA: 0x181B9C470
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x1B9C880 Offset: 0x1B9AE80 VA: 0x181B9C880
	|-TraceLoggingTypeInfo<DateTime>..ctor
	|
	|-RVA: 0x1B9D160 Offset: 0x1B9B760 VA: 0x181B9D160
	|-TraceLoggingTypeInfo<DateTimeOffset>..ctor
	|
	|-RVA: 0x1B9C300 Offset: 0x1B9A900 VA: 0x181B9C300
	|-TraceLoggingTypeInfo<Decimal>..ctor
	|
	|-RVA: 0x1B9C550 Offset: 0x1B9AB50 VA: 0x181B9C550
	|-TraceLoggingTypeInfo<EmptyStruct>..ctor
	|
	|-RVA: 0x1B9C7A0 Offset: 0x1B9ADA0 VA: 0x181B9C7A0
	|-TraceLoggingTypeInfo<double>..ctor
	|
	|-RVA: 0x1B9BDD0 Offset: 0x1B9A3D0 VA: 0x181B9BDD0
	|-TraceLoggingTypeInfo<Guid>..ctor
	|
	|-RVA: 0x1B9D720 Offset: 0x1B9BD20 VA: 0x181B9D720
	|-TraceLoggingTypeInfo<short>..ctor
	|
	|-RVA: 0x1B9C0B0 Offset: 0x1B9A6B0 VA: 0x181B9C0B0
	|-TraceLoggingTypeInfo<int>..ctor
	|
	|-RVA: 0x1B9BCF0 Offset: 0x1B9A2F0 VA: 0x181B9BCF0
	|-TraceLoggingTypeInfo<long>..ctor
	|
	|-RVA: 0x1B9CD10 Offset: 0x1B9B310 VA: 0x181B9CD10
	|-TraceLoggingTypeInfo<IntPtr>..ctor
	|
	|-RVA: 0x1B9BF40 Offset: 0x1B9A540 VA: 0x181B9BF40
	|-TraceLoggingTypeInfo<object>..ctor
	|
	|-RVA: 0x1B9CDF0 Offset: 0x1B9B3F0 VA: 0x181B9CDF0
	|-TraceLoggingTypeInfo<sbyte>..ctor
	|
	|-RVA: 0x1B9CA80 Offset: 0x1B9B080 VA: 0x181B9CA80
	|-TraceLoggingTypeInfo<float>..ctor
	|
	|-RVA: 0x1B9CED0 Offset: 0x1B9B4D0 VA: 0x181B9CED0
	|-TraceLoggingTypeInfo<TimeSpan>..ctor
	|
	|-RVA: 0x1B9BB80 Offset: 0x1B9A180 VA: 0x181B9BB80
	|-TraceLoggingTypeInfo<ushort>..ctor
	|
	|-RVA: 0x1B9D440 Offset: 0x1B9BA40 VA: 0x181B9D440
	|-TraceLoggingTypeInfo<uint>..ctor
	|
	|-RVA: 0x1B9C220 Offset: 0x1B9A820 VA: 0x181B9C220
	|-TraceLoggingTypeInfo<ulong>..ctor
	|
	|-RVA: 0x1B9D2D0 Offset: 0x1B9B8D0 VA: 0x181B9D2D0
	|-TraceLoggingTypeInfo<UIntPtr>..ctor
	*/

	public static TraceLoggingTypeInfo<DataType> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B59000 Offset: 0x1B57600 VA: 0x181B59000
	|-TraceLoggingTypeInfo<bool>.get_Instance
	|-TraceLoggingTypeInfo<byte>.get_Instance
	|-TraceLoggingTypeInfo<char>.get_Instance
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.get_Instance
	|-TraceLoggingTypeInfo<DateTime>.get_Instance
	|-TraceLoggingTypeInfo<DateTimeOffset>.get_Instance
	|-TraceLoggingTypeInfo<Decimal>.get_Instance
	|-TraceLoggingTypeInfo<EmptyStruct>.get_Instance
	|-TraceLoggingTypeInfo<double>.get_Instance
	|-TraceLoggingTypeInfo<Guid>.get_Instance
	|-TraceLoggingTypeInfo<short>.get_Instance
	|-TraceLoggingTypeInfo<int>.get_Instance
	|-TraceLoggingTypeInfo<long>.get_Instance
	|-TraceLoggingTypeInfo<IntPtr>.get_Instance
	|-TraceLoggingTypeInfo<object>.get_Instance
	|-TraceLoggingTypeInfo<sbyte>.get_Instance
	|-TraceLoggingTypeInfo<float>.get_Instance
	|-TraceLoggingTypeInfo<string>.get_Instance
	|-TraceLoggingTypeInfo<TimeSpan>.get_Instance
	|-TraceLoggingTypeInfo<ushort>.get_Instance
	|-TraceLoggingTypeInfo<uint>.get_Instance
	|-TraceLoggingTypeInfo<ulong>.get_Instance
	|-TraceLoggingTypeInfo<UIntPtr>.get_Instance
	*/

	public abstract void WriteData(TraceLoggingDataCollector collector, ref DataType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TraceLoggingTypeInfo<object>.WriteData
	*/

	public override void WriteObjectData(TraceLoggingDataCollector collector, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58DE0 Offset: 0x1B573E0 VA: 0x181B58DE0
	|-TraceLoggingTypeInfo<bool>.WriteObjectData
	|-TraceLoggingTypeInfo<byte>.WriteObjectData
	|-TraceLoggingTypeInfo<EmptyStruct>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte>.WriteObjectData
	|
	|-RVA: 0x1B9B850 Offset: 0x1B99E50 VA: 0x181B9B850
	|-TraceLoggingTypeInfo<bool[]>.WriteObjectData
	|-TraceLoggingTypeInfo<byte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<char[]>.WriteObjectData
	|-TraceLoggingTypeInfo<double[]>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid[]>.WriteObjectData
	|-TraceLoggingTypeInfo<short[]>.WriteObjectData
	|-TraceLoggingTypeInfo<int[]>.WriteObjectData
	|-TraceLoggingTypeInfo<long[]>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr[]>.WriteObjectData
	|-TraceLoggingTypeInfo<object>.WriteObjectData
	|-TraceLoggingTypeInfo<sbyte[]>.WriteObjectData
	|-TraceLoggingTypeInfo<float[]>.WriteObjectData
	|-TraceLoggingTypeInfo<string>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort[]>.WriteObjectData
	|-TraceLoggingTypeInfo<uint[]>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong[]>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr[]>.WriteObjectData
	|
	|-RVA: 0x1B9B6F0 Offset: 0x1B99CF0 VA: 0x181B9B6F0
	|-TraceLoggingTypeInfo<char>.WriteObjectData
	|-TraceLoggingTypeInfo<short>.WriteObjectData
	|-TraceLoggingTypeInfo<ushort>.WriteObjectData
	|
	|-RVA: 0x1B9B640 Offset: 0x1B99C40 VA: 0x181B9B640
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.WriteObjectData
	|-TraceLoggingTypeInfo<DateTimeOffset>.WriteObjectData
	|-TraceLoggingTypeInfo<Decimal>.WriteObjectData
	|-TraceLoggingTypeInfo<Guid>.WriteObjectData
	|
	|-RVA: 0x1B9B590 Offset: 0x1B99B90 VA: 0x181B9B590
	|-TraceLoggingTypeInfo<DateTime>.WriteObjectData
	|-TraceLoggingTypeInfo<long>.WriteObjectData
	|-TraceLoggingTypeInfo<IntPtr>.WriteObjectData
	|-TraceLoggingTypeInfo<TimeSpan>.WriteObjectData
	|-TraceLoggingTypeInfo<ulong>.WriteObjectData
	|-TraceLoggingTypeInfo<UIntPtr>.WriteObjectData
	|
	|-RVA: 0x1B9B9B0 Offset: 0x1B99FB0 VA: 0x181B9B9B0
	|-TraceLoggingTypeInfo<double>.WriteObjectData
	|
	|-RVA: 0x1B9B900 Offset: 0x1B99F00 VA: 0x181B9B900
	|-TraceLoggingTypeInfo<int>.WriteObjectData
	|-TraceLoggingTypeInfo<uint>.WriteObjectData
	|
	|-RVA: 0x1B9B7A0 Offset: 0x1B99DA0 VA: 0x181B9B7A0
	|-TraceLoggingTypeInfo<float>.WriteObjectData
	*/

	internal static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58B80 Offset: 0x1B57180 VA: 0x181B58B80
	|-TraceLoggingTypeInfo<bool>.GetInstance
	|
	|-RVA: 0x1B98A70 Offset: 0x1B97070 VA: 0x181B98A70
	|-TraceLoggingTypeInfo<byte>.GetInstance
	|
	|-RVA: 0x1B9A210 Offset: 0x1B98810 VA: 0x181B9A210
	|-TraceLoggingTypeInfo<char>.GetInstance
	|
	|-RVA: 0x1B99D00 Offset: 0x1B98300 VA: 0x181B99D00
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.GetInstance
	|
	|-RVA: 0x1B9A570 Offset: 0x1B98B70 VA: 0x181B9A570
	|-TraceLoggingTypeInfo<DateTime>.GetInstance
	|
	|-RVA: 0x1B992E0 Offset: 0x1B978E0 VA: 0x181B992E0
	|-TraceLoggingTypeInfo<DateTimeOffset>.GetInstance
	|
	|-RVA: 0x1B999A0 Offset: 0x1B97FA0 VA: 0x181B999A0
	|-TraceLoggingTypeInfo<Decimal>.GetInstance
	|
	|-RVA: 0x1B9A3C0 Offset: 0x1B989C0 VA: 0x181B9A3C0
	|-TraceLoggingTypeInfo<EmptyStruct>.GetInstance
	|
	|-RVA: 0x1B99130 Offset: 0x1B97730 VA: 0x181B99130
	|-TraceLoggingTypeInfo<double>.GetInstance
	|
	|-RVA: 0x1B9A060 Offset: 0x1B98660 VA: 0x181B9A060
	|-TraceLoggingTypeInfo<Guid>.GetInstance
	|
	|-RVA: 0x1B99490 Offset: 0x1B97A90 VA: 0x181B99490
	|-TraceLoggingTypeInfo<short>.GetInstance
	|
	|-RVA: 0x1B98C20 Offset: 0x1B97220 VA: 0x181B98C20
	|-TraceLoggingTypeInfo<int>.GetInstance
	|
	|-RVA: 0x1B99EB0 Offset: 0x1B984B0 VA: 0x181B99EB0
	|-TraceLoggingTypeInfo<long>.GetInstance
	|
	|-RVA: 0x1B99B50 Offset: 0x1B98150 VA: 0x181B99B50
	|-TraceLoggingTypeInfo<IntPtr>.GetInstance
	|
	|-RVA: 0x1B98DD0 Offset: 0x1B973D0 VA: 0x181B98DD0
	|-TraceLoggingTypeInfo<object>.GetInstance
	|
	|-RVA: 0x1B983B0 Offset: 0x1B969B0 VA: 0x181B983B0
	|-TraceLoggingTypeInfo<sbyte>.GetInstance
	|
	|-RVA: 0x1B997F0 Offset: 0x1B97DF0 VA: 0x181B997F0
	|-TraceLoggingTypeInfo<float>.GetInstance
	|
	|-RVA: 0x1B988C0 Offset: 0x1B96EC0 VA: 0x181B988C0
	|-TraceLoggingTypeInfo<TimeSpan>.GetInstance
	|
	|-RVA: 0x1B98710 Offset: 0x1B96D10 VA: 0x181B98710
	|-TraceLoggingTypeInfo<ushort>.GetInstance
	|
	|-RVA: 0x1B98560 Offset: 0x1B96B60 VA: 0x181B98560
	|-TraceLoggingTypeInfo<uint>.GetInstance
	|
	|-RVA: 0x1B98F80 Offset: 0x1B97580 VA: 0x181B98F80
	|-TraceLoggingTypeInfo<ulong>.GetInstance
	|
	|-RVA: 0x1B99640 Offset: 0x1B97C40 VA: 0x181B99640
	|-TraceLoggingTypeInfo<UIntPtr>.GetInstance
	*/

	private static TraceLoggingTypeInfo<DataType> InitInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B58D30 Offset: 0x1B57330 VA: 0x181B58D30
	|-TraceLoggingTypeInfo<bool>.InitInstance
	|
	|-RVA: 0x1B9ABF0 Offset: 0x1B991F0 VA: 0x181B9ABF0
	|-TraceLoggingTypeInfo<byte>.InitInstance
	|
	|-RVA: 0x1B9B380 Offset: 0x1B99980 VA: 0x181B9B380
	|-TraceLoggingTypeInfo<char>.InitInstance
	|
	|-RVA: 0x1B9A9E0 Offset: 0x1B98FE0 VA: 0x181B9A9E0
	|-TraceLoggingTypeInfo<KeyValuePair<object, object>>.InitInstance
	|
	|-RVA: 0x1B9B0C0 Offset: 0x1B996C0 VA: 0x181B9B0C0
	|-TraceLoggingTypeInfo<DateTime>.InitInstance
	|
	|-RVA: 0x1B9A7D0 Offset: 0x1B98DD0 VA: 0x181B9A7D0
	|-TraceLoggingTypeInfo<DateTimeOffset>.InitInstance
	|
	|-RVA: 0x1B9AE00 Offset: 0x1B99400 VA: 0x181B9AE00
	|-TraceLoggingTypeInfo<Decimal>.InitInstance
	|
	|-RVA: 0x1B9A880 Offset: 0x1B98E80 VA: 0x181B9A880
	|-TraceLoggingTypeInfo<EmptyStruct>.InitInstance
	|
	|-RVA: 0x1B9B010 Offset: 0x1B99610 VA: 0x181B9B010
	|-TraceLoggingTypeInfo<double>.InitInstance
	|
	|-RVA: 0x1B9A720 Offset: 0x1B98D20 VA: 0x181B9A720
	|-TraceLoggingTypeInfo<Guid>.InitInstance
	|
	|-RVA: 0x1B9B4E0 Offset: 0x1B99AE0 VA: 0x181B9B4E0
	|-TraceLoggingTypeInfo<short>.InitInstance
	|
	|-RVA: 0x1B9AF60 Offset: 0x1B99560 VA: 0x181B9AF60
	|-TraceLoggingTypeInfo<int>.InitInstance
	|
	|-RVA: 0x1B9A930 Offset: 0x1B98F30 VA: 0x181B9A930
	|-TraceLoggingTypeInfo<long>.InitInstance
	|
	|-RVA: 0x1B9AD50 Offset: 0x1B99350 VA: 0x181B9AD50
	|-TraceLoggingTypeInfo<IntPtr>.InitInstance
	|
	|-RVA: 0x1B9B220 Offset: 0x1B99820 VA: 0x181B9B220
	|-TraceLoggingTypeInfo<object>.InitInstance
	|
	|-RVA: 0x1B9AEB0 Offset: 0x1B994B0 VA: 0x181B9AEB0
	|-TraceLoggingTypeInfo<sbyte>.InitInstance
	|
	|-RVA: 0x1B9B430 Offset: 0x1B99A30 VA: 0x181B9B430
	|-TraceLoggingTypeInfo<float>.InitInstance
	|
	|-RVA: 0x1B9ACA0 Offset: 0x1B992A0 VA: 0x181B9ACA0
	|-TraceLoggingTypeInfo<TimeSpan>.InitInstance
	|
	|-RVA: 0x1B9B170 Offset: 0x1B99770 VA: 0x181B9B170
	|-TraceLoggingTypeInfo<ushort>.InitInstance
	|
	|-RVA: 0x1B9AA90 Offset: 0x1B99090 VA: 0x181B9AA90
	|-TraceLoggingTypeInfo<uint>.InitInstance
	|
	|-RVA: 0x1B9B2D0 Offset: 0x1B998D0 VA: 0x181B9B2D0
	|-TraceLoggingTypeInfo<ulong>.InitInstance
	|
	|-RVA: 0x1B9AB40 Offset: 0x1B99140 VA: 0x181B9AB40
	|-TraceLoggingTypeInfo<UIntPtr>.InitInstance
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1635
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467 /*Metadata offset 0x521C30*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775 /*Metadata offset 0x521D30*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C /*Metadata offset 0x521D78*/; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22 /*Metadata offset 0x521DCC*/; // 0x19C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x521EBC*/; // 0x28C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x521EBF*/; // 0x28F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0 /*Metadata offset 0x521EC2*/; // 0x292
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x521EDA*/; // 0x2AA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3 /*Metadata offset 0x521EDD*/; // 0x2AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5 /*Metadata offset 0x522EDD*/; // 0x12AD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD /*Metadata offset 0x5236DD*/; // 0x1AAD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x5236ED*/; // 0x1ABD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F /*Metadata offset 0x5236F0*/; // 0x1AC0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E /*Metadata offset 0x523718*/; // 0x1AE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40 /*Metadata offset 0x523BD0*/; // 0x1FA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717 /*Metadata offset 0x523BFA*/; // 0x1FCA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F /*Metadata offset 0x523C06*/; // 0x1FD6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD /*Metadata offset 0x523C2A*/; // 0x1FFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20 /*Metadata offset 0x523C72*/; // 0x2042
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x523C82*/; // 0x2052
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547 /*Metadata offset 0x523C90*/; // 0x2060
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x523CD8*/; // 0x20A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834 /*Metadata offset 0x523D18*/; // 0x20E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604 /*Metadata offset 0x523D60*/; // 0x2130
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3 /*Metadata offset 0x5246AE*/; // 0x2A7E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5 /*Metadata offset 0x5246D4*/; // 0x2AA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00 /*Metadata offset 0x524C7E*/; // 0x304E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE /*Metadata offset 0x524C88*/; // 0x3058
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851 /*Metadata offset 0x524CD0*/; // 0x30A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x524E10*/; // 0x31E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD /*Metadata offset 0x524E13*/; // 0x31E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1 /*Metadata offset 0x524E53*/; // 0x3223
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1 /*Metadata offset 0x524E5F*/; // 0x322F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444 /*Metadata offset 0x524EA7*/; // 0x3277
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048 /*Metadata offset 0x525528*/; // 0x38F8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845 /*Metadata offset 0x525550*/; // 0x3920
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2 /*Metadata offset 0x525598*/; // 0x3968
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902 /*Metadata offset 0x525698*/; // 0x3A68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628 /*Metadata offset 0x525710*/; // 0x3AE0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x525758*/; // 0x3B28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A /*Metadata offset 0x525788*/; // 0x3B58
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3 /*Metadata offset 0x5257B0*/; // 0x3B80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3 /*Metadata offset 0x5257F8*/; // 0x3BC8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x525C30*/; // 0x4000
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471 /*Metadata offset 0x525C3A*/; // 0x400A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6 /*Metadata offset 0x525C3D*/; // 0x400D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3 /*Metadata offset 0x525C65*/; // 0x4035
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F /*Metadata offset 0x525D39*/; // 0x4109
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF /*Metadata offset 0x525D5D*/; // 0x412D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89 /*Metadata offset 0x525E7D*/; // 0x424D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C /*Metadata offset 0x525EC5*/; // 0x4295
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283 /*Metadata offset 0x525F45*/; // 0x4315
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60 /*Metadata offset 0x525F75*/; // 0x4345
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B /*Metadata offset 0x526775*/; // 0x4B45
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E /*Metadata offset 0x52679D*/; // 0x4B6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3 /*Metadata offset 0x5267D1*/; // 0x4BA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF /*Metadata offset 0x526819*/; // 0x4BE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7 /*Metadata offset 0x526891*/; // 0x4C61
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x5268A1*/; // 0x4C71
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065 /*Metadata offset 0x5268AA*/; // 0x4C7A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x5270AA*/; // 0x547A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7 /*Metadata offset 0x527CE6*/; // 0x60B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2 /*Metadata offset 0x527D32*/; // 0x6102
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99 /*Metadata offset 0x527D5A*/; // 0x612A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737 /*Metadata offset 0x527D72*/; // 0x6142
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x527DBA*/; // 0x618A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47 /*Metadata offset 0x527DBD*/; // 0x618D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68 /*Metadata offset 0x528DBD*/; // 0x718D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC /*Metadata offset 0x528DE5*/; // 0x71B5
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E /*Metadata offset 0x52E0E9*/; // 0xC4B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760 /*Metadata offset 0x52E10D*/; // 0xC4DD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D /*Metadata offset 0x52E135*/; // 0xC505
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4 /*Metadata offset 0x52E141*/; // 0xC511
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x52E16D*/; // 0xC53D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC /*Metadata offset 0x52E170*/; // 0xC540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155 /*Metadata offset 0x52E198*/; // 0xC568
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6 /*Metadata offset 0x52E1A8*/; // 0xC578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154 /*Metadata offset 0x52E1D0*/; // 0xC5A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991 /*Metadata offset 0x52EA04*/; // 0xCDD4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x52EA2C*/; // 0xCDFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291 /*Metadata offset 0x52EB2C*/; // 0xCEFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA /*Metadata offset 0x52EDAC*/; // 0xD17C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2 /*Metadata offset 0x52EDB8*/; // 0xD188
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2 /*Metadata offset 0x52EE00*/; // 0xD1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A /*Metadata offset 0x52EE0C*/; // 0xD1DC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8 /*Metadata offset 0x52EE54*/; // 0xD224
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x52EE9C*/; // 0xD26C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24 /*Metadata offset 0x52EE9F*/; // 0xD26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x52FE9F*/; // 0xE26F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x52FEDF*/; // 0xE2AF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12 /*Metadata offset 0x52FEE2*/; // 0xE2B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396 /*Metadata offset 0x52FF0A*/; // 0xE2DA
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D = -44474084896931794; // 0xE360
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x52FF94*/; // 0xE368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959 /*Metadata offset 0x52FF97*/; // 0xE36B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F /*Metadata offset 0x53006B*/; // 0xE43F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83 /*Metadata offset 0x5300B3*/; // 0xE487
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF /*Metadata offset 0x530161*/; // 0xE535
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1 /*Metadata offset 0x53055B*/; // 0xE92F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2 /*Metadata offset 0x5305A3*/; // 0xE977
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61 /*Metadata offset 0x5305D7*/; // 0xE9AB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D /*Metadata offset 0x5305FF*/; // 0xE9D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF /*Metadata offset 0x53060F*/; // 0xE9E3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B /*Metadata offset 0x53070F*/; // 0xEAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45 /*Metadata offset 0x53170F*/; // 0xFAE3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8 /*Metadata offset 0x531AF5*/; // 0xFEC9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401 /*Metadata offset 0x531B97*/; // 0xFF6B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093 /*Metadata offset 0x531CFF*/; // 0x100D3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x531D47*/; // 0x1011B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB /*Metadata offset 0x531D5B*/; // 0x1012F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7 /*Metadata offset 0x531DA3*/; // 0x10177
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x531DCB*/; // 0x1019F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867 /*Metadata offset 0x531DCE*/; // 0x101A2
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865 = 23362753784184900; // 0x101A8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1 /*Metadata offset 0x531DDC*/; // 0x101B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD /*Metadata offset 0x531DEC*/; // 0x101C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7 /*Metadata offset 0x531E9A*/; // 0x1026E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x531EA0*/; // 0x10274
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7 /*Metadata offset 0x531EE0*/; // 0x102B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE /*Metadata offset 0x531FE0*/; // 0x103B4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x532000*/; // 0x103D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x532020*/; // 0x103F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=82 D76478B994B312CD022DCA207AA2254880D2FCC9 /*Metadata offset 0x532120*/; // 0x104F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636 /*Metadata offset 0x532172*/; // 0x10546
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219 /*Metadata offset 0x53219E*/; // 0x10572
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82 /*Metadata offset 0x5321EA*/; // 0x105BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x532222*/; // 0x105F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006 /*Metadata offset 0x532256*/; // 0x1062A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571 /*Metadata offset 0x53227A*/; // 0x1064E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x5322A2*/; // 0x10676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x5322E2*/; // 0x106B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866 /*Metadata offset 0x532316*/; // 0x106EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D /*Metadata offset 0x532322*/; // 0x106F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044 /*Metadata offset 0x532428*/; // 0x107FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x532468*/; // 0x1083C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x532472*/; // 0x10846
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37 /*Metadata offset 0x532475*/; // 0x10849
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612 /*Metadata offset 0x5324BD*/; // 0x10891
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520 /*Metadata offset 0x5324E5*/; // 0x108B9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429 /*Metadata offset 0x535243*/; // 0x13617
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B /*Metadata offset 0x5352BB*/; // 0x1368F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B /*Metadata offset 0x535303*/; // 0x136D7
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4 /*Metadata offset 0x535361*/; // 0x13735
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B /*Metadata offset 0x53536D*/; // 0x13741


	internal static uint ComputeStringHash(string s) { }

}

internal class __Il2CppComObject // TypeDefIndex: 1690
{
	protected override void Finalize() { }

}

internal sealed class __Il2CppComDelegate : __Il2CppComObject // TypeDefIndex: 1691
{
	protected override void Finalize() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1772
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C /*Metadata offset 0x535F73*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D /*Metadata offset 0x535F76*/; // 0x3
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D = -1295888024253181014; // 0x8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x535F81*/; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC /*Metadata offset 0x535F84*/; // 0x13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130 /*Metadata offset 0x535F87*/; // 0x16
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359 /*Metadata offset 0x535F95*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68 /*Metadata offset 0x535FD5*/; // 0x64
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195 /*Metadata offset 0x535FD8*/; // 0x67
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949 /*Metadata offset 0x536008*/; // 0x97
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x536012*/; // 0xA1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9 /*Metadata offset 0x53601B*/; // 0xAA
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF = 22609615381091406; // 0xCE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57 /*Metadata offset 0x536C5F*/; // 0xCF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A /*Metadata offset 0x536C62*/; // 0xCF3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003 /*Metadata offset 0x536C65*/; // 0xCF6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5 /*Metadata offset 0x536C68*/; // 0xCF9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88 /*Metadata offset 0x536CA8*/; // 0xD39
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B /*Metadata offset 0x536CAB*/; // 0xD3C
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D = 2676302836908902219; // 0xD40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8 /*Metadata offset 0x536CB6*/; // 0xD48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A /*Metadata offset 0x536CCA*/; // 0xD5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814 /*Metadata offset 0x536CCD*/; // 0xD5F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE /*Metadata offset 0x536D0D*/; // 0xD9F
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F /*Metadata offset 0x536D2D*/; // 0xDBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17 /*Metadata offset 0x536E2D*/; // 0xEBF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11 /*Metadata offset 0x536E6D*/; // 0xEFF
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3 /*Metadata offset 0x536E77*/; // 0xF09


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2431
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0701435C4E2C38EFE43C51BD22C114AB8B80124D /*Metadata offset 0x537DE1*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x537DED*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0F6A1E2CEA2FA691D57F3F3FDCF9B82A3FBF6EE1 /*Metadata offset 0x537E11*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 161F91CE1721D8F16622810CBB39887D21C47031 /*Metadata offset 0x537E55*/; // 0x74
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2051D7520B96DCC12F2E4DE851CB9F203D623805 /*Metadata offset 0x537E61*/; // 0x80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 221CE291CD044114B4369175B9B91177F5932876 /*Metadata offset 0x537E81*/; // 0xA0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x537EAD*/; // 0xCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 360487BE4278986419B568EFD887F6145383168A /*Metadata offset 0x537ED3*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 42DDBEE388AB59C20A3D7D4D6555E78D74A45AE1 /*Metadata offset 0x537EFB*/; // 0x11A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 485F43E332C2F7530815B17C08DAC169A8F697E0 /*Metadata offset 0x537F0F*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 49C5BA13401986EC93E4677F52CBE2248184DFBD /*Metadata offset 0x537F2F*/; // 0x14E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 51E4CA1C2B009A2876C6E57D8E69E3502BCA3440 /*Metadata offset 0x537F9F*/; // 0x1BE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 553E235E202D57C9F1156E7D232E02BBDC920165 /*Metadata offset 0x537FB7*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 574B9D4E4C39F6E8004181E5765B627B75EB1AD1 /*Metadata offset 0x538377*/; // 0x596
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5BE9DB9EEB9CBB4D22472CA9734B1FA1D36126BD /*Metadata offset 0x5383AF*/; // 0x5CE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98 /*Metadata offset 0x5383BB*/; // 0x5DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 68D0F86889D5D656483EEE829BCEECDFEC91D8EA /*Metadata offset 0x5383C1*/; // 0x5E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59 /*Metadata offset 0x538659*/; // 0x878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 702F6A3276CBE481D247A77C20B5459FB94D07D2 /*Metadata offset 0x5387F9*/; // 0xA18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD /*Metadata offset 0x538811*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 8B4E5E81A88D29642679AFCE41DCA380F9000462 /*Metadata offset 0x538831*/; // 0xA50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 977375E4E1ED54F588076ACA36CC17E6C2195CB9 /*Metadata offset 0x538841*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 99F0664C2AC8464B51252D92FC24F3834C6FB90C /*Metadata offset 0x538C01*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x538C0D*/; // 0xE2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 9E374D7263B2452E25DE3D6E617F6A728D98A439 /*Metadata offset 0x538C29*/; // 0xE48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 A933F173482FF50754B4942AF8DFC584EF14A45B /*Metadata offset 0x538CB9*/; // 0xED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 AB4EAD1DB94B8220FAAEDAA6A593B2E6DB0A8A9C /*Metadata offset 0x538CFD*/; // 0xF1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90 /*Metadata offset 0x538D15*/; // 0xF34
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4 /*Metadata offset 0x538EB5*/; // 0x10D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5 /*Metadata offset 0x538EDD*/; // 0x10FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C2D6E36D84DDA5D661B95D7B32D3F47CD7ACBF6C /*Metadata offset 0x538EF1*/; // 0x1110
	internal static readonly long DB9F879BE80CC2DA24DEF633D23DBB2B1ADBCC81 = 361700859878507267; // 0x1120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCF398750721AA7A27A6BA56E99350329B06E8B1 /*Metadata offset 0x538F09*/; // 0x1128
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C = 3659217647501344; // 0x1138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 ED18A4A1FF7C89B400D7CA156BA8D11BB09E1DE4 /*Metadata offset 0x538F21*/; // 0x1140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0 /*Metadata offset 0x538F45*/; // 0x1164
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 F64F25EAE9A3D7A356813C4218000185541D7779 /*Metadata offset 0x538F85*/; // 0x11A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 FB0C58D8B3094F018764CC6E3094B9576DB08069 /*Metadata offset 0x538FA9*/; // 0x11C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFE3F15642234E7FAD6951D432F1134D5AD15922 /*Metadata offset 0x539465*/; // 0x1684


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3155
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515 /*Metadata offset 0x53A61F*/; // 0x0
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF = 2533317740920864; // 0x10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A /*Metadata offset 0x53A635*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD /*Metadata offset 0x53A63E*/; // 0x21
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC /*Metadata offset 0x53A641*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 53437C3B2572EDB9B8640C3195DF3BC2729C5EA1 /*Metadata offset 0x53A64D*/; // 0x30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84 /*Metadata offset 0x53A657*/; // 0x3A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C /*Metadata offset 0x53A677*/; // 0x5A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D /*Metadata offset 0x53A67D*/; // 0x60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E /*Metadata offset 0x53A686*/; // 0x69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 8821BF2BDFF225D177372C9F3E0A8286EE241FF4 /*Metadata offset 0x53A706*/; // 0xE9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3 /*Metadata offset 0x53A70C*/; // 0xEF
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226 = 11540663026319392; // 0x120
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536 /*Metadata offset 0x53A740*/; // 0x128
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04 /*Metadata offset 0x53A760*/; // 0x148
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78 = 2533330625626144; // 0x1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A /*Metadata offset 0x53A7E8*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458 /*Metadata offset 0x53A808*/; // 0x1F0


	internal static uint ComputeStringHash(string s) { }

}

internal class EmptyEnumerable<TElement> // TypeDefIndex: 3221
{	public static readonly TElement[] Instance; // 0x0


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62F70 Offset: 0xD61570 VA: 0x180D62F70
	|-EmptyEnumerable<byte>..cctor
	|-EmptyEnumerable<object>..cctor
	*/

}

internal class IdentityFunction<TElement> // TypeDefIndex: 3222
{	public static Func<TElement, TElement> Instance { get; }


	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762200 Offset: 0x1760800 VA: 0x181762200
	|-IdentityFunction<InventoryItem>.get_Instance
	|-IdentityFunction<object>.get_Instance
	|-IdentityFunction<Resolution>.get_Instance
	*/

}

internal class Set<TElement> // TypeDefIndex: 3230
{	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0


	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1769250 Offset: 0x1767850 VA: 0x181769250
	|-Set<ServerInfo>..ctor
	|
	|-RVA: 0x1769070 Offset: 0x1767670 VA: 0x181769070
	|-Set<char>..ctor
	|
	|-RVA: 0x1768F80 Offset: 0x1767580 VA: 0x181768F80
	|-Set<object>..ctor
	|
	|-RVA: 0x1768E90 Offset: 0x1767490 VA: 0x181768E90
	|-Set<float>..ctor
	|
	|-RVA: 0x1769160 Offset: 0x1767760 VA: 0x181769160
	|-Set<Vector2>..ctor
	*/

	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1767030 Offset: 0x1765630 VA: 0x181767030
	|-Set<ServerInfo>.Add
	|
	|-RVA: 0x1767000 Offset: 0x1765600 VA: 0x181767000
	|-Set<char>.Add
	|-Set<object>.Add
	|
	|-RVA: 0x1767100 Offset: 0x1765700 VA: 0x181767100
	|-Set<float>.Add
	|
	|-RVA: 0x17670C0 Offset: 0x17656C0 VA: 0x1817670C0
	|-Set<Vector2>.Add
	*/

	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1767130 Offset: 0x1765730 VA: 0x181767130
	|-Set<ServerInfo>.Find
	|
	|-RVA: 0x1767E60 Offset: 0x1766460 VA: 0x181767E60
	|-Set<char>.Find
	|
	|-RVA: 0x1767850 Offset: 0x1765E50 VA: 0x181767850
	|-Set<object>.Find
	|
	|-RVA: 0x1767560 Offset: 0x1765B60 VA: 0x181767560
	|-Set<float>.Find
	|
	|-RVA: 0x1767B40 Offset: 0x1766140 VA: 0x181767B40
	|-Set<Vector2>.Find
	*/

	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1768920 Offset: 0x1766F20 VA: 0x181768920
	|-Set<ServerInfo>.Resize
	|
	|-RVA: 0x1768AF0 Offset: 0x17670F0 VA: 0x181768AF0
	|-Set<char>.Resize
	|
	|-RVA: 0x1768CC0 Offset: 0x17672C0 VA: 0x181768CC0
	|-Set<object>.Resize
	|
	|-RVA: 0x1768750 Offset: 0x1766D50 VA: 0x181768750
	|-Set<float>.Resize
	|
	|-RVA: 0x1768580 Offset: 0x1766B80 VA: 0x181768580
	|-Set<Vector2>.Resize
	*/

	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1768450 Offset: 0x1766A50 VA: 0x181768450
	|-Set<ServerInfo>.InternalGetHashCode
	|
	|-RVA: 0x1768160 Offset: 0x1766760 VA: 0x181768160
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x1768230 Offset: 0x1766830 VA: 0x181768230
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x1768380 Offset: 0x1766980 VA: 0x181768380
	|-Set<float>.InternalGetHashCode
	|
	|-RVA: 0x17682B0 Offset: 0x17668B0 VA: 0x1817682B0
	|-Set<Vector2>.InternalGetHashCode
	*/

}

internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 3232
{	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0


	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EDC0 Offset: 0x175D3C0 VA: 0x18175EDC0
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>..ctor
	|
	|-RVA: 0x175EED0 Offset: 0x175D4D0 VA: 0x18175EED0
	|-GroupedEnumerable<object, InventoryDefId, object>..ctor
	|
	|-RVA: 0x175EFE0 Offset: 0x175D5E0 VA: 0x18175EFE0
	|-GroupedEnumerable<object, Int32Enum, object>..ctor
	|
	|-RVA: 0x175F200 Offset: 0x175D800 VA: 0x18175F200
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x175F0F0 Offset: 0x175D6F0 VA: 0x18175F0F0
	|-GroupedEnumerable<object, uint, object>..ctor
	|
	|-RVA: 0x175F310 Offset: 0x175D910 VA: 0x18175F310
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>..ctor
	*/

	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175ED60 Offset: 0x175D360 VA: 0x18175ED60
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.GetEnumerator
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16509D0 Offset: 0x164EFD0 VA: 0x1816509D0
	|-GroupedEnumerable<InventoryItem, InventoryDefId, InventoryItem>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, InventoryDefId, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<object, uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-GroupedEnumerable<Resolution, Vector2Int, Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 3233
{	internal IEnumerable<TElement> source; // 0x0


	[IteratorStateMachineAttribute] // RVA: 0xD1AA0 Offset: 0xD0EA0 VA: 0x1800D1AA0
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1765460 Offset: 0x1763A60 VA: 0x181765460
	|-OrderedEnumerable<Demos.DemoInfo>.GetEnumerator
	|
	|-RVA: 0x17653D0 Offset: 0x17639D0 VA: 0x1817653D0
	|-OrderedEnumerable<ServerInfo>.GetEnumerator
	|
	|-RVA: 0x1765220 Offset: 0x1763820 VA: 0x181765220
	|-OrderedEnumerable<Item>.GetEnumerator
	|
	|-RVA: 0x17652B0 Offset: 0x17638B0 VA: 0x1817652B0
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x1765340 Offset: 0x1763940 VA: 0x181765340
	|-OrderedEnumerable<double>.GetEnumerator
	|-OrderedEnumerable<object>.GetEnumerator
	|-OrderedEnumerable<Resolution>.GetEnumerator
	*/

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<object>.GetEnumerableSorter
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355360 Offset: 0x1353960 VA: 0x181355360
	|-OrderedEnumerable<Demos.DemoInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<ServerInfo>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Item>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, long>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<double>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|-OrderedEnumerable<Resolution>.System.Collections.IEnumerable.GetEnumerator
	*/

	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7D70 Offset: 0xED6370 VA: 0x180ED7D70
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<DateTime>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<Int32Enum>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<object>
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<uint>
	|-OrderedEnumerable<Resolution>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-OrderedEnumerable<Demos.DemoInfo>..ctor
	|-OrderedEnumerable<ServerInfo>..ctor
	|-OrderedEnumerable<Item>..ctor
	|-OrderedEnumerable<KeyValuePair<object, int>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, long>>..ctor
	|-OrderedEnumerable<KeyValuePair<object, object>>..ctor
	|-OrderedEnumerable<double>..ctor
	|-OrderedEnumerable<object>..ctor
	|-OrderedEnumerable<Resolution>..ctor
	*/

}

internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 3235
{	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0


	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1765E80 Offset: 0x1764480 VA: 0x181765E80
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>..ctor
	|
	|-RVA: 0x1766D80 Offset: 0x1765380 VA: 0x181766D80
	|-OrderedEnumerable<Demos.DemoInfo, object>..ctor
	|
	|-RVA: 0x1766600 Offset: 0x1764C00 VA: 0x181766600
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>..ctor
	|
	|-RVA: 0x1766740 Offset: 0x1764D40 VA: 0x181766740
	|-OrderedEnumerable<ServerInfo, int>..ctor
	|
	|-RVA: 0x1765D40 Offset: 0x1764340 VA: 0x181765D40
	|-OrderedEnumerable<ServerInfo, object>..ctor
	|
	|-RVA: 0x1765FC0 Offset: 0x17645C0 VA: 0x181765FC0
	|-OrderedEnumerable<ServerInfo, uint>..ctor
	|
	|-RVA: 0x1765AC0 Offset: 0x17640C0 VA: 0x181765AC0
	|-OrderedEnumerable<Item, DateTime>..ctor
	|
	|-RVA: 0x17664C0 Offset: 0x1764AC0 VA: 0x1817664C0
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x17669C0 Offset: 0x1764FC0 VA: 0x1817669C0
	|-OrderedEnumerable<KeyValuePair<object, long>, long>..ctor
	|
	|-RVA: 0x1765C00 Offset: 0x1764200 VA: 0x181765C00
	|-OrderedEnumerable<KeyValuePair<object, object>, long>..ctor
	|
	|-RVA: 0x1765700 Offset: 0x1763D00 VA: 0x181765700
	|-OrderedEnumerable<double, double>..ctor
	|
	|-RVA: 0x1766B00 Offset: 0x1765100 VA: 0x181766B00
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0x1766380 Offset: 0x1764980 VA: 0x181766380
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0x17655C0 Offset: 0x1763BC0 VA: 0x1817655C0
	|-OrderedEnumerable<object, DateTimeOffset>..ctor
	|
	|-RVA: 0x1766100 Offset: 0x1764700 VA: 0x181766100
	|-OrderedEnumerable<object, Guid>..ctor
	|
	|-RVA: 0x1765980 Offset: 0x1763F80 VA: 0x181765980
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x1766240 Offset: 0x1764840 VA: 0x181766240
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x1766880 Offset: 0x1764E80 VA: 0x181766880
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x1765840 Offset: 0x1763E40 VA: 0x181765840
	|-OrderedEnumerable<object, float>..ctor
	|
	|-RVA: 0x1766C40 Offset: 0x1765240 VA: 0x181766C40
	|-OrderedEnumerable<object, uint>..ctor
	|
	|-RVA: 0x1766EC0 Offset: 0x17654C0 VA: 0x181766EC0
	|-OrderedEnumerable<Resolution, int>..ctor
	*/

	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17654F0 Offset: 0x1763AF0 VA: 0x1817654F0
	|-OrderedEnumerable<Demos.DemoInfo, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<Demos.DemoInfo, TimeSpan>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, int>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, object>.GetEnumerableSorter
	|-OrderedEnumerable<ServerInfo, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Item, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, int>, int>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, long>, long>.GetEnumerableSorter
	|-OrderedEnumerable<KeyValuePair<object, object>, long>.GetEnumerableSorter
	|-OrderedEnumerable<double, double>.GetEnumerableSorter
	|-OrderedEnumerable<object, bool>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTime>.GetEnumerableSorter
	|-OrderedEnumerable<object, DateTimeOffset>.GetEnumerableSorter
	|-OrderedEnumerable<object, Guid>.GetEnumerableSorter
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|-OrderedEnumerable<object, uint>.GetEnumerableSorter
	|-OrderedEnumerable<Resolution, int>.GetEnumerableSorter
	*/

}

internal struct Buffer<TElement> // TypeDefIndex: 3238
{	internal TElement[] items; // 0x0
	internal int count; // 0x0


	internal void .ctor(IEnumerable<TElement> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2208A0 Offset: 0x21FCA0 VA: 0x1802208A0
	|-Buffer<Debugging.EntityInfo>..ctor
	|
	|-RVA: 0x2208D0 Offset: 0x21FCD0 VA: 0x1802208D0
	|-Buffer<Demos.DemoInfo>..ctor
	|
	|-RVA: 0x220970 Offset: 0x21FD70 VA: 0x180220970
	|-Buffer<GameStat.Stat>..ctor
	|
	|-RVA: 0x220830 Offset: 0x21FC30 VA: 0x180220830
	|-Buffer<ItemSkinDirectory.Skin>..ctor
	|
	|-RVA: 0x220850 Offset: 0x21FC50 VA: 0x180220850
	|-Buffer<FourBitNumber>..ctor
	|
	|-RVA: 0x220890 Offset: 0x21FC90 VA: 0x180220890
	|-Buffer<SevenBitNumber>..ctor
	|
	|-RVA: 0x220960 Offset: 0x21FD60 VA: 0x180220960
	|-Buffer<Option>..ctor
	|
	|-RVA: 0x220930 Offset: 0x21FD30 VA: 0x180220930
	|-Buffer<ServerInfo>..ctor
	|
	|-RVA: 0x220860 Offset: 0x21FC60 VA: 0x180220860
	|-Buffer<SkinnedMultiMesh.Part>..ctor
	|
	|-RVA: 0x220910 Offset: 0x21FD10 VA: 0x180220910
	|-Buffer<InventoryDefId>..ctor
	|
	|-RVA: 0x220980 Offset: 0x21FD80 VA: 0x180220980
	|-Buffer<InventoryItemId>..ctor
	|
	|-RVA: 0x220840 Offset: 0x21FC40 VA: 0x180220840
	|-Buffer<InventoryItem>..ctor
	|
	|-RVA: 0x220940 Offset: 0x21FD40 VA: 0x180220940
	|-Buffer<InventoryRecipe.Ingredient>..ctor
	|
	|-RVA: 0x2208F0 Offset: 0x21FCF0 VA: 0x1802208F0
	|-Buffer<InventoryRecipe>..ctor
	|
	|-RVA: 0x220880 Offset: 0x21FC80 VA: 0x180220880
	|-Buffer<Item>..ctor
	|
	|-RVA: 0x2208E0 Offset: 0x21FCE0 VA: 0x1802208E0
	|-Buffer<byte>..ctor
	|
	|-RVA: 0x220950 Offset: 0x21FD50 VA: 0x180220950
	|-Buffer<char>..ctor
	|
	|-RVA: 0x2208B0 Offset: 0x21FCB0 VA: 0x1802208B0
	|-Buffer<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x220900 Offset: 0x21FD00 VA: 0x180220900
	|-Buffer<KeyValuePair<object, long>>..ctor
	|
	|-RVA: 0x2208C0 Offset: 0x21FCC0 VA: 0x1802208C0
	|-Buffer<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x220990 Offset: 0x21FD90 VA: 0x180220990
	|-Buffer<double>..ctor
	|
	|-RVA: 0x220800 Offset: 0x21FC00 VA: 0x180220800
	|-Buffer<int>..ctor
	|
	|-RVA: 0x220870 Offset: 0x21FC70 VA: 0x180220870
	|-Buffer<Int32Enum>..ctor
	|
	|-RVA: 0x220920 Offset: 0x21FD20 VA: 0x180220920
	|-Buffer<long>..ctor
	|
	|-RVA: 0x2209A0 Offset: 0x21FDA0 VA: 0x1802209A0
	|-Buffer<object>..ctor
	|
	|-RVA: 0x220810 Offset: 0x21FC10 VA: 0x180220810
	|-Buffer<uint>..ctor
	|
	|-RVA: 0x220820 Offset: 0x21FC20 VA: 0x180220820
	|-Buffer<Resolution>..ctor
	*/

	internal TElement[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220700 Offset: 0x21FB00 VA: 0x180220700
	|-Buffer<Debugging.EntityInfo>.ToArray
	|-Buffer<Demos.DemoInfo>.ToArray
	|-Buffer<GameStat.Stat>.ToArray
	|-Buffer<ItemSkinDirectory.Skin>.ToArray
	|-Buffer<FourBitNumber>.ToArray
	|-Buffer<SevenBitNumber>.ToArray
	|-Buffer<Option>.ToArray
	|-Buffer<ServerInfo>.ToArray
	|-Buffer<SkinnedMultiMesh.Part>.ToArray
	|-Buffer<InventoryDefId>.ToArray
	|-Buffer<InventoryItemId>.ToArray
	|-Buffer<InventoryItem>.ToArray
	|-Buffer<InventoryRecipe.Ingredient>.ToArray
	|-Buffer<InventoryRecipe>.ToArray
	|-Buffer<Item>.ToArray
	|-Buffer<byte>.ToArray
	|-Buffer<char>.ToArray
	|-Buffer<KeyValuePair<object, int>>.ToArray
	|-Buffer<KeyValuePair<object, long>>.ToArray
	|-Buffer<KeyValuePair<object, object>>.ToArray
	|-Buffer<double>.ToArray
	|-Buffer<int>.ToArray
	|-Buffer<Int32Enum>.ToArray
	|-Buffer<long>.ToArray
	|-Buffer<object>.ToArray
	|-Buffer<uint>.ToArray
	|-Buffer<Resolution>.ToArray
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3258
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93 /*Metadata offset 0x53AA9F*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939 /*Metadata offset 0x53AB17*/; // 0x78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11 /*Metadata offset 0x53AC17*/; // 0x178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E /*Metadata offset 0x53B017*/; // 0x578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94 /*Metadata offset 0x53B417*/; // 0x978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47 /*Metadata offset 0x53B817*/; // 0xD78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D /*Metadata offset 0x53BC17*/; // 0x1178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E /*Metadata offset 0x53C017*/; // 0x1578
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3 /*Metadata offset 0x53C417*/; // 0x1978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53 /*Metadata offset 0x53C517*/; // 0x1A78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9 /*Metadata offset 0x53C917*/; // 0x1E78

}

public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 3307
{	[ReadOnlyAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal NativeArray<CommandT> commands; // 0x0
	internal NativeArray<ResultT> results; // 0x0


	public void .ctor(NativeArray<CommandT> commands, NativeArray<ResultT> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F9C60 Offset: 0x1F9060 VA: 0x1801F9C60
	|-BatchQueryJob<RaycastCommand, RaycastHit>..ctor
	*/

}

internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 3629
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private UnityAction<T1> Delegate; // 0x0


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF540 Offset: 0x17ADB40 VA: 0x1817AF540
	|-InvokableCall<Option>.add_Delegate
	|-InvokableCall<bool>.add_Delegate
	|-InvokableCall<int>.add_Delegate
	|-InvokableCall<Int32Enum>.add_Delegate
	|-InvokableCall<object>.add_Delegate
	|-InvokableCall<float>.add_Delegate
	|-InvokableCall<Color>.add_Delegate
	|-InvokableCall<Vector2>.add_Delegate
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF600 Offset: 0x17ADC00 VA: 0x1817AF600
	|-InvokableCall<Option>.remove_Delegate
	|-InvokableCall<bool>.remove_Delegate
	|-InvokableCall<int>.remove_Delegate
	|-InvokableCall<Int32Enum>.remove_Delegate
	|-InvokableCall<object>.remove_Delegate
	|-InvokableCall<float>.remove_Delegate
	|-InvokableCall<Color>.remove_Delegate
	|-InvokableCall<Vector2>.remove_Delegate
	*/

	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AEDC0 Offset: 0x17AD3C0 VA: 0x1817AEDC0
	|-InvokableCall<Option>..ctor
	|
	|-RVA: 0x17AF410 Offset: 0x17ADA10 VA: 0x1817AF410
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x17AEEF0 Offset: 0x17AD4F0 VA: 0x1817AEEF0
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x17AF1B0 Offset: 0x17AD7B0 VA: 0x1817AF1B0
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x17AF080 Offset: 0x17AD680 VA: 0x1817AF080
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x17AF2E0 Offset: 0x17AD8E0 VA: 0x1817AF2E0
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x19AB170 Offset: 0x19A9770 VA: 0x1819AB170
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x19AB040 Offset: 0x19A9640 VA: 0x1819AB040
	|-InvokableCall<Vector2>..ctor
	*/

	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF020 Offset: 0x17AD620 VA: 0x1817AF020
	|-InvokableCall<Option>..ctor
	|-InvokableCall<bool>..ctor
	|-InvokableCall<int>..ctor
	|-InvokableCall<Int32Enum>..ctor
	|-InvokableCall<object>..ctor
	|-InvokableCall<float>..ctor
	|-InvokableCall<Color>..ctor
	|-InvokableCall<Vector2>..ctor
	*/

	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE7D0 Offset: 0x17ACDD0 VA: 0x1817AE7D0
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17AEB40 Offset: 0x17AD140 VA: 0x1817AEB40
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17AE5D0 Offset: 0x17ACBD0 VA: 0x1817AE5D0
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x17AE9A0 Offset: 0x17ACFA0 VA: 0x1817AE9A0
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AEC80 Offset: 0x17AD280 VA: 0x1817AEC80
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17AE430 Offset: 0x17ACA30 VA: 0x1817AE430
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19AACC0 Offset: 0x19A92C0 VA: 0x1819AACC0
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19AAE10 Offset: 0x19A9410 VA: 0x1819AAE10
	|-InvokableCall<Vector2>.Invoke
	*/

	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE930 Offset: 0x17ACF30 VA: 0x1817AE930
	|-InvokableCall<Option>.Invoke
	|
	|-RVA: 0x17AE710 Offset: 0x17ACD10 VA: 0x1817AE710
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x17AE770 Offset: 0x17ACD70 VA: 0x1817AE770
	|-InvokableCall<int>.Invoke
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x17AEAE0 Offset: 0x17AD0E0 VA: 0x1817AEAE0
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x17AE570 Offset: 0x17ACB70 VA: 0x1817AE570
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x19AAF60 Offset: 0x19A9560 VA: 0x1819AAF60
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x19AAFD0 Offset: 0x19A95D0 VA: 0x1819AAFD0
	|-InvokableCall<Vector2>.Invoke
	*/

	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE3D0 Offset: 0x17AC9D0 VA: 0x1817AE3D0
	|-InvokableCall<Option>.Find
	|-InvokableCall<bool>.Find
	|-InvokableCall<int>.Find
	|-InvokableCall<Int32Enum>.Find
	|-InvokableCall<object>.Find
	|-InvokableCall<float>.Find
	|-InvokableCall<Color>.Find
	|-InvokableCall<Vector2>.Find
	*/

}

public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 3641
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<Option>..ctor
	|-UnityAction<bool>..ctor
	|-UnityAction<List<IEventSystemHandler>>..ctor
	|-UnityAction<int>..ctor
	|-UnityAction<Int32Enum>..ctor
	|-UnityAction<object>..ctor
	|-UnityAction<float>..ctor
	|-UnityAction<string>..ctor
	|-UnityAction<Color>..ctor
	|-UnityAction<Component>..ctor
	|-UnityAction<MessageEventArgs>..ctor
	|-UnityAction<Scene>..ctor
	|-UnityAction<LayoutRebuilder>..ctor
	|-UnityAction<Vector2>..ctor
	*/

	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B5FF0 Offset: 0x19B45F0 VA: 0x1819B5FF0
	|-UnityAction<Option>.Invoke
	|
	|-RVA: 0x19B5A90 Offset: 0x19B4090 VA: 0x1819B5A90
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x19B58A0 Offset: 0x19B3EA0 VA: 0x1819B58A0
	|-UnityAction<int>.Invoke
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x19B5580 Offset: 0x19B3B80 VA: 0x1819B5580
	|-UnityAction<object>.Invoke
	|-UnityAction<Component>.Invoke
	|
	|-RVA: 0x19B4FC0 Offset: 0x19B35C0 VA: 0x1819B4FC0
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x12A5FF0 Offset: 0x12A45F0 VA: 0x1812A5FF0
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x19B52A0 Offset: 0x19B38A0 VA: 0x1819B52A0
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x19B5D10 Offset: 0x19B4310 VA: 0x1819B5D10
	|-UnityAction<Vector2>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4C40 Offset: 0x19B3240 VA: 0x1819B4C40
	|-UnityAction<Option>.BeginInvoke
	|
	|-RVA: 0x19B4D40 Offset: 0x19B3340 VA: 0x1819B4D40
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x19B4CC0 Offset: 0x19B32C0 VA: 0x1819B4CC0
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x19B4BC0 Offset: 0x19B31C0 VA: 0x1819B4BC0
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x19B4EC0 Offset: 0x19B34C0 VA: 0x1819B4EC0
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x19B4F40 Offset: 0x19B3540 VA: 0x1819B4F40
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x19B4DC0 Offset: 0x19B33C0 VA: 0x1819B4DC0
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x19B4E40 Offset: 0x19B3440 VA: 0x1819B4E40
	|-UnityAction<Vector2>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<Option>.EndInvoke
	|-UnityAction<bool>.EndInvoke
	|-UnityAction<int>.EndInvoke
	|-UnityAction<Int32Enum>.EndInvoke
	|-UnityAction<object>.EndInvoke
	|-UnityAction<float>.EndInvoke
	|-UnityAction<Color>.EndInvoke
	|-UnityAction<Scene>.EndInvoke
	|-UnityAction<Vector2>.EndInvoke
	*/

}

public abstract class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3642
{	private object[] m_InvokeArray; // 0x0


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9490 Offset: 0x19B7A90 VA: 0x1819B9490
	|-UnityEvent<Brush>..ctor
	|-UnityEvent<Option>..ctor
	|-UnityEvent<bool>..ctor
	|-UnityEvent<int>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<float>..ctor
	|-UnityEvent<string>..ctor
	|-UnityEvent<Color>..ctor
	|-UnityEvent<BaseEventData>..ctor
	|-UnityEvent<MessageEventArgs>..ctor
	|-UnityEvent<TouchScreenKeyboard.Status>..ctor
	|-UnityEvent<Vector2>..ctor
	*/

	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7620 Offset: 0x19B5C20 VA: 0x1819B7620
	|-UnityEvent<Option>.AddListener
	|-UnityEvent<bool>.AddListener
	|-UnityEvent<int>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<float>.AddListener
	|-UnityEvent<string>.AddListener
	|-UnityEvent<Color>.AddListener
	|-UnityEvent<MessageEventArgs>.AddListener
	|-UnityEvent<Vector2>.AddListener
	*/

	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9440 Offset: 0x19B7A40 VA: 0x1819B9440
	|-UnityEvent<Option>.RemoveListener
	|-UnityEvent<bool>.RemoveListener
	|-UnityEvent<int>.RemoveListener
	|-UnityEvent<Int32Enum>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<float>.RemoveListener
	|-UnityEvent<Color>.RemoveListener
	|-UnityEvent<MessageEventArgs>.RemoveListener
	|-UnityEvent<Vector2>.RemoveListener
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7CC0 Offset: 0x19B62C0 VA: 0x1819B7CC0
	|-UnityEvent<Brush>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-RVA: 0x19B7660 Offset: 0x19B5C60 VA: 0x1819B7660
	|-UnityEvent<Option>.FindMethod_Impl
	|
	|-RVA: 0x19B7990 Offset: 0x19B5F90 VA: 0x1819B7990
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x19B7880 Offset: 0x19B5E80 VA: 0x1819B7880
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x19B7BB0 Offset: 0x19B61B0 VA: 0x1819B7BB0
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x19B7770 Offset: 0x19B5D70 VA: 0x1819B7770
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x19B7AA0 Offset: 0x19B60A0 VA: 0x1819B7AA0
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x19B7DD0 Offset: 0x19B63D0 VA: 0x1819B7DD0
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7EE0 Offset: 0x19B64E0 VA: 0x1819B7EE0
	|-UnityEvent<Brush>.GetDelegate
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<string>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<BaseEventData>.GetDelegate
	|-UnityEvent<MessageEventArgs>.GetDelegate
	|-UnityEvent<TouchScreenKeyboard.Status>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7F60 Offset: 0x19B6560 VA: 0x1819B7F60
	|-UnityEvent<Option>.GetDelegate
	|-UnityEvent<bool>.GetDelegate
	|-UnityEvent<int>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<float>.GetDelegate
	|-UnityEvent<Color>.GetDelegate
	|-UnityEvent<Vector2>.GetDelegate
	*/

	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B8030 Offset: 0x19B6630 VA: 0x1819B8030
	|-UnityEvent<Brush>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-RVA: 0x19B8A00 Offset: 0x19B7000 VA: 0x1819B8A00
	|-UnityEvent<Option>.Invoke
	|
	|-RVA: 0x19B8CC0 Offset: 0x19B72C0 VA: 0x1819B8CC0
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x19B8F40 Offset: 0x19B7540 VA: 0x1819B8F40
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x19B8260 Offset: 0x19B6860 VA: 0x1819B8260
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x19B8780 Offset: 0x19B6D80 VA: 0x1819B8780
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x19B84E0 Offset: 0x19B6AE0 VA: 0x1819B84E0
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x19B91C0 Offset: 0x19B77C0 VA: 0x1819B91C0
	|-UnityEvent<Vector2>.Invoke
	*/

}

public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3643
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, object>..ctor
	|-UnityAction<ulong, object>..ctor
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|-UnityAction<Scene, Scene>..ctor
	|-UnityAction<Vector2, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111F70 Offset: 0x1110570 VA: 0x181111F70
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x19B65D0 Offset: 0x19B4BD0 VA: 0x1819B65D0
	|-UnityAction<ulong, object>.Invoke
	|
	|-RVA: 0x19B6F10 Offset: 0x19B5510 VA: 0x1819B6F10
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x19B6900 Offset: 0x19B4F00 VA: 0x1819B6900
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-RVA: 0x19B6C10 Offset: 0x19B5210 VA: 0x1819B6C10
	|-UnityAction<Vector2, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4E10 Offset: 0xAE3410 VA: 0x180AE4E10
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x19B64B0 Offset: 0x19B4AB0 VA: 0x1819B64B0
	|-UnityAction<ulong, object>.BeginInvoke
	|
	|-RVA: 0x19B6420 Offset: 0x19B4A20 VA: 0x1819B6420
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x19B6540 Offset: 0x19B4B40 VA: 0x1819B6540
	|-UnityAction<Scene, Scene>.BeginInvoke
	|
	|-RVA: 0x19B6390 Offset: 0x19B4990 VA: 0x1819B6390
	|-UnityAction<Vector2, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, object>.EndInvoke
	|-UnityAction<ulong, object>.EndInvoke
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|-UnityAction<Scene, Scene>.EndInvoke
	|-UnityAction<Vector2, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 3644
{	private object[] m_InvokeArray; // 0x0


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9490 Offset: 0x19B7A90 VA: 0x1819B9490
	|-UnityEvent<object, object>..ctor
	|-UnityEvent<ulong, object>..ctor
	|-UnityEvent<ulong, string>..ctor
	|-UnityEvent<Vector2, Brush>..ctor
	|-UnityEvent<Vector2, object>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B94C0 Offset: 0x19B7AC0 VA: 0x1819B94C0
	|-UnityEvent<object, object>.FindMethod_Impl
	|
	|-RVA: 0x19B97E0 Offset: 0x19B7DE0 VA: 0x1819B97E0
	|-UnityEvent<ulong, object>.FindMethod_Impl
	|-UnityEvent<ulong, string>.FindMethod_Impl
	|
	|-RVA: 0x19B9650 Offset: 0x19B7C50 VA: 0x1819B9650
	|-UnityEvent<Vector2, Brush>.FindMethod_Impl
	|-UnityEvent<Vector2, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9970 Offset: 0x19B7F70 VA: 0x1819B9970
	|-UnityEvent<object, object>.GetDelegate
	|-UnityEvent<ulong, object>.GetDelegate
	|-UnityEvent<ulong, string>.GetDelegate
	|-UnityEvent<Vector2, Brush>.GetDelegate
	|-UnityEvent<Vector2, object>.GetDelegate
	*/

	public void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9FF0 Offset: 0x19B85F0 VA: 0x1819B9FF0
	|-UnityEvent<object, object>.Invoke
	|
	|-RVA: 0x19B99F0 Offset: 0x19B7FF0 VA: 0x1819B99F0
	|-UnityEvent<ulong, object>.Invoke
	|-UnityEvent<ulong, string>.Invoke
	|
	|-RVA: 0x19B9CF0 Offset: 0x19B82F0 VA: 0x1819B9CF0
	|-UnityEvent<Vector2, Brush>.Invoke
	|-UnityEvent<Vector2, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3645
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, int, int>..ctor
	|-UnityAction<object, object, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13490B0 Offset: 0x13476B0 VA: 0x1813490B0
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x19B72C0 Offset: 0x19B58C0 VA: 0x1819B72C0
	|-UnityAction<object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7220 Offset: 0x19B5820 VA: 0x1819B7220
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x12C3AE0 Offset: 0x12C20E0 VA: 0x1812C3AE0
	|-UnityAction<object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, int, int>.EndInvoke
	|-UnityAction<object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 3646
{	private object[] m_InvokeArray; // 0x0


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9490 Offset: 0x19B7A90 VA: 0x1819B9490
	|-UnityEvent<object, int, int>..ctor
	|-UnityEvent<object, object, object>..ctor
	|-UnityEvent<string, int, int>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BA290 Offset: 0x19B8890 VA: 0x1819BA290
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|-UnityEvent<string, int, int>.FindMethod_Impl
	|
	|-RVA: 0x19BA490 Offset: 0x19B8A90 VA: 0x1819BA490
	|-UnityEvent<object, object, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7EE0 Offset: 0x19B64E0 VA: 0x1819B7EE0
	|-UnityEvent<object, int, int>.GetDelegate
	|-UnityEvent<object, object, object>.GetDelegate
	|-UnityEvent<string, int, int>.GetDelegate
	*/

	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BA9B0 Offset: 0x19B8FB0 VA: 0x1819BA9B0
	|-UnityEvent<object, int, int>.Invoke
	|-UnityEvent<string, int, int>.Invoke
	|
	|-RVA: 0x19BA690 Offset: 0x19B8C90 VA: 0x1819BA690
	|-UnityEvent<object, object, object>.Invoke
	*/

}

public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3647
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-UnityAction<object, object, object, object>..ctor
	*/

	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C4020 Offset: 0x12C2620 VA: 0x1812C4020
	|-UnityAction<object, object, object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFA1A0 Offset: 0xFF87A0 VA: 0x180FFA1A0
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-UnityAction<object, object, object, object>.EndInvoke
	*/

}

public abstract class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 3648
{	private object[] m_InvokeArray; // 0x0


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B9490 Offset: 0x19B7A90 VA: 0x1819B9490
	|-UnityEvent<object, object, object, object>..ctor
	*/

	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAD60 Offset: 0x19B9360 VA: 0x1819BAD60
	|-UnityEvent<object, object, object, object>.FindMethod_Impl
	*/

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19BAFD0 Offset: 0x19B95D0 VA: 0x1819BAFD0
	|-UnityEvent<object, object, object, object>.GetDelegate
	*/

}

public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 3941
{
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645500 Offset: 0x1643B00 VA: 0x181645500
	|-IntegratedSubsystemDescriptor<object>..ctor
	|-IntegratedSubsystemDescriptor<XRDisplaySubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRInputSubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRMeshSubsystem>..ctor
	*/

}

public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 3947
{
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645500 Offset: 0x1643B00 VA: 0x181645500
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4066
{
	internal static uint ComputeStringHash(string s) { }

}

internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 4286
{	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }


	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareNode
	*/

	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<object>.CompareSateliteTreeNode
	*/

	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A4D0 Offset: 0x1788AD0 VA: 0x18178A4D0
	|-RBTree<DataRow>..ctor
	|-RBTree<int>..ctor
	|-RBTree<object>..ctor
	*/

	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786600 Offset: 0x1784C00 VA: 0x181786600
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x20CA110 Offset: 0x20C8710 VA: 0x1820CA110
	|-RBTree<object>.InitTree
	*/

	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17858F0 Offset: 0x1783EF0 VA: 0x1817858F0
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	*/

	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784970 Offset: 0x1782F70 VA: 0x181784970
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x20C8D50 Offset: 0x20C7350 VA: 0x1820C8D50
	|-RBTree<object>.AllocPage
	*/

	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786F30 Offset: 0x1785530 VA: 0x181786F30
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	*/

	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786E70 Offset: 0x1785470 VA: 0x181786E70
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	*/

	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785EE0 Offset: 0x17844E0 VA: 0x181785EE0
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	*/

	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785750 Offset: 0x1783D50 VA: 0x181785750
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x20C9540 Offset: 0x20C7B40 VA: 0x1820C9540
	|-RBTree<object>.FreeNode
	*/

	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785CE0 Offset: 0x17842E0 VA: 0x181785CE0
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x20C98B0 Offset: 0x20C7EB0 VA: 0x1820C98B0
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A5A0 Offset: 0x1788BA0 VA: 0x18178A5A0
	|-RBTree<DataRow>.get_Count
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	*/

	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A5B0 Offset: 0x1788BB0 VA: 0x18178A5B0
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	*/

	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785F50 Offset: 0x1784550 VA: 0x181785F50
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x20C9AB0 Offset: 0x20C80B0 VA: 0x1820C9AB0
	|-RBTree<object>.GetNewNode
	*/

	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A300 Offset: 0x1788900 VA: 0x18178A300
	|-RBTree<int>.Successor
	|-RBTree<object>.Successor
	*/

	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A1A0 Offset: 0x17887A0 VA: 0x18178A1A0
	|-RBTree<int>.Successor
	|
	|-RVA: 0x20CDA20 Offset: 0x20CC020 VA: 0x1820CDA20
	|-RBTree<object>.Successor
	*/

	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786FF0 Offset: 0x17855F0 VA: 0x181786FF0
	|-RBTree<int>.Minimum
	|-RBTree<object>.Minimum
	*/

	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786930 Offset: 0x1784F30 VA: 0x181786930
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x20CA410 Offset: 0x20C8A10 VA: 0x1820CA410
	|-RBTree<object>.LeftRotate
	*/

	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17897E0 Offset: 0x1787DE0 VA: 0x1817897E0
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x20CD050 Offset: 0x20CB650 VA: 0x1820CD050
	|-RBTree<object>.RightRotate
	*/

	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17886E0 Offset: 0x1786CE0 VA: 0x1817886E0
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x20CBF80 Offset: 0x20CA580 VA: 0x1820CBF80
	|-RBTree<object>.RBInsert
	*/

	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A400 Offset: 0x1788A00 VA: 0x18178A400
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x20CDB80 Offset: 0x20CC180 VA: 0x1820CDB80
	|-RBTree<object>.UpdateNodeKey
	*/

	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17856A0 Offset: 0x1783CA0 VA: 0x1817856A0
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x20C9490 Offset: 0x20C7A90 VA: 0x1820C9490
	|-RBTree<object>.DeleteByIndex
	*/

	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17886A0 Offset: 0x1786CA0 VA: 0x1817886A0
	|-RBTree<DataRow>.RBDelete
	|-RBTree<int>.RBDelete
	|-RBTree<object>.RBDelete
	*/

	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787A20 Offset: 0x1786020 VA: 0x181787A20
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x20CB300 Offset: 0x20C9900 VA: 0x1820CB300
	|-RBTree<object>.RBDeleteX
	*/

	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787150 Offset: 0x1785750 VA: 0x181787150
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x20CAA30 Offset: 0x20C9030 VA: 0x1820CAA30
	|-RBTree<object>.RBDeleteFixup
	*/

	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789D10 Offset: 0x1788310 VA: 0x181789D10
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x20CD580 Offset: 0x20CBB80 VA: 0x1820CD580
	|-RBTree<object>.SearchSubTree
	*/

	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A5C0 Offset: 0x1788BC0 VA: 0x18178A5C0
	|-RBTree<DataRow>.get_Item
	|-RBTree<int>.get_Item
	|-RBTree<object>.get_Item
	*/

	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17862D0 Offset: 0x17848D0 VA: 0x1817862D0
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x20C9E60 Offset: 0x20C8460 VA: 0x1820C9E60
	|-RBTree<object>.GetNodeByKey
	*/

	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785A50 Offset: 0x1784050 VA: 0x181785A50
	|-RBTree<int>.GetIndexByKey
	|-RBTree<object>.GetIndexByKey
	*/

	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785B90 Offset: 0x1784190 VA: 0x181785B90
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x20C9760 Offset: 0x20C7D60 VA: 0x1820C9760
	|-RBTree<object>.GetIndexByNode
	*/

	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785AD0 Offset: 0x17840D0 VA: 0x181785AD0
	|-RBTree<int>.GetIndexByNodePath
	|-RBTree<object>.GetIndexByNodePath
	*/

	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784D10 Offset: 0x1783310 VA: 0x181784D10
	|-RBTree<int>.ComputeIndexByNode
	|-RBTree<object>.ComputeIndexByNode
	*/

	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784E30 Offset: 0x1783430 VA: 0x181784E30
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	*/

	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17861F0 Offset: 0x17847F0 VA: 0x1817861F0
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x20C9D60 Offset: 0x20C8360 VA: 0x1820C9D60
	|-RBTree<object>.GetNodeByIndex
	*/

	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784FB0 Offset: 0x17835B0 VA: 0x181784FB0
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17851D0 Offset: 0x17837D0 VA: 0x1817851D0
	|-RBTree<int>.ComputeNodeByIndex
	|-RBTree<object>.ComputeNodeByIndex
	*/

	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17848F0 Offset: 0x1782EF0 VA: 0x1817848F0
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17848F0 Offset: 0x1782EF0 VA: 0x1817848F0
	|-RBTree<DataRow>.Add
	|-RBTree<int>.Add
	|-RBTree<object>.Add
	*/

	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C96E0 Offset: 0x20C7CE0 VA: 0x1820C96E0
	|-RBTree<DataRow>.GetEnumerator
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x17859A0 Offset: 0x1783FA0 VA: 0x1817859A0
	|-RBTree<int>.GetEnumerator
	*/

	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20CA010 Offset: 0x20C8610 VA: 0x1820CA010
	|-RBTree<DataRow>.IndexOf
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x1786470 Offset: 0x1784A70 VA: 0x181786470
	|-RBTree<int>.IndexOf
	*/

	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786890 Offset: 0x1784E90 VA: 0x181786890
	|-RBTree<DataRow>.Insert
	|-RBTree<int>.Insert
	|-RBTree<object>.Insert
	*/

	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17867F0 Offset: 0x1784DF0 VA: 0x1817867F0
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x20CA300 Offset: 0x20C8900 VA: 0x1820CA300
	|-RBTree<object>.InsertAt
	*/

	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17897B0 Offset: 0x1787DB0 VA: 0x1817897B0
	|-RBTree<DataRow>.RemoveAt
	|-RBTree<int>.RemoveAt
	|-RBTree<object>.RemoveAt
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784CE0 Offset: 0x17832E0 VA: 0x181784CE0
	|-RBTree<DataRow>.Clear
	|-RBTree<int>.Clear
	|-RBTree<object>.Clear
	*/

	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C90C0 Offset: 0x20C76C0 VA: 0x1820C90C0
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1785440 Offset: 0x1783A40 VA: 0x181785440
	|-RBTree<int>.CopyTo
	*/

	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20C9260 Offset: 0x20C7860 VA: 0x1820C9260
	|-RBTree<DataRow>.CopyTo
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x1785290 Offset: 0x1783890 VA: 0x181785290
	|-RBTree<int>.CopyTo
	*/

	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A050 Offset: 0x1788650 VA: 0x18178A050
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x20CD8D0 Offset: 0x20CBED0 VA: 0x1820CD8D0
	|-RBTree<object>.SetRight
	*/

	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789F00 Offset: 0x1788500 VA: 0x181789F00
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x20CD780 Offset: 0x20CBD80 VA: 0x1820CD780
	|-RBTree<object>.SetLeft
	*/

	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789FE0 Offset: 0x17885E0 VA: 0x181789FE0
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x20CD860 Offset: 0x20CBE60 VA: 0x1820CD860
	|-RBTree<object>.SetParent
	*/

	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789E20 Offset: 0x1788420 VA: 0x181789E20
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x20CD690 Offset: 0x20CBC90 VA: 0x1820CD690
	|-RBTree<object>.SetColor
	*/

	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789E90 Offset: 0x1788490 VA: 0x181789E90
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x20CD700 Offset: 0x20CBD00 VA: 0x1820CD700
	|-RBTree<object>.SetKey
	*/

	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789F70 Offset: 0x1788570 VA: 0x181789F70
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x20CD7F0 Offset: 0x20CBDF0 VA: 0x1820CD7F0
	|-RBTree<object>.SetNext
	*/

	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A0C0 Offset: 0x17886C0 VA: 0x18178A0C0
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x20CD940 Offset: 0x20CBF40 VA: 0x1820CD940
	|-RBTree<object>.SetSubTreeSize
	*/

	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786400 Offset: 0x1784A00 VA: 0x181786400
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x20C9FA0 Offset: 0x20C85A0 VA: 0x1820C9FA0
	|-RBTree<object>.IncreaseSize
	*/

	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789620 Offset: 0x1787C20 VA: 0x181789620
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x20CCEC0 Offset: 0x20CB4C0 VA: 0x1820CCEC0
	|-RBTree<object>.RecomputeSize
	*/

	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1785630 Offset: 0x1783C30 VA: 0x181785630
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x20C9420 Offset: 0x20C7A20 VA: 0x1820C9420
	|-RBTree<object>.DecreaseSize
	*/

	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1789CA0 Offset: 0x17882A0 VA: 0x181789CA0
	|-RBTree<int>.Right
	|
	|-RVA: 0x20CD510 Offset: 0x20CBB10 VA: 0x1820CD510
	|-RBTree<object>.Right
	*/

	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1786E00 Offset: 0x1785400 VA: 0x181786E00
	|-RBTree<int>.Left
	|
	|-RVA: 0x20CA8E0 Offset: 0x20C8EE0 VA: 0x1820CA8E0
	|-RBTree<object>.Left
	*/

	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17870E0 Offset: 0x17856E0 VA: 0x1817870E0
	|-RBTree<int>.Parent
	|
	|-RVA: 0x20CA9C0 Offset: 0x20C8FC0 VA: 0x1820CA9C0
	|-RBTree<object>.Parent
	*/

	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A530 Offset: 0x1788B30 VA: 0x18178A530
	|-RBTree<int>.color
	|
	|-RVA: 0x20CDC50 Offset: 0x20CC250 VA: 0x1820CDC50
	|-RBTree<object>.color
	*/

	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1787070 Offset: 0x1785670 VA: 0x181787070
	|-RBTree<int>.Next
	|
	|-RVA: 0x20CA950 Offset: 0x20C8F50 VA: 0x1820CA950
	|-RBTree<object>.Next
	*/

	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x178A130 Offset: 0x1788730 VA: 0x18178A130
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x20CD9B0 Offset: 0x20CBFB0 VA: 0x1820CD9B0
	|-RBTree<object>.SubTreeSize
	*/

	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17868C0 Offset: 0x1784EC0 VA: 0x1817868C0
	|-RBTree<int>.Key
	|
	|-RVA: 0x20CA3A0 Offset: 0x20C89A0 VA: 0x1820CA3A0
	|-RBTree<object>.Key
	*/

}

internal sealed class Listeners<TElem> // TypeDefIndex: 4304
{	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	internal bool HasListeners { get; }


	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784530 Offset: 0x1782B30 VA: 0x181784530
	|-Listeners<DataViewListener>..ctor
	|-Listeners<object>..ctor
	*/

	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784600 Offset: 0x1782C00 VA: 0x181784600
	|-Listeners<DataViewListener>.get_HasListeners
	|-Listeners<object>.get_HasListeners
	*/

	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE05420 Offset: 0xE03A20 VA: 0x180E05420
	|-Listeners<DataViewListener>.Add
	|-Listeners<object>.Add
	*/

	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17843E0 Offset: 0x17829E0 VA: 0x1817843E0
	|-Listeners<object>.IndexOfReference
	*/

	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784480 Offset: 0x1782A80 VA: 0x181784480
	|-Listeners<DataViewListener>.Remove
	|-Listeners<object>.Remove
	*/

	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE031E0 Offset: 0xE017E0 VA: 0x180E031E0
	|-Listeners<DataViewListener>.Notify<ListChangedEventArgs, bool, bool>
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0xE02FE0 Offset: 0xE015E0 VA: 0x180E02FE0
	|-Listeners<DataViewListener>.Notify<ListChangedType, DataRow, bool>
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0xE033E0 Offset: 0xE019E0 VA: 0x180E033E0
	|-Listeners<object>.Notify<object, object, object>
	*/

	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1784400 Offset: 0x1782A00 VA: 0x181784400
	|-Listeners<object>.RemoveNullListeners
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4436
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 0EE6555EB2C89F29655BD23FAB0573D8D684331A /*Metadata offset 0x53EECB*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 229F48C8598232AD9236772DD710E64615D0EE51 /*Metadata offset 0x53EEEF*/; // 0x24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 2A4F1BD548EC71F652E24985361CD72F0FE1BE7D /*Metadata offset 0x53EF87*/; // 0xBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 547FF12759F2EA9866F3E2095113686A6379ABBF /*Metadata offset 0x53EFAD*/; // 0xE2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 57F92A12C48A0856350D3C95C4145F2AF4C9DEFF /*Metadata offset 0x53F045*/; // 0x17A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 624B37B4C211942F3422DFFEAE9F44901E57339C /*Metadata offset 0x53F0F5*/; // 0x22A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x53F18D*/; // 0x2C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x53F1C1*/; // 0x2F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 FA7899481F1198B5A3F90368A998C285FCE19878 /*Metadata offset 0x53F1F5*/; // 0x32A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 FF8FD0AC7542FD42A8A7C8D145E120345BA51C56 /*Metadata offset 0x53F235*/; // 0x36A

}

internal sealed class _AndroidJNIHelper // TypeDefIndex: 4471
{
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	public static jvalue[] CreateJNIArgArray(object[] args) { }

	public static object UnboxArray(AndroidJavaObject obj) { }

	public static object Unbox(AndroidJavaObject obj) { }

	public static AndroidJavaObject Box(object obj) { }

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	public static IntPtr ConvertToJNIArray(Array array) { }

	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125FD20 Offset: 0x125E320 VA: 0x18125FD20
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x12605D0 Offset: 0x125EBD0 VA: 0x1812605D0
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x1260E80 Offset: 0x125F480 VA: 0x181260E80
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x1261730 Offset: 0x125FD30 VA: 0x181261730
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x1261FE0 Offset: 0x12605E0 VA: 0x181261FE0
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x1262890 Offset: 0x1260E90 VA: 0x181262890
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x1263140 Offset: 0x1261740 VA: 0x181263140
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x1263A30 Offset: 0x1262030 VA: 0x181263A30
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x12642E0 Offset: 0x12628E0 VA: 0x1812642E0
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA630 Offset: 0xED8C30 VA: 0x180EDA630
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	*/

	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	public static string GetSignature(object obj) { }

	public static string GetSignature(object[] args) { }

	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA690 Offset: 0xED8C90 VA: 0x180EDA690
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0xEDA7D0 Offset: 0xED8DD0 VA: 0x180EDA7D0
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0xEDA910 Offset: 0xED8F10 VA: 0x180EDA910
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0xEDAA50 Offset: 0xED9050 VA: 0x180EDAA50
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0xEDAB90 Offset: 0xED9190 VA: 0x180EDAB90
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0xEDACD0 Offset: 0xED92D0 VA: 0x180EDACD0
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0xEDAE10 Offset: 0xED9410 VA: 0x180EDAE10
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0xEDAF50 Offset: 0xED9550 VA: 0x180EDAF50
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0xEDB090 Offset: 0xED9690 VA: 0x180EDB090
	|-_AndroidJNIHelper.GetSignature<float>
	*/

}

public class Memoized<TResult, TArgs> // TypeDefIndex: 4824
{	private readonly Func<TArgs, TResult> _factory; // 0x0
	private readonly Dictionary<TArgs, TResult> _cache; // 0x0


	public void .ctor(Func<TArgs, TResult> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164C870 Offset: 0x164AE70 VA: 0x18164C870
	|-Memoized<object, int>..ctor
	|-Memoized<Material[], int>..ctor
	|
	|-RVA: 0x164CA50 Offset: 0x164B050 VA: 0x18164CA50
	|-Memoized<object, object>..ctor
	|-Memoized<string, string>..ctor
	|
	|-RVA: 0x164C960 Offset: 0x164AF60 VA: 0x18164C960
	|-Memoized<object, ValueTuple<Int32Enum, int>>..ctor
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>..ctor
	*/

	public TResult Get(TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164C630 Offset: 0x164AC30 VA: 0x18164C630
	|-Memoized<string, string>.Get
	|-Memoized<object, object>.Get
	|
	|-RVA: 0x164C7B0 Offset: 0x164ADB0 VA: 0x18164C7B0
	|-Memoized<string, ValueTuple<ItemDefinition.AmountType, int>>.Get
	|-Memoized<object, ValueTuple<Int32Enum, int>>.Get
	|
	|-RVA: 0x164C6F0 Offset: 0x164ACF0 VA: 0x18164C6F0
	|-Memoized<Material[], int>.Get
	|-Memoized<object, int>.Get
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4849
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=146 062825E0D4AB4302B73500604BF9520511ACFD15 /*Metadata offset 0x53F7DF*/; // 0x2B10360

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4899
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 1D1E8406C3A31F2298952B0976625EEDFB010FDC /*Metadata offset 0x53F945*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 339A8BB625A037BA37DB4DF24A276E689D62172D /*Metadata offset 0x53F9AD*/; // 0x68
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 48DE754CC0C776DAD1A85DB81BEFAAADE3A447E9 /*Metadata offset 0x53F9F9*/; // 0xB4
	internal static readonly long A5F5D64EF7BB696455C9841B907D2E09986EA902 = 2533317740920876; // 0x100


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5096
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x53FD53*/; // 0x13626

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5561
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9 /*Metadata offset 0x54098D*/; // 0x3120


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5616
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 BA8C008E9A9CA9629B0D5A47EB9DFDC7E9E88D61 /*Metadata offset 0x540B69*/; // 0x31CA

}

internal class PriorityQueue<TPriority, TItem> // TypeDefIndex: 5668
{	private readonly SortedDictionary<TPriority, Queue<TItem>> _subqueues; // 0x0

	public bool HasItems { get; }


	public void .ctor(IComparer<TPriority> priorityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18951B0 Offset: 0x18937B0 VA: 0x1818951B0
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895250 Offset: 0x1893850 VA: 0x181895250
	|-PriorityQueue<long, TimedBlock>..ctor
	|-PriorityQueue<long, object>..ctor
	|-PriorityQueue<object, object>..ctor
	*/

	public void Enqueue(TPriority priority, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894F50 Offset: 0x1893550 VA: 0x181894F50
	|-PriorityQueue<long, TimedBlock>.Enqueue
	|-PriorityQueue<long, object>.Enqueue
	|-PriorityQueue<object, object>.Enqueue
	*/

	private void AddQueueOfPriority(TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894CA0 Offset: 0x18932A0 VA: 0x181894CA0
	|-PriorityQueue<long, object>.AddQueueOfPriority
	|-PriorityQueue<object, object>.AddQueueOfPriority
	*/

	public TItem Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1895010 Offset: 0x1893610 VA: 0x181895010
	|-PriorityQueue<long, TimedBlock>.Peek
	|-PriorityQueue<long, object>.Peek
	|
	|-RVA: 0x18950E0 Offset: 0x18936E0 VA: 0x1818950E0
	|-PriorityQueue<object, object>.Peek
	*/

	public bool get_HasItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18952B0 Offset: 0x18938B0 VA: 0x1818952B0
	|-PriorityQueue<long, TimedBlock>.get_HasItems
	|-PriorityQueue<long, object>.get_HasItems
	|-PriorityQueue<object, object>.get_HasItems
	*/

	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894E10 Offset: 0x1893410 VA: 0x181894E10
	|-PriorityQueue<long, TimedBlock>.Dequeue
	|-PriorityQueue<long, object>.Dequeue
	|
	|-RVA: 0x1894EB0 Offset: 0x18934B0 VA: 0x181894EB0
	|-PriorityQueue<object, object>.Dequeue
	*/

	private TItem DequeueFromHighPriorityQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894D40 Offset: 0x1893340 VA: 0x181894D40
	|-PriorityQueue<long, object>.DequeueFromHighPriorityQueue
	|-PriorityQueue<object, object>.DequeueFromHighPriorityQueue
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5677
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 00C40B3F013EDA60390F2E849C4581815A9419E4 /*Metadata offset 0x540BE7*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 03B569C38E3CD6B720388919D43735A904012C52 /*Metadata offset 0x540C0F*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1FDC8DB567F5AAA7068D0D2A601CD71657CBDF38 /*Metadata offset 0x540C37*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x540C83*/; // 0x9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 6BC4EAB0D604C8D4599021AD611C5DBA7FF7E306 /*Metadata offset 0x541083*/; // 0x49C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 89CE0E8EA590FD37283D6BEFD9E6805C8C47ADBD /*Metadata offset 0x5410AB*/; // 0x4C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 DB7C763C9670DD0F6ED34B75B3410A39D835F964 /*Metadata offset 0x5410BB*/; // 0x4D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 ED032026472FF77A8A17BA4AFF3FC57AF4B4BF79 /*Metadata offset 0x5410E3*/; // 0x4FC

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5812
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=127 A097044521F478B3A2A9A3AC52887BA733E4DE56 /*Metadata offset 0x54118C*/; // 0x32FF


	internal static uint ComputeStringHash(string s) { }

}

internal sealed class XHashtable<TValue> // TypeDefIndex: 5818
{	private XHashtable.XHashtableState<TValue> state; // 0x0


	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54E50 Offset: 0x1A53450 VA: 0x181A54E50
	|-XHashtable<object>..ctor
	|-XHashtable<WeakReference>..ctor
	|-XHashtable<XName>..ctor
	*/

	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54E10 Offset: 0x1A53410 VA: 0x181A54E10
	|-XHashtable<object>.TryGetValue
	|-XHashtable<WeakReference>.TryGetValue
	|-XHashtable<XName>.TryGetValue
	*/

	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A54C80 Offset: 0x1A53280 VA: 0x181A54C80
	|-XHashtable<object>.Add
	|-XHashtable<WeakReference>.Add
	|-XHashtable<XName>.Add
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5852

	internal static uint ComputeStringHash(string s) { }

}

internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 5930
{
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	|-MethodCall<object, object>..ctor
	*/

	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A080 Offset: 0xD58680 VA: 0x180D5A080
	|-MethodCall<object, object>.Invoke
	*/

	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE4E10 Offset: 0xAE3410 VA: 0x180AE4E10
	|-MethodCall<object, object>.BeginInvoke
	*/

	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0
	|-MethodCall<object, object>.EndInvoke
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6148
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D /*Metadata offset 0x5415F6*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 ADFD2E1C801C825415DD53F4F2F72A13B389313C /*Metadata offset 0x541612*/; // 0x1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 D40004AB0E92BF6C8DFE481B56BE3D04ABDA76EB /*Metadata offset 0x54161E*/; // 0x28
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0 /*Metadata offset 0x541628*/; // 0x32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A /*Metadata offset 0x54165C*/; // 0x66

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6262
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 553AD71118F2B31C74BC988917343BADFA8F78EE /*Metadata offset 0x5417A9*/; // 0x3491

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6635
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 373B494F210C656134C5728D551D4C97B013EB33 /*Metadata offset 0x541E02*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 E03C5B88B476F381E452F92C935A5B86131DFC4A /*Metadata offset 0x542202*/; // 0x400

}

internal class <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA} // TypeDefIndex: 6713
{	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-1 /*Metadata offset 0x542AEB*/; // 0x0
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=32 $$method0x600002d-2 /*Metadata offset 0x542B0B*/; // 0x20
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 $$method0x600002d-3 /*Metadata offset 0x542B2B*/; // 0x40
	internal static <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 $$method0x600002d-4 /*Metadata offset 0x542BAB*/; // 0xC0

}

public class FastAction<A> // TypeDefIndex: 6738
{	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0


	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADE80 Offset: 0x17AC480 VA: 0x1817ADE80
	|-FastAction<bool>.Add
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADFD0 Offset: 0x17AC5D0 VA: 0x1817ADFD0
	|-FastAction<bool>.Remove
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FAF0 Offset: 0x1A3E0F0 VA: 0x181A3FAF0
	|-FastAction<bool>.Call
	|
	|-RVA: 0x17ADF20 Offset: 0x17AC520 VA: 0x1817ADF20
	|-FastAction<object>.Call
	|-FastAction<TMP_ColorGradient>.Call
	|-FastAction<Object>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE070 Offset: 0x17AC670 VA: 0x1817AE070
	|-FastAction<bool>..ctor
	|-FastAction<object>..ctor
	|-FastAction<TMP_ColorGradient>..ctor
	|-FastAction<Object>..ctor
	*/

}

public class FastAction<A, B> // TypeDefIndex: 6739
{	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0


	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADE80 Offset: 0x17AC480 VA: 0x1817ADE80
	|-FastAction<bool, object>.Add
	|-FastAction<object, object>.Add
	*/

	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADFD0 Offset: 0x17AC5D0 VA: 0x1817ADFD0
	|-FastAction<bool, object>.Remove
	|-FastAction<object, object>.Remove
	*/

	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE220 Offset: 0x17AC820 VA: 0x1817AE220
	|-FastAction<bool, object>.Call
	|-FastAction<bool, TMP_FontAsset>.Call
	|-FastAction<bool, TextMeshPro>.Call
	|-FastAction<bool, TextMeshProUGUI>.Call
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x17AE150 Offset: 0x17AC750 VA: 0x1817AE150
	|-FastAction<object, object>.Call
	|-FastAction<object, Compute_DT_EventArgs>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE070 Offset: 0x17AC670 VA: 0x1817AE070
	|-FastAction<bool, object>..ctor
	|-FastAction<bool, TMP_FontAsset>..ctor
	|-FastAction<bool, TextMeshPro>..ctor
	|-FastAction<bool, TextMeshProUGUI>..ctor
	|-FastAction<bool, Material>..ctor
	|-FastAction<bool, Object>..ctor
	|-FastAction<object, object>..ctor
	|-FastAction<object, Compute_DT_EventArgs>..ctor
	*/

}

public class FastAction<A, B, C> // TypeDefIndex: 6740
{	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0


	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADE80 Offset: 0x17AC480 VA: 0x1817ADE80
	|-FastAction<object, object, object>.Add
	*/

	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ADFD0 Offset: 0x17AC5D0 VA: 0x1817ADFD0
	|-FastAction<object, object, object>.Remove
	*/

	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE2F0 Offset: 0x17AC8F0 VA: 0x1817AE2F0
	|-FastAction<object, object, object>.Call
	|-FastAction<GameObject, Material, Material>.Call
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE070 Offset: 0x17AC670 VA: 0x1817AE070
	|-FastAction<object, object, object>..ctor
	|-FastAction<GameObject, Material, Material>..ctor
	*/

}

public enum _HorizontalAlignmentOptions // TypeDefIndex: 6827
{	public int value__; // 0x0
	public const _HorizontalAlignmentOptions Left = 1;
	public const _HorizontalAlignmentOptions Center = 2;
	public const _HorizontalAlignmentOptions Right = 4;
	public const _HorizontalAlignmentOptions Justified = 8;
	public const _HorizontalAlignmentOptions Flush = 16;
	public const _HorizontalAlignmentOptions Geometry = 32;

}

public enum _VerticalAlignmentOptions // TypeDefIndex: 6828
{	public int value__; // 0x0
	public const _VerticalAlignmentOptions Top = 256;
	public const _VerticalAlignmentOptions Middle = 512;
	public const _VerticalAlignmentOptions Bottom = 1024;
	public const _VerticalAlignmentOptions Baseline = 2048;
	public const _VerticalAlignmentOptions Geometry = 4096;
	public const _VerticalAlignmentOptions Capline = 8192;

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6870
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46 /*Metadata offset 0x5432BB*/; // 0x2B10370

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6937
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 B633673BF635D4C719EF5A0496BD28129A8CE5D3B76217371B6C1FDDFFDD780B /*Metadata offset 0x543315*/; // 0x3736

}

internal class <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7} // TypeDefIndex: 6968
{	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000504-1 /*Metadata offset 0x54341B*/; // 0x0
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=68 $$method0x6000505-1 /*Metadata offset 0x543467*/; // 0x4C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=6144 $$method0x6000507-1 /*Metadata offset 0x5434AB*/; // 0x90
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=384 $$method0x6000507-2 /*Metadata offset 0x544CAB*/; // 0x1890
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-3 /*Metadata offset 0x544E2B*/; // 0x1A10
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=124 $$method0x6000507-4 /*Metadata offset 0x544EA7*/; // 0x1A8C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-5 /*Metadata offset 0x544F23*/; // 0x1B08
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000507-6 /*Metadata offset 0x544F9B*/; // 0x1B80
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-1 /*Metadata offset 0x545013*/; // 0x1BF8
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-2 /*Metadata offset 0x545087*/; // 0x1C6C
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=76 $$method0x6000509-3 /*Metadata offset 0x5450FF*/; // 0x1CE4
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=19 $$method0x6000509-4 /*Metadata offset 0x54514B*/; // 0x1D30
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=512 $$method0x6000509-5 /*Metadata offset 0x54515E*/; // 0x1D43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=256 $$method0x6000509-6 /*Metadata offset 0x54535E*/; // 0x1F43
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=116 $$method0x6000509-7 /*Metadata offset 0x54545E*/; // 0x2043
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000509-8 /*Metadata offset 0x5454D2*/; // 0x20B7
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=1152 $$method0x6000475-1 /*Metadata offset 0x54554A*/; // 0x212F
	internal static <PrivateImplementationDetails>{510A9A0A-2EB8-4C1C-AA23-D4ACD845FEA7}.__StaticArrayInitTypeSize=120 $$method0x6000475-2 /*Metadata offset 0x5459CA*/; // 0x25AF

}

internal class <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8} // TypeDefIndex: 6993
{	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-1 /*Metadata offset 0x545A7B*/; // 0x0
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=32 $$method0x600007d-2 /*Metadata offset 0x545A9B*/; // 0x20
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=128 $$method0x600007d-3 /*Metadata offset 0x545ABB*/; // 0x40
	internal static <PrivateImplementationDetails>{4136EF42-BA0E-48C1-8B0C-A481CDC84FC8}.__StaticArrayInitTypeSize=256 $$method0x600007d-4 /*Metadata offset 0x545B3B*/; // 0xC0

}

public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 7086
{	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }


	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227CF0 Offset: 0x2270F0 VA: 0x180227CF0
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x227C60 Offset: 0x227060 VA: 0x180227C60
	|-ValueTask<object>..ctor
	*/

	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227C10 Offset: 0x227010 VA: 0x180227C10
	|-ValueTask<bool>..ctor
	|
	|-RVA: 0x227CA0 Offset: 0x2270A0 VA: 0x180227CA0
	|-ValueTask<object>..ctor
	*/

	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2279F0 Offset: 0x226DF0 VA: 0x1802279F0
	|-ValueTask<bool>.GetHashCode
	|
	|-RVA: 0x227A30 Offset: 0x226E30 VA: 0x180227A30
	|-ValueTask<object>.GetHashCode
	*/

	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2276B0 Offset: 0x226AB0 VA: 0x1802276B0
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x2277F0 Offset: 0x226BF0 VA: 0x1802277F0
	|-ValueTask<object>.Equals
	*/

	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227910 Offset: 0x226D10 VA: 0x180227910
	|-ValueTask<bool>.Equals
	|
	|-RVA: 0x2277C0 Offset: 0x226BC0 VA: 0x1802277C0
	|-ValueTask<object>.Equals
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227D50 Offset: 0x227150 VA: 0x180227D50
	|-ValueTask<bool>.get_IsCompleted
	|
	|-RVA: 0x227E90 Offset: 0x227290 VA: 0x180227E90
	|-ValueTask<object>.get_IsCompleted
	*/

	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227D40 Offset: 0x227140 VA: 0x180227D40
	|-ValueTask<bool>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x227D30 Offset: 0x227130 VA: 0x180227D30
	|-ValueTask<object>.get_IsCompletedSuccessfully
	*/

	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227FE0 Offset: 0x2273E0 VA: 0x180227FE0
	|-ValueTask<bool>.get_Result
	|
	|-RVA: 0x227FD0 Offset: 0x2273D0 VA: 0x180227FD0
	|-ValueTask<object>.get_Result
	*/

	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227930 Offset: 0x226D30 VA: 0x180227930
	|-ValueTask<bool>.GetAwaiter
	|
	|-RVA: 0x227980 Offset: 0x226D80 VA: 0x180227980
	|-ValueTask<object>.GetAwaiter
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x227B40 Offset: 0x226F40 VA: 0x180227B40
	|-ValueTask<bool>.ToString
	|
	|-RVA: 0x227A70 Offset: 0x226E70 VA: 0x180227A70
	|-ValueTask<object>.ToString
	*/

}

public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 7096
{	private readonly ValueTask<TResult> _value; // 0x0

	public bool IsCompleted { get; }


	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4150 Offset: 0x1E3550 VA: 0x1801E4150
	|-ValueTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x1E4170 Offset: 0x1E3570 VA: 0x1801E4170
	|-ValueTaskAwaiter<object>..ctor
	*/

	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E41D0 Offset: 0x1E35D0 VA: 0x1801E41D0
	|-ValueTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1E4190 Offset: 0x1E3590 VA: 0x1801E4190
	|-ValueTaskAwaiter<object>.get_IsCompleted
	*/

	[StackTraceHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4090 Offset: 0x1E3490 VA: 0x1801E4090
	|-ValueTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x1E40D0 Offset: 0x1E34D0 VA: 0x1801E40D0
	|-ValueTaskAwaiter<object>.GetResult
	*/

	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4120 Offset: 0x1E3520 VA: 0x1801E4120
	|-ValueTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x1E4110 Offset: 0x1E3510 VA: 0x1801E4110
	|-ValueTaskAwaiter<object>.OnCompleted
	*/

	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4130 Offset: 0x1E3530 VA: 0x1801E4130
	|-ValueTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1E4140 Offset: 0x1E3540 VA: 0x1801E4140
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7366
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 C92FBDBB320D6C40BEB41D97EE6C7B301C4ADB1D /*Metadata offset 0x547B33*/; // 0x1C85

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7415
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 021F8912B268BE164A590D1440F05920A3F2A63B9874F994402C7AFFC6F92F82 /*Metadata offset 0x54836F*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 02E68C9160BF270CAF19E18D3A77BC2EAA90EFCB3ECA3C454B58CD5BBA5FF7ED /*Metadata offset 0x5483AF*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 047D891CAC8D4F883998ACEFD1EB63F6A679046FFD19EC1276A057F847EE37F6 /*Metadata offset 0x5484AF*/; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 06ADCD404637282636289E77FA01C56630CB4945332C96D5FA2D9239FE0D6B04 /*Metadata offset 0x5484BF*/; // 0x150
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 06D49AE61368F7B7C195381125B5A5E8F6830EA024D49F5C1A62950E74DBAF3D /*Metadata offset 0x54853F*/; // 0x1D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 091971E0756262C068D16B941EA6256855E94532833A9CE3374D9768E27E4596 /*Metadata offset 0x54857F*/; // 0x210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 124360CE49E1C84604EFA93F8F0C3292C1D216DB605CF153414D893922B18C9F /*Metadata offset 0x54860F*/; // 0x2A0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 13BE6783CC652C89CC0161446DBD67966CAC410DEA4DE4279FC767A259EFD546 /*Metadata offset 0x54864F*/; // 0x2E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 1B8D49F1227D3FC61644822B9FC00CE70A3B2438A1064323BFBE6A022A26F042 /*Metadata offset 0x548687*/; // 0x318
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 1C01F69BD2391DE00F8F1B377D2D9E5991674702AD777030BA910AC531E4B0FE /*Metadata offset 0x548697*/; // 0x328
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 22E5D3D9ABC124EE0214CEF7079F24CFF9BE30FD6AF6BA5BBE15920C57497EA1 /*Metadata offset 0x5486D7*/; // 0x368
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2A03DC27FE2EB4E5D0A4358E22435065F2FB1BBF8CC2C4D9F754A9F24089344E /*Metadata offset 0x5486E7*/; // 0x378
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 2A1C6CEE1B003A06B471AA7632C6B5C4ED18A4E1A4784BF8CA09BD4F38BA4BB5 /*Metadata offset 0x548727*/; // 0x3B8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2BCE8E19B19AAD97CC510F21B5828CCB319639FA317FB59926A436ED3543F58D /*Metadata offset 0x548763*/; // 0x3F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 2C72B27AAD08F98379E9F3E0F6A2D625F895C9E55F61404790377FC196FA14B8 /*Metadata offset 0x5487A3*/; // 0x434
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2F4596419894C88417AC4DF5C99E98A374EFE4B57B7A4EB89CE65FEB92850A61 /*Metadata offset 0x5487E3*/; // 0x474
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 320B0930454D74130DD5E245B70DA1736A2C1B5E664DD5BB82B490E60F3ECA2A /*Metadata offset 0x5487F3*/; // 0x484
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3229DAC3DA84FAC1A1018091DAF2A0C3D6B3624AC33BECF13A371238DAC95055 /*Metadata offset 0x548803*/; // 0x494
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 3543AE0E1ED6A92350687219F717764E126E06D4FA179DE5B0CB3E2BDFE4AC9E /*Metadata offset 0x548813*/; // 0x4A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 3554CE8BB09083C24D298DF77456CB67242E6EEE3DEDFE595E11B90D2F70C0FF /*Metadata offset 0x54886F*/; // 0x500
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1500 3B42FF7B534B27868E300720C678882AF0698E9434D0FA135656E097480324FF /*Metadata offset 0x5488AF*/; // 0x540
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3EDD050356C639DD16815E64CA19652B1B981F1BA2FF76176BB3995FF0DB860D /*Metadata offset 0x548E8B*/; // 0xB1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 4053901EA5134D137292C48A98E1382B09C1E49C98EEF77C2D00D8FF24481D4F /*Metadata offset 0x548E9B*/; // 0xB2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 419EB5F371A1171DBE8C085F1BB25D78AA0647C1365608E167054A37BFEAD834 /*Metadata offset 0x548EDB*/; // 0xB6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 4517AF16CD9D95D0B56C33292D289749B763021F170127ED439165498D243E69 /*Metadata offset 0x548EEB*/; // 0xB7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 4E7A2BE1E8600FA773FA4952A14AE27AD21E294C2C90F674BEA6BB8B089F39C1 /*Metadata offset 0x548EFF*/; // 0xB90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 550560694565D72C91221BEE89B41C8AA412660E1CF28C626BC523BC959438A9 /*Metadata offset 0x548F1F*/; // 0xBB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=8748 5600405012DD0807E058E5A8F3F7A9AF31716C8560F552613672D0D770364603 /*Metadata offset 0x548F5F*/; // 0xBF0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 56C5F192F58A478FC32D5428DA86D03B15A95E9A982E82BA5026E6EBE259FE48 /*Metadata offset 0x54B18B*/; // 0x2E1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 57CD95842F6B0D5A0823F7A82A33632D2D4DA79615A834507722CBBBD054E3CF /*Metadata offset 0x54B21B*/; // 0x2EAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 58BB6050E828A1FDB65D46F61ADBE862543CF7261AA487580A1328D24E944BBD /*Metadata offset 0x54B25B*/; // 0x2EEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 5ED52DA9C543DD730BD7056787DF87C0AED3189F42C3321C4196EA8B70C87D2A /*Metadata offset 0x54B26B*/; // 0x2EFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=88 6547EC5EB178C3DBF6A302152A1FE3BDF747E8E5EB41343EECEA2F45D745E5D1 /*Metadata offset 0x54B2FB*/; // 0x2F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 673F8620472294A2666EB7018FC21EF377E5B15A76872E89803CBDBDBC17F1B8 /*Metadata offset 0x54B353*/; // 0x2FE4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6807ED2269DB8E9A70F5D22C6D41806D26C51C306050C58861DEBD9B21D76D0B /*Metadata offset 0x54B363*/; // 0x2FF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6810D47101B1F88C982302E36EF8DBDB344EAFDF31E058B2AE9B23522DA15D89 /*Metadata offset 0x54B373*/; // 0x3004
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 683133215F3906FE49DACDB11CE3F917EF1B439110BF4CE1092DB8F15D087E2F /*Metadata offset 0x54B383*/; // 0x3014
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 68F20C1D1F9AD9A40A6FF9C3879482F58AED8E4A58995CEB0F83B2575DCFD2BC /*Metadata offset 0x54B3DF*/; // 0x3070
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6B6C31FF54224894CC66030691DB54C3EEE6BE4D42DB3DDA43EEC126F036360E /*Metadata offset 0x54B3EF*/; // 0x3080
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 70CBEAD43E82DC4CCC445D5552A983D797EEF8D2AD3665EB8FAAB2187F64F6FE /*Metadata offset 0x54B42F*/; // 0x30C0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 70CF9A93794FD166C020BBDF13AE34B6B43B3A2271EC768A35797C135FC62D20 /*Metadata offset 0x54B46F*/; // 0x3100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 79B6797C01D7827A0E35892156B642BD84A9FA528E603C743515D3822864A051 /*Metadata offset 0x54B4A7*/; // 0x3138
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7A5DCFD7518F8A0A3FA422FA014FF84FE08070112345B17E00C0FB0AFC6D7461 /*Metadata offset 0x54B4C7*/; // 0x3158
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 7CC4C8FC1CA4B0FA871FEB4911499E0268FE161D01C6ADFD186B0378C4063EBA /*Metadata offset 0x54B4E7*/; // 0x3178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 8C6C0F60451FBE1D2DDDF80A2A9F0B7684893D5B0B8CEAB4CA837EE615B3954E /*Metadata offset 0x54B507*/; // 0x3198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 941D4DCAADBEC3CC42B0F9F20212661AC83343F86BC7F873B237BC25AF1B195C /*Metadata offset 0x54BD07*/; // 0x3998
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9742CA838C60363B639BEC16A2086253E96A532C05331B73181E45ED9D213F13 /*Metadata offset 0x54BD47*/; // 0x39D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=324 9F53690DAB4D28E43D6BB3EB96D00F76FAF99D7681A6E8F0061297C8DD5EFF33 /*Metadata offset 0x54BD87*/; // 0x3A18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 9FB71D398994B2E0C6CE3CE99EE4CBD26EE1524A81DDB919603C13A2885F5483 /*Metadata offset 0x54BECB*/; // 0x3B5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A28E77C3345C5351A69C7393656A759AABE24F2E59F5BFC49A771E190D9C9FCC /*Metadata offset 0x54BF0B*/; // 0x3B9C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A3F937EE796D2312148DDB921F1293E76047E426F9BF3864DD12817D66034E74 /*Metadata offset 0x54BF1B*/; // 0x3BAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 A4B3F75E2EA169B5351F2BAA4DBAB862A18EDFBAE5B1CB4DBEFAEC4E22DA6BD3 /*Metadata offset 0x54BF5B*/; // 0x3BEC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 A84E72B8CD1EB5B569F80091ADA35B15F45C05E48515346C276DFBC7457817CD /*Metadata offset 0x54BF9B*/; // 0x3C2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AC808BDFC94A2720F9A403E96C598F28C4A82AACBF21E2A1A6347C32A66B6425 /*Metadata offset 0x54C01B*/; // 0x3CAC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B107577D43B15DF28D27533ADF012E72BD63868C2A2E688AC15978DC38CD5677 /*Metadata offset 0x54C02B*/; // 0x3CBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B10D5342782BFD3820C0FFBD8DDCDF80BAA0ED5F0DF5746D2EA885110239AC7A /*Metadata offset 0x54C03B*/; // 0x3CCC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B79C140A0DE10B238571FE854A6BC223D6D8C50F6ED4E227CCC677094DCB3558 /*Metadata offset 0x54C07B*/; // 0x3D0C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 B9C5D4C45600219530B355BB1786AA4E282347901A9E3BF35DC8EE98E1307DFB /*Metadata offset 0x54C09B*/; // 0x3D2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 BBDCD859D8A76172AF0C213EFB99A6F64E8AB028BECE6D313FA5B6BCF96CD15A /*Metadata offset 0x54C0AB*/; // 0x3D3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C271A86BEFE71CEF20615946687F7A3A13E980C14FD4637951697CD4A6112156 /*Metadata offset 0x54C107*/; // 0x3D98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C31F1438706DA962938E7F1D03470E164E0EA9EE1CD0F0D19CA29C7E932C91DC /*Metadata offset 0x54C163*/; // 0x3DF4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 C3FBE83D14A8E5B3DCCAF45D7AD6C35F769326FFAED483A102ACF50FB824C9C2 /*Metadata offset 0x54C173*/; // 0x3E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C6D060549430A52150918BF2837FCCD94C6D727B74A5946A8F7EF51B940C3CF7 /*Metadata offset 0x54C1B3*/; // 0x3E44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C775F22681F0D15310756B294BB58FC4364A5DE6030B819E8D3EEC4E75454915 /*Metadata offset 0x54C1EB*/; // 0x3E7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 C807773510A04834C84A6A093A8267D127DC4413714AD99057315D8CABE1D467 /*Metadata offset 0x54C247*/; // 0x3ED8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 C842A7F36E23186A8F55DC7D0E63E781469950969CB88357227234F95C35DEA9 /*Metadata offset 0x54C267*/; // 0x3EF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 CCC564D5CDB40E327F07151E33EF8AD040EEB5129CE505D00FE6EC11BD28C359 /*Metadata offset 0x54C2C3*/; // 0x3F54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 CD4DE47C20503BFF1B99694EAF6390723510293766C75243F8B3CA7B56C89359 /*Metadata offset 0x54C2FB*/; // 0x3F8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D20525C66D9D2B26BC9D3A773951775A3813FC7F97CC4A2EADFF258D3C9D869E /*Metadata offset 0x54C38B*/; // 0x401C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 D3310F8730C74E00C7014874471A5E27574CD015457352EFB0373E8C5DA85FD1 /*Metadata offset 0x54C39B*/; // 0x402C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DD54E6E73536232DFD682C64D36E265B59ACF8AD04FC6062A2EB7225BBDDDB02 /*Metadata offset 0x54C3AB*/; // 0x403C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 DDC358E79464AB64B601CE4D8FBC308D787438D4CE92844B5FD77F2DE1E21575 /*Metadata offset 0x54C3E3*/; // 0x4074
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DE26AA4452A148F1FCFF9D95EA656766D0DC19BDCEE086F85BC3F9BD8AB7F25B /*Metadata offset 0x54C4E3*/; // 0x4174
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 E2AA696710083FEFF382491A86DF649DB1E8EE6AA4ECF99E8D98CFBF871BFCE4 /*Metadata offset 0x54C4F3*/; // 0x4184
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=60 ED977BBA7102E7758BEF3DA21CD69B44B8864A1D6F43BB20E6BF59862487ECBA /*Metadata offset 0x54C503*/; // 0x4194
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 EFC52C86FFF3F24CE6C0C14D161FCF00584AB329C5997334034F2B4D91225307 /*Metadata offset 0x54C53F*/; // 0x41D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F1B0145A5F0D3E964A90201094730422F3013B94D7B9E73B6FFDED5643D486A2 /*Metadata offset 0x54C587*/; // 0x4218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 F8756C1F7B8F886752A7B73230C5AC5397F7CE2B1BFDC5C139DBED513BD228C3 /*Metadata offset 0x54C5BF*/; // 0x4250

}

internal sealed class TimedObjectsComparer<TObject> : IComparer<TObject> // TypeDefIndex: 7464
{
	public int Compare(TObject x, TObject y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164FD70 Offset: 0x164E370 VA: 0x18164FD70
	|-TimedObjectsComparer<object>.Compare
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5BBD0 Offset: 0xD5A1D0 VA: 0x180D5BBD0
	|-TimedObjectsComparer<object>..ctor
	*/

}

public sealed class ValueChange<TValue> : ITimedObject // TypeDefIndex: 7504
{	private readonly long _time; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly TValue <Value>k__BackingField; // 0x0

	public long Time { get; }
	public TValue Value { get; }


	internal void .ctor(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650E40 Offset: 0x164F440 VA: 0x181650E40
	|-ValueChange<object>..ctor
	*/

	public long get_Time() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-ValueChange<Tempo>.get_Time
	|-ValueChange<TimeSignature>.get_Time
	|-ValueChange<object>.get_Time
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-ValueChange<Tempo>.get_Value
	|-ValueChange<TimeSignature>.get_Value
	|-ValueChange<object>.get_Value
	*/

	public static bool op_Equality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650ED0 Offset: 0x164F4D0 VA: 0x181650ED0
	|-ValueChange<object>.op_Equality
	*/

	public static bool op_Inequality(ValueChange<TValue> change1, ValueChange<TValue> change2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16510A0 Offset: 0x164F6A0 VA: 0x1816510A0
	|-ValueChange<object>.op_Inequality
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650D90 Offset: 0x164F390 VA: 0x181650D90
	|-ValueChange<object>.ToString
	*/

	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650C70 Offset: 0x164F270 VA: 0x181650C70
	|-ValueChange<object>.Equals
	*/

	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1650CF0 Offset: 0x164F2F0 VA: 0x181650CF0
	|-ValueChange<object>.GetHashCode
	*/

}

public sealed class ValueLine<TValue> : IEnumerable<ValueChange<TValue>>, IEnumerable // TypeDefIndex: 7505
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler ValuesChanged; // 0x0
	private readonly TimedObjectsComparer<ValueChange<TValue>> _comparer; // 0x0
	private readonly List<ValueChange<TValue>> _valueChanges; // 0x0
	private readonly TValue _defaultValue; // 0x0
	private bool _valuesChanged; // 0x0
	private long _maxTime; // 0x0


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void add_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651EC0 Offset: 0x16504C0 VA: 0x181651EC0
	|-ValueLine<Tempo>.add_ValuesChanged
	|-ValueLine<TimeSignature>.add_ValuesChanged
	|-ValueLine<object>.add_ValuesChanged
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void remove_ValuesChanged(EventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651F70 Offset: 0x1650570 VA: 0x181651F70
	|-ValueLine<Tempo>.remove_ValuesChanged
	|-ValueLine<TimeSignature>.remove_ValuesChanged
	|-ValueLine<object>.remove_ValuesChanged
	*/

	internal void .ctor(TValue defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651DC0 Offset: 0x16503C0 VA: 0x181651DC0
	|-ValueLine<Tempo>..ctor
	|-ValueLine<TimeSignature>..ctor
	|-ValueLine<object>..ctor
	*/

	internal TValue GetValueAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16511E0 Offset: 0x164F7E0 VA: 0x1816511E0
	|-ValueLine<TimeSignature>.GetValueAtTime
	|-ValueLine<object>.GetValueAtTime
	*/

	internal ValueChange<TValue> GetValueChangeAtTime(long time) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651280 Offset: 0x164F880 VA: 0x181651280
	|-ValueLine<object>.GetValueChangeAtTime
	*/

	internal void SetValue(long time, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651B60 Offset: 0x1650160 VA: 0x181651B60
	|-ValueLine<Tempo>.SetValue
	|-ValueLine<TimeSignature>.SetValue
	|-ValueLine<object>.SetValue
	*/

	internal ValueLine<TValue> Reverse(long centerTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651430 Offset: 0x164FA30 VA: 0x181651430
	|-ValueLine<Tempo>.Reverse
	|-ValueLine<TimeSignature>.Reverse
	|-ValueLine<object>.Reverse
	*/

	private void OnValuesChanged(bool forceSort = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651370 Offset: 0x164F970 VA: 0x181651370
	|-ValueLine<object>.OnValuesChanged
	*/

	private void OnValueChangesNeedSorting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC90C0 Offset: 0xFC76C0 VA: 0x180FC90C0
	|-ValueLine<object>.OnValueChangesNeedSorting
	*/

	private void OnValueChangesSortingCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF60BC0 Offset: 0xF5F1C0 VA: 0x180F60BC0
	|-ValueLine<object>.OnValueChangesSortingCompleted
	*/

	private void SortValueChanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651D20 Offset: 0x1650320 VA: 0x181651D20
	|-ValueLine<object>.SortValueChanges
	*/

	public IEnumerator<ValueChange<TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651130 Offset: 0x164F730 VA: 0x181651130
	|-ValueLine<Tempo>.GetEnumerator
	|-ValueLine<object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1651D90 Offset: 0x1650390 VA: 0x181651D90
	|-ValueLine<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7638
{	internal static readonly int B52DDE3D967E604310620E80EFBFBED9B6FB8C0605B3CB29D31534DAA6181A7C = 505223448; // 0x1CE0

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7836
{	internal static <PrivateImplementationDetails>.$ArrayType$132 $$field-0 /*Metadata offset 0x54D60D*/; // 0x2B10510


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7854
{	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54DE3D*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54E03D*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54E23D*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54E43D*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54E63D*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54E83D*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54EA3D*/; // 0xC00


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7895
{	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x54F3E9*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x54F5E9*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x54F7E9*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x54F9E9*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x54FBE9*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x54FDE9*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x54FFE9*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x5501E9*/; // 0xE00


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 7973
{	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x550B95*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x550D95*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x550F95*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x551195*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x551395*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x551595*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x551795*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x551995*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x551B95*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x551D95*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x551F95*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x552195*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x552395*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x552595*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x552795*/; // 0x1C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-15 /*Metadata offset 0x552995*/; // 0x1E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-16 /*Metadata offset 0x552B95*/; // 0x2000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-17 /*Metadata offset 0x552D95*/; // 0x2200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-18 /*Metadata offset 0x552F95*/; // 0x2400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-19 /*Metadata offset 0x553195*/; // 0x2600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-20 /*Metadata offset 0x553395*/; // 0x2800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-21 /*Metadata offset 0x553595*/; // 0x2A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-22 /*Metadata offset 0x553795*/; // 0x2C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-23 /*Metadata offset 0x553995*/; // 0x2E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-24 /*Metadata offset 0x553B95*/; // 0x3000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-25 /*Metadata offset 0x553D95*/; // 0x3200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-26 /*Metadata offset 0x553F95*/; // 0x3400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-27 /*Metadata offset 0x554195*/; // 0x3600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-28 /*Metadata offset 0x554395*/; // 0x3800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-29 /*Metadata offset 0x554595*/; // 0x3A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-30 /*Metadata offset 0x554795*/; // 0x3C00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-31 /*Metadata offset 0x554995*/; // 0x3E00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-32 /*Metadata offset 0x554B95*/; // 0x4000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-33 /*Metadata offset 0x554D95*/; // 0x4200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-34 /*Metadata offset 0x554F95*/; // 0x4400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-35 /*Metadata offset 0x555195*/; // 0x4600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-36 /*Metadata offset 0x555395*/; // 0x4800


	public void .ctor() { }

}

internal class <PrivateImplementationDetails> // TypeDefIndex: 8007
{	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-0 /*Metadata offset 0x555D41*/; // 0x0
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-1 /*Metadata offset 0x555F41*/; // 0x200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-2 /*Metadata offset 0x556141*/; // 0x400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-3 /*Metadata offset 0x556341*/; // 0x600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-4 /*Metadata offset 0x556541*/; // 0x800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-5 /*Metadata offset 0x556741*/; // 0xA00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-6 /*Metadata offset 0x556941*/; // 0xC00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-7 /*Metadata offset 0x556B41*/; // 0xE00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-8 /*Metadata offset 0x556D41*/; // 0x1000
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-9 /*Metadata offset 0x556F41*/; // 0x1200
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-10 /*Metadata offset 0x557141*/; // 0x1400
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-11 /*Metadata offset 0x557341*/; // 0x1600
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-12 /*Metadata offset 0x557541*/; // 0x1800
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-13 /*Metadata offset 0x557741*/; // 0x1A00
	internal static <PrivateImplementationDetails>.$ArrayType$512 $$field-14 /*Metadata offset 0x557941*/; // 0x1C00


	public void .ctor() { }

}

public class CC_AnalogTV : CC_Base // TypeDefIndex: 8034
{	public float phase; // 0x28
	public bool grayscale; // 0x2C
	public float noiseIntensity; // 0x30
	public float scanlinesIntensity; // 0x34
	public float scanlinesCount; // 0x38
	public float distortion; // 0x3C
	public float cubicDistortion; // 0x40
	public float scale; // 0x44


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Base : MonoBehaviour // TypeDefIndex: 8035
{	public Shader shader; // 0x18
	protected Material _material; // 0x20

	protected Material material { get; }


	protected virtual void Start() { }

	protected Material get_material() { }

	protected virtual void OnDisable() { }

	public void .ctor() { }

}

public class CC_BleachBypass : CC_Base // TypeDefIndex: 8036
{	public float amount; // 0x28


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Blend : CC_Base // TypeDefIndex: 8037
{	public Texture texture; // 0x28
	public float amount; // 0x30
	public int mode; // 0x34


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_BrightnessContrastGamma : CC_Base // TypeDefIndex: 8038
{	public float redCoeff; // 0x28
	public float greenCoeff; // 0x2C
	public float blueCoeff; // 0x30
	public float brightness; // 0x34
	public float contrast; // 0x38
	public float gamma; // 0x3C


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_ChannelMixer : CC_Base // TypeDefIndex: 8039
{	public float redR; // 0x28
	public float redG; // 0x2C
	public float redB; // 0x30
	public float greenR; // 0x34
	public float greenG; // 0x38
	public float greenB; // 0x3C
	public float blueR; // 0x40
	public float blueG; // 0x44
	public float blueB; // 0x48
	public float constantR; // 0x4C
	public float constantG; // 0x50
	public float constantB; // 0x54


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Convolution3x3 : CC_Base // TypeDefIndex: 8040
{	public Vector3 kernelTop; // 0x28
	public Vector3 kernelMiddle; // 0x34
	public Vector3 kernelBottom; // 0x40
	public float divisor; // 0x4C
	public float amount; // 0x50


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_CrossStitch : CC_Base // TypeDefIndex: 8041
{	public int size; // 0x28
	public float brightness; // 0x2C
	public bool invert; // 0x30
	public bool pixelize; // 0x31


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_DoubleVision : CC_Base, IImageEffect // TypeDefIndex: 8042
{	public Vector2 displace; // 0x28
	public float amount; // 0x30


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_FastVignette : CC_Base // TypeDefIndex: 8043
{	public float sharpness; // 0x28
	public float darkness; // 0x2C
	public bool desaturate; // 0x30


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Frost : CC_Base, IImageEffect // TypeDefIndex: 8044
{	public float scale; // 0x28
	public float sharpness; // 0x2C
	public float darkness; // 0x30
	public bool enableVignette; // 0x34


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_GradientRamp : CC_Base // TypeDefIndex: 8045
{	public Texture rampTexture; // 0x28
	public float amount; // 0x30


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Grayscale : CC_Base, IImageEffect // TypeDefIndex: 8046
{	public float redLuminance; // 0x28
	public float greenLuminance; // 0x2C
	public float blueLuminance; // 0x30
	public float amount; // 0x34


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Halftone : CC_Base // TypeDefIndex: 8047
{	public float density; // 0x28
	public int mode; // 0x2C
	public bool antialiasing; // 0x30
	public bool showOriginal; // 0x31


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_HueSaturationValue : CC_Base // TypeDefIndex: 8048
{	public float hue; // 0x28
	public float saturation; // 0x2C
	public float value; // 0x30


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Led : CC_Base // TypeDefIndex: 8049
{	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public float brightness; // 0x34
	public int mode; // 0x38


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Levels : CC_Base // TypeDefIndex: 8050
{	public int mode; // 0x28
	public float inputMinL; // 0x2C
	public float inputMaxL; // 0x30
	public float inputGammaL; // 0x34
	public float inputMinR; // 0x38
	public float inputMaxR; // 0x3C
	public float inputGammaR; // 0x40
	public float inputMinG; // 0x44
	public float inputMaxG; // 0x48
	public float inputGammaG; // 0x4C
	public float inputMinB; // 0x50
	public float inputMaxB; // 0x54
	public float inputGammaB; // 0x58
	public float outputMinL; // 0x5C
	public float outputMaxL; // 0x60
	public float outputMinR; // 0x64
	public float outputMaxR; // 0x68
	public float outputMinG; // 0x6C
	public float outputMaxG; // 0x70
	public float outputMinB; // 0x74
	public float outputMaxB; // 0x78


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_LookupFilter : CC_Base // TypeDefIndex: 8051
{	public Texture lookupTexture; // 0x28


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Negative : CC_Base // TypeDefIndex: 8052
{	public float amount; // 0x28


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_PhotoFilter : CC_Base, IImageEffect // TypeDefIndex: 8053
{	public Color color; // 0x28
	public float density; // 0x38


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Pixelate : CC_Base // TypeDefIndex: 8054
{	public float scale; // 0x28
	public bool automaticRatio; // 0x2C
	public float ratio; // 0x30
	public int mode; // 0x34


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Posterize : CC_Base // TypeDefIndex: 8055
{	public int levels; // 0x28


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_RGBSplit : CC_Base // TypeDefIndex: 8056
{	public float amount; // 0x28
	public float angle; // 0x2C


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_RadialBlur : CC_Base // TypeDefIndex: 8057
{	public float amount; // 0x28
	public Vector2 center; // 0x2C
	public int quality; // 0x34


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Sharpen : CC_Base // TypeDefIndex: 8058
{	public float strength; // 0x28
	public float clamp; // 0x2C


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_SharpenAndVignette : CC_Base, IImageEffect // TypeDefIndex: 8059
{	[HeaderAttribute] // RVA: 0xC3AA0 Offset: 0xC2EA0 VA: 0x1800C3AA0
	public bool applySharpen; // 0x28
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public float strength; // 0x2C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float clamp; // 0x30
	[HeaderAttribute] // RVA: 0xC5040 Offset: 0xC4440 VA: 0x1800C5040
	public bool applyVignette; // 0x34
	[RangeAttribute] // RVA: 0xC5190 Offset: 0xC4590 VA: 0x1800C5190
	public float sharpness; // 0x38
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float darkness; // 0x3C


	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Threshold : CC_Base // TypeDefIndex: 8060
{	public float threshold; // 0x28
	public bool useNoise; // 0x2C
	public float noiseRange; // 0x30


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Vibrance : CC_Base // TypeDefIndex: 8061
{	public float amount; // 0x28


	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class CC_Wiggle : CC_Base, IImageEffect // TypeDefIndex: 8062
{	public float timer; // 0x28
	public float speed; // 0x2C
	public float scale; // 0x30


	private void Update() { }

	public bool IsActive() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 8239
{	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 1DC4C1B55DC0F7A09DD49557857282243A661721 /*Metadata offset 0x55800C*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 4D97B7EA75C57A5C53C1E01B1C6253465DE43B65 /*Metadata offset 0x55CC6C*/; // 0x4C60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 9B733B2872507920FB43A4A60F4CBE3E17200C8C /*Metadata offset 0x55CE10*/; // 0x4E04
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 C01F4A345A0DC451B12954EDA4ED605D0075A2A5 /*Metadata offset 0x560C12*/; // 0x8C06
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 DD09230AEF3C2384FBC6D4B1BC4EADBE9911368E /*Metadata offset 0x564A14*/; // 0xCA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 F2AB9A53871DA3CF4444B73A4D38E5580D8F8ED3 /*Metadata offset 0x564A48*/; // 0xCA3C

}

internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
{
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 // TypeDefIndex: 8241

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9776 // TypeDefIndex: 8242

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15874 // TypeDefIndex: 8243

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19552 // TypeDefIndex: 8244

internal class <Module> // TypeDefIndex: 8245

[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <>f__AnonymousType0<<Identifier>j__TPar, <Name>j__TPar, <State>j__TPar> // TypeDefIndex: 8246
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <Identifier>j__TPar <Identifier>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <Name>j__TPar <Name>i__Field; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x9E9D0 Offset: 0x9DDD0 VA: 0x18009E9D0
	private readonly <State>j__TPar <State>i__Field; // 0x0

	public <Identifier>j__TPar Identifier { get; }
	public <Name>j__TPar Name { get; }
	public <State>j__TPar State { get; }


	public <Identifier>j__TPar get_Identifier() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-<>f__AnonymousType0<object, object, bool>.get_Identifier
	|-<>f__AnonymousType0<object, object, object>.get_Identifier
	*/

	public <Name>j__TPar get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-<>f__AnonymousType0<object, object, bool>.get_Name
	|-<>f__AnonymousType0<object, object, object>.get_Name
	*/

	public <State>j__TPar get_State() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB10C80 Offset: 0xB0F280 VA: 0x180B10C80
	|-<>f__AnonymousType0<object, object, bool>.get_State
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-<>f__AnonymousType0<object, object, object>.get_State
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(<Identifier>j__TPar Identifier, <Name>j__TPar Name, <State>j__TPar State) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1896860 Offset: 0x1894E60 VA: 0x181896860
	|-<>f__AnonymousType0<object, object, bool>..ctor
	|-<>f__AnonymousType0<string, string, bool>..ctor
	|
	|-RVA: 0x18968D0 Offset: 0x1894ED0 VA: 0x1818968D0
	|-<>f__AnonymousType0<object, object, object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override bool Equals(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1896190 Offset: 0x1894790 VA: 0x181896190
	|-<>f__AnonymousType0<object, object, bool>.Equals
	|
	|-RVA: 0x1896070 Offset: 0x1894670 VA: 0x181896070
	|-<>f__AnonymousType0<object, object, object>.Equals
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18962B0 Offset: 0x18948B0 VA: 0x1818962B0
	|-<>f__AnonymousType0<object, object, bool>.GetHashCode
	|
	|-RVA: 0x18963A0 Offset: 0x18949A0 VA: 0x1818963A0
	|-<>f__AnonymousType0<object, object, object>.GetHashCode
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1896490 Offset: 0x1894A90 VA: 0x181896490
	|-<>f__AnonymousType0<object, object, bool>.ToString
	|
	|-RVA: 0x1896670 Offset: 0x1894C70 VA: 0x181896670
	|-<>f__AnonymousType0<object, object, object>.ToString
	*/

}

public class v_chainsaw : MonoBehaviour // TypeDefIndex: 8896
{	public bool bAttacking; // 0x18
	public bool bHitMetal; // 0x19
	public bool bHitWood; // 0x1A
	public bool bHitFlesh; // 0x1B
	public bool bEngineOn; // 0x1C
	public ParticleSystem[] hitMetalFX; // 0x20
	public ParticleSystem[] hitWoodFX; // 0x28
	public ParticleSystem[] hitFleshFX; // 0x30
	public SoundDefinition hitMetalSoundDef; // 0x38
	public SoundDefinition hitWoodSoundDef; // 0x40
	public SoundDefinition hitFleshSoundDef; // 0x48
	public Sound hitSound; // 0x50
	public GameObject hitSoundTarget; // 0x58
	public float hitSoundFadeTime; // 0x60
	public ParticleSystem smokeEffect; // 0x68
	public Animator chainsawAnimator; // 0x70
	public Renderer chainRenderer; // 0x78
	public Material chainlink; // 0x80
	private MaterialPropertyBlock block; // 0x88
	private Vector2 saveST; // 0x90
	private float chainSpeed; // 0x98
	private float chainAmount; // 0x9C
	public float temp1; // 0xA0
	public float temp2; // 0xA4


	public void OnEnable() { }

	private void Awake() { }

	private void Start() { }

	private void ScrollChainTexture() { }

	private void Update() { }

	private void DoHitSound(SoundDefinition soundDef) { }

	public void .ctor() { }

}

internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
{
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 12153
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 08A598D3DC7ED63443A0CAF087F7CDF5BAA67E3D /*Metadata offset 0x56AB15*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 0ED907628EE272F93737B500A23D77C9B1C88368 /*Metadata offset 0x56AB2D*/; // 0x18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 17ADC9F18EEFE619644F7B3C7C90D5FD8DCDE2BB /*Metadata offset 0x56AB41*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 1C910D34886830DDE4A52B59726EB240ADBF9F34 /*Metadata offset 0x56AB5D*/; // 0x48
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 2277B245F935EBA3EA2D03B6871C13871FD4D572 /*Metadata offset 0x56AB63*/; // 0x4E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 24F287DA5BA36E31C3946E2FBE95B8388C241662 /*Metadata offset 0x56AB73*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 386DD6935C2F38BB8114CA4DF96C8BC2D3E639DA /*Metadata offset 0x56AB8B*/; // 0x76
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42A4001D1CFDC98C761C0CFE5497A75F739D92F8 /*Metadata offset 0x56AB97*/; // 0x82
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 43A214299CEA27B6A55E61A929FC7B62C5D4941E /*Metadata offset 0x56ABA3*/; // 0x8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 44D235DAFB9C469EBDA7640EB1F2CC833B40E9E5 /*Metadata offset 0x56B3A3*/; // 0x88E
	internal static readonly long 4CAECE539B039B16E16206EA2478F8C5FFB2CA05 = 727905341920923785; // 0x8D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 59E933D7501F1D8F431F5807AC6C357BBA5F2D58 /*Metadata offset 0x56B3EB*/; // 0x8D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 6B8D5CC14D2709C84958ED5E3855C874DA314CB4 /*Metadata offset 0x56B403*/; // 0x8F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6BA637A252B6BFA8895B67AD72DCCAE79715984C /*Metadata offset 0x56B503*/; // 0x9F0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=80 6DBA8D05A3CD51B9E01E83FDDF49241693E5D4E4 /*Metadata offset 0x56B543*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 843D396E2EE569B035A7AC2BEB7A8253FC4AEDA7 /*Metadata offset 0x56B593*/; // 0xA80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9365FDAD4BD75AEF9446E0B22483D217BE36E309 /*Metadata offset 0x56B59F*/; // 0xA8C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 9EFF88EB2F3540C5CE20FEF36A8E3AA37629AF80 /*Metadata offset 0x56B5B7*/; // 0xAA4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 B9B198B061D08812F585C9E56641F4E897E88E38 /*Metadata offset 0x56B6D7*/; // 0xBC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 C18072E27FC2B4816C8694EB22427195375388F0 /*Metadata offset 0x56B6E3*/; // 0xBD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 C7F420F4B2F68D0B3647564554BA8DB99509F64F /*Metadata offset 0x56B71B*/; // 0xC08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D950356082C70AD4018410AD313BA99D655D4D4A /*Metadata offset 0x56B737*/; // 0xC24
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 E3D5EABE71635FCDE2C05162A6CDE245A9796318 /*Metadata offset 0x56B743*/; // 0xC30
	internal static readonly long FCBA60311CDE80DE090AE6F8834C9CEC477FA56A = 5927942488114331648; // 0xCB0


	internal static uint ComputeStringHash(string s) { }

}

