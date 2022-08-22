public struct List.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1490
{	// Fields
	private List<T> list; // 0x0
	private int index; // 0x0
	private int version; // 0x0
	private T current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F760 Offset: 0x11EB60 VA: 0x18011F760
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>..ctor
	|-List.Enumerator<AlignedLineDrawer.LinePoint>..ctor
	|-List.Enumerator<Cassette.LoadRequest>..ctor
	|-List.Enumerator<Admin.ServerConvarInfo>..ctor
	|-List.Enumerator<Chat.MuteEntry>..ctor
	|-List.Enumerator<ERChildsSO>..ctor
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>..ctor
	|-List.Enumerator<LocalClock.TimedEvent>..ctor
	|-List.Enumerator<MapView.MapMarkerCluster>..ctor
	|-List.Enumerator<MapView.SleepingBagCluster>..ctor
	|-List.Enumerator<JsonPosition>..ctor
	|-List.Enumerator<TimelineEvent>..ctor
	|-List.Enumerator<TickRenderer.Tick>..ctor
	|-List.Enumerator<InventoryRecipe.Ingredient>..ctor
	|-List.Enumerator<InventoryRecipe>..ctor
	|-List.Enumerator<SynchronizedClock.TimedEvent>..ctor
	|-List.Enumerator<KeyValuePair<object, Color>>..ctor
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>..ctor
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x11F6C0 Offset: 0x11EAC0 VA: 0x18011F6C0
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>..ctor
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>..ctor
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>..ctor
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>..ctor
	|-List.Enumerator<CombineClass>..ctor
	|-List.Enumerator<ERLane>..ctor
	|-List.Enumerator<EntityRef<object>>..ctor
	|-List.Enumerator<TabbedPanel.Tab>..ctor
	|-List.Enumerator<RCon.BannedAddresses>..ctor
	|-List.Enumerator<WeightedStringList.Container>..ctor
	|-List.Enumerator<GameStat.Stat>..ctor
	|-List.Enumerator<ImageStorageEntity.ImageRequest>..ctor
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>..ctor
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>..ctor
	|-List.Enumerator<PlayerItemRecipe>..ctor
	|-List.Enumerator<DemoShotParentKeyframe>..ctor
	|-List.Enumerator<DemoShotVectorKeyframe>..ctor
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>..ctor
	|-List.Enumerator<MatchMakingKeyValuePair>..ctor
	|-List.Enumerator<Dispatch.Callback>..ctor
	|-List.Enumerator<DictionaryEntry>..ctor
	|-List.Enumerator<KeyValuePair<DateTime, object>>..ctor
	|-List.Enumerator<KeyValuePair<int, object>>..ctor
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>..ctor
	|-List.Enumerator<KeyValuePair<object, object>>..ctor
	|-List.Enumerator<KeyValuePair<object, float>>..ctor
	|-List.Enumerator<KeyValuePair<uint, object>>..ctor
	|-List.Enumerator<DateTimeOffset>..ctor
	|-List.Enumerator<Decimal>..ctor
	|-List.Enumerator<Guid>..ctor
	|-List.Enumerator<ValueTuple<object, object>>..ctor
	|-List.Enumerator<RangePositionInfo>..ctor
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-List.Enumerator<TickInterpolator.Segment>..ctor
	|-List.Enumerator<NavMeshBuildMarkup>..ctor
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>..ctor
	|-List.Enumerator<Color>..ctor
	|-List.Enumerator<Rect>..ctor
	|-List.Enumerator<GlyphRect>..ctor
	|-List.Enumerator<FocusController.FocusedElement>..ctor
	|-List.Enumerator<UILineInfo>..ctor
	|-List.Enumerator<Vector4>..ctor
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>..ctor
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>..ctor
	|
	|-RVA: 0x11F620 Offset: 0x11EA20 VA: 0x18011F620
	|-List.Enumerator<BaseEntity.ServerFileRequest>..ctor
	|-List.Enumerator<CardTableUI.KeycodeWithAction>..ctor
	|-List.Enumerator<Demos.DemoInfo>..ctor
	|-List.Enumerator<Output.Entry>..ctor
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>..ctor
	|-List.Enumerator<InvokeAction>..ctor
	|-List.Enumerator<ItemSkinDirectory.Skin>..ctor
	|-List.Enumerator<KeyframeView.UIKeyframeValue>..ctor
	|-List.Enumerator<MidiConvar.KnobBinding>..ctor
	|-List.Enumerator<MidiConvar.NoteBinding>..ctor
	|-List.Enumerator<WaypointSet.Waypoint>..ctor
	|-List.Enumerator<TransformSnapshot>..ctor
	|-List.Enumerator<Option>..ctor
	|-List.Enumerator<SkinnedMultiMesh.Part>..ctor
	|-List.Enumerator<SubmarineSonar.SonarBlip>..ctor
	|-List.Enumerator<SpawnIndividual>..ctor
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>..ctor
	|-List.Enumerator<InventoryItem>..ctor
	|
	|-RVA: 0x11F7B0 Offset: 0x11EBB0 VA: 0x18011F7B0
	|-List.Enumerator<Admin.PlayerInfo>..ctor
	|-List.Enumerator<PlaceMonuments.SpawnInfo>..ctor
	|
	|-RVA: 0x11F8B0 Offset: 0x11ECB0 VA: 0x18011F8B0
	|-List.Enumerator<Admin.ServerUGCInfo>..ctor
	|-List.Enumerator<CapsuleParams>..ctor
	|-List.Enumerator<SkeletonDefinition.Bone>..ctor
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>..ctor
	|-List.Enumerator<SteamNewsSource.Story>..ctor
	|-List.Enumerator<InventoryItem.Amount>..ctor
	|-List.Enumerator<RenderTargetIdentifier>..ctor
	|-List.Enumerator<TreeInstance>..ctor
	|-List.Enumerator<ViewModelDrawEvent>..ctor
	|
	|-RVA: 0x11FA00 Offset: 0x11EE00 VA: 0x18011FA00
	|-List.Enumerator<CRedge>..ctor
	|-List.Enumerator<ProjectileWeaponMod.Modifier>..ctor
	|-List.Enumerator<VectorData>..ctor
	|-List.Enumerator<TrainCar.TrainCarSnapshot>..ctor
	|-List.Enumerator<Resolution>..ctor
	|-List.Enumerator<UICharInfo>..ctor
	|-List.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x11F860 Offset: 0x11EC60 VA: 0x18011F860
	|-List.Enumerator<ERCell>..ctor
	|-List.Enumerator<ERConnectionGUIStatus>..ctor
	|-List.Enumerator<ERTerrainChange>..ctor
	|-List.Enumerator<NormalPairs>..ctor
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>..ctor
	|-List.Enumerator<BurstCloth.Chain>..ctor
	|-List.Enumerator<MeshRendererLookup.LookupEntry>..ctor
	|-List.Enumerator<PathFinder.Point>..ctor
	|-List.Enumerator<PlayerItemRecipe.Ingredient>..ctor
	|-List.Enumerator<DemoShotFloatKeyframe>..ctor
	|-List.Enumerator<Achievement>..ctor
	|-List.Enumerator<Friend>..ctor
	|-List.Enumerator<DateTime>..ctor
	|-List.Enumerator<EventProvider.SessionInfo>..ctor
	|-List.Enumerator<double>..ctor
	|-List.Enumerator<long>..ctor
	|-List.Enumerator<object>..ctor
	|-List.Enumerator<TimeSpan>..ctor
	|-List.Enumerator<ulong>..ctor
	|-List.Enumerator<Vector2>..ctor
	|-List.Enumerator<Vector2i>..ctor
	|
	|-RVA: 0x149980 Offset: 0x148D80 VA: 0x180149980
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>..ctor
	|-List.Enumerator<RenderInfo.RendererInstance>..ctor
	|-List.Enumerator<Option>..ctor
	|
	|-RVA: 0x1498D0 Offset: 0x148CD0 VA: 0x1801498D0
	|-List.Enumerator<ERSOSection>..ctor
	|
	|-RVA: 0x149920 Offset: 0x148D20 VA: 0x180149920
	|-List.Enumerator<ERSplatmap>..ctor
	|
	|-RVA: 0x11FAD0 Offset: 0x11EED0 VA: 0x18011FAD0
	|-List.Enumerator<ERVSData>..ctor
	|-List.Enumerator<SqliteKeyReader.KeyInfo>..ctor
	|
	|-RVA: 0x149AA0 Offset: 0x148EA0 VA: 0x180149AA0
	|-List.Enumerator<BoneData>..ctor
	|
	|-RVA: 0x11F670 Offset: 0x11EA70 VA: 0x18011F670
	|-List.Enumerator<Tick.Entry>..ctor
	|-List.Enumerator<Gibbable.OverrideMesh>..ctor
	|-List.Enumerator<MeshInstance>..ctor
	|-List.Enumerator<PetCommandList.PetCommandDesc>..ctor
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>..ctor
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>..ctor
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>..ctor
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>..ctor
	|
	|-RVA: 0x149B10 Offset: 0x148F10 VA: 0x180149B10
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>..ctor
	|
	|-RVA: 0x11F810 Offset: 0x11EC10 VA: 0x18011F810
	|-List.Enumerator<SevenBitNumber>..ctor
	|-List.Enumerator<bool>..ctor
	|-List.Enumerator<byte>..ctor
	|-List.Enumerator<sbyte>..ctor
	|
	|-RVA: 0x11FA50 Offset: 0x11EE50 VA: 0x18011FA50
	|-List.Enumerator<MeshColliderInstance>..ctor
	|
	|-RVA: 0x11FBA0 Offset: 0x11EFA0 VA: 0x18011FBA0
	|-List.Enumerator<MeshColliderLookup.LookupEntry>..ctor
	|
	|-RVA: 0x11FC00 Offset: 0x11F000 VA: 0x18011FC00
	|-List.Enumerator<MeshRendererInstance>..ctor
	|
	|-RVA: 0x11F900 Offset: 0x11ED00 VA: 0x18011F900
	|-List.Enumerator<DemoShotQuaternionKeyframe>..ctor
	|
	|-RVA: 0x11FB30 Offset: 0x11EF30 VA: 0x18011FB30
	|-List.Enumerator<ServerInfo>..ctor
	|-List.Enumerator<ServerInfo>..ctor
	|
	|-RVA: 0x11F950 Offset: 0x11ED50 VA: 0x18011F950
	|-List.Enumerator<InventoryDefId>..ctor
	|-List.Enumerator<int>..ctor
	|-List.Enumerator<Int32Enum>..ctor
	|-List.Enumerator<float>..ctor
	|-List.Enumerator<uint>..ctor
	|-List.Enumerator<Color32>..ctor
	|
	|-RVA: 0x11F710 Offset: 0x11EB10 VA: 0x18011F710
	|-List.Enumerator<char>..ctor
	|-List.Enumerator<short>..ctor
	|-List.Enumerator<ushort>..ctor
	|
	|-RVA: 0x11F5C0 Offset: 0x11E9C0 VA: 0x18011F5C0
	|-List.Enumerator<TraceInfo>..ctor
	|-List.Enumerator<RaycastResult>..ctor
	|
	|-RVA: 0x11F9A0 Offset: 0x11EDA0 VA: 0x18011F9A0
	|-List.Enumerator<NavMeshBuildSource>..ctor
	|
	|-RVA: 0x21C850 Offset: 0x21BC50 VA: 0x18021C850
	|-List.Enumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x21C8A0 Offset: 0x21BCA0 VA: 0x18021C8A0
	|-List.Enumerator<RaycastHit>..ctor
	|
	|-RVA: 0x21C900 Offset: 0x21BD00 VA: 0x18021C900
	|-List.Enumerator<UIVertex>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-List.Enumerator<AIMovePoint>.Dispose
	|-List.Enumerator<AIState>.Dispose
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.Dispose
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.Dispose
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.Dispose
	|-List.Enumerator<BaseAIEvent>.Dispose
	|-List.Enumerator<BaseBulb>.Dispose
	|-List.Enumerator<BaseCollision>.Dispose
	|-List.Enumerator<BaseEntity.ServerFileRequest>.Dispose
	|-List.Enumerator<BaseEntity>.Dispose
	|-List.Enumerator<BaseMeshPaintable>.Dispose
	|-List.Enumerator<BaseMission.MissionInstance>.Dispose
	|-List.Enumerator<BaseNetworkable>.Dispose
	|-List.Enumerator<BaseNpc>.Dispose
	|-List.Enumerator<BasePathNode>.Dispose
	|-List.Enumerator<BasePlayer>.Dispose
	|-List.Enumerator<BaseVehicle.MountPointInfo>.Dispose
	|-List.Enumerator<BaseVehicle>.Dispose
	|-List.Enumerator<BaseVehicleModule>.Dispose
	|-List.Enumerator<BaseViewModel>.Dispose
	|-List.Enumerator<BlendedSoundLoops.Loop>.Dispose
	|-List.Enumerator<BoneRetarget>.Dispose
	|-List.Enumerator<BuildingBlock>.Dispose
	|-List.Enumerator<CH47DropZone>.Dispose
	|-List.Enumerator<CH47LandingZone>.Dispose
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.Dispose
	|-List.Enumerator<Cassette.LoadRequest>.Dispose
	|-List.Enumerator<CinematicEntity>.Dispose
	|-List.Enumerator<ClientIOLine>.Dispose
	|-List.Enumerator<CoalingTower>.Dispose
	|-List.Enumerator<ComponentInfo>.Dispose
	|-List.Enumerator<Admin.PlayerInfo>.Dispose
	|-List.Enumerator<Admin.ServerConvarInfo>.Dispose
	|-List.Enumerator<Admin.ServerUGCInfo>.Dispose
	|-List.Enumerator<Chat.MuteEntry>.Dispose
	|-List.Enumerator<ConnectedSpeaker>.Dispose
	|-List.Enumerator<ConvarComponent.ConvarEvent>.Dispose
	|-List.Enumerator<CoverageQueries.Query>.Dispose
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.Dispose
	|-List.Enumerator<DecalRecycle>.Dispose
	|-List.Enumerator<DecorSpawn>.Dispose
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.Dispose
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.Dispose
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.Dispose
	|-List.Enumerator<DemoShotEntry>.Dispose
	|-List.Enumerator<DemoShotListFolderWidget>.Dispose
	|-List.Enumerator<Demos.DemoInfo>.Dispose
	|-List.Enumerator<DroppedItem>.Dispose
	|-List.Enumerator<DungeonBaseInfo>.Dispose
	|-List.Enumerator<DungeonBaseLink>.Dispose
	|-List.Enumerator<DungeonBaseSocket>.Dispose
	|-List.Enumerator<DungeonGridCell>.Dispose
	|-List.Enumerator<DungeonGridInfo>.Dispose
	|-List.Enumerator<DungeonVolume>.Dispose
	|-List.Enumerator<CRedge>.Dispose
	|-List.Enumerator<CombineClass>.Dispose
	|-List.Enumerator<ERCell>.Dispose
	|-List.Enumerator<ERChildsSO>.Dispose
	|-List.Enumerator<ERConnectionGUIStatus>.Dispose
	|-List.Enumerator<ERDecal>.Dispose
	|-List.Enumerator<ERLane>.Dispose
	|-List.Enumerator<ERLaneConnector>.Dispose
	|-List.Enumerator<ERLocalGrid>.Dispose
	|-List.Enumerator<ERMarkerExt>.Dispose
	|-List.Enumerator<ERMesh>.Dispose
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.Dispose
	|-List.Enumerator<ERModularRoad>.Dispose
	|-List.Enumerator<ERSOMarkerExt>.Dispose
	|-List.Enumerator<ERSORoadExt>.Dispose
	|-List.Enumerator<ERSOSection>.Dispose
	|-List.Enumerator<ERSideWalk>.Dispose
	|-List.Enumerator<ERSplatmap>.Dispose
	|-List.Enumerator<ERTerrainChange>.Dispose
	|-List.Enumerator<ERTerrainData>.Dispose
	|-List.Enumerator<ERTreeInstance>.Dispose
	|-List.Enumerator<ERVSData>.Dispose
	|-List.Enumerator<NormalPairs>.Dispose
	|-List.Enumerator<OQQCCQCDQQ>.Dispose
	|-List.Enumerator<QDOODOQQDQODD>.Dispose
	|-List.Enumerator<QDQDOOQQDQODD>.Dispose
	|-List.Enumerator<SideObject>.Dispose
	|-List.Enumerator<tPoint>.Dispose
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.Dispose
	|-List.Enumerator<EntityRef<LootContainer>>.Dispose
	|-List.Enumerator<EntityRef<object>>.Dispose
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.Dispose
	|-List.Enumerator<BurstCloth.Chain>.Dispose
	|-List.Enumerator<BurstCloth>.Dispose
	|-List.Enumerator<CapsuleParams>.Dispose
	|-List.Enumerator<BoneData>.Dispose
	|-List.Enumerator<TabbedPanel.Tab>.Dispose
	|-List.Enumerator<Input.Button>.Dispose
	|-List.Enumerator<Output.Entry>.Dispose
	|-List.Enumerator<RCon.BannedAddresses>.Dispose
	|-List.Enumerator<RCon.RConClient>.Dispose
	|-List.Enumerator<SkeletonDefinition.Bone>.Dispose
	|-List.Enumerator<SkeletonSkin>.Dispose
	|-List.Enumerator<Tick.Entry>.Dispose
	|-List.Enumerator<RenderInfo.RendererInstance>.Dispose
	|-List.Enumerator<WeightedStringList.Container>.Dispose
	|-List.Enumerator<FavouriteRadioStation>.Dispose
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.Dispose
	|-List.Enumerator<FruitScale>.Dispose
	|-List.Enumerator<ICommandCenterListener>.Dispose
	|-List.Enumerator<JSONNode>.Dispose
	|-List.Enumerator<Option>.Dispose
	|-List.Enumerator<GameStat.Stat>.Dispose
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.Dispose
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.Dispose
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.Dispose
	|-List.Enumerator<GenerateRailRing.RingNode>.Dispose
	|-List.Enumerator<GenerateRoadLayout.PathNode>.Dispose
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.Dispose
	|-List.Enumerator<GenerateRoadRing.RingNode>.Dispose
	|-List.Enumerator<Gib>.Dispose
	|-List.Enumerator<Gibbable.OverrideMesh>.Dispose
	|-List.Enumerator<GlassPane>.Dispose
	|-List.Enumerator<GraveyardFence>.Dispose
	|-List.Enumerator<HitboxDefinition>.Dispose
	|-List.Enumerator<HitboxSystem.HitboxShape>.Dispose
	|-List.Enumerator<IClientComponentEx>.Dispose
	|-List.Enumerator<IEffect>.Dispose
	|-List.Enumerator<IItemSetup>.Dispose
	|-List.Enumerator<IItemUpdate>.Dispose
	|-List.Enumerator<IPlayerItemDefinition>.Dispose
	|-List.Enumerator<IPrefabPostProcess>.Dispose
	|-List.Enumerator<IPrefabPreProcess>.Dispose
	|-List.Enumerator<IRagdollInhert>.Dispose
	|-List.Enumerator<IServerComponentEx>.Dispose
	|-List.Enumerator<IconSkin>.Dispose
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.Dispose
	|-List.Enumerator<ImageEffectLayer>.Dispose
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.Dispose
	|-List.Enumerator<InstrumentKeyController>.Dispose
	|-List.Enumerator<InvokeAction>.Dispose
	|-List.Enumerator<Item>.Dispose
	|-List.Enumerator<ItemAmount>.Dispose
	|-List.Enumerator<ItemBlueprint>.Dispose
	|-List.Enumerator<ItemContainer>.Dispose
	|-List.Enumerator<ItemDefinition>.Dispose
	|-List.Enumerator<ItemIcon>.Dispose
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.Dispose
	|-List.Enumerator<ItemPickupNotice>.Dispose
	|-List.Enumerator<ItemSkinDirectory.Skin>.Dispose
	|-List.Enumerator<ItemSlot>.Dispose
	|-List.Enumerator<Value>.Dispose
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.Dispose
	|-List.Enumerator<KeyframeWidget>.Dispose
	|-List.Enumerator<LODComponent>.Dispose
	|-List.Enumerator<LandmarkInfo>.Dispose
	|-List.Enumerator<LifeScale>.Dispose
	|-List.Enumerator<LoadAssetsResult>.Dispose
	|-List.Enumerator<LocalClock.TimedEvent>.Dispose
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.Dispose
	|-List.Enumerator<MapMarker>.Dispose
	|-List.Enumerator<MapView.MapMarkerCluster>.Dispose
	|-List.Enumerator<MapView.SleepingBagCluster>.Dispose
	|-List.Enumerator<MaterialReplacement>.Dispose
	|-List.Enumerator<SevenBitNumber>.Dispose
	|-List.Enumerator<ValueChange<TimeSignature>>.Dispose
	|-List.Enumerator<MeshColliderInstance>.Dispose
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.Dispose
	|-List.Enumerator<MeshInstance>.Dispose
	|-List.Enumerator<MeshRendererInstance>.Dispose
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.Dispose
	|-List.Enumerator<MidiConvar.KnobBinding>.Dispose
	|-List.Enumerator<MidiConvar.NoteBinding>.Dispose
	|-List.Enumerator<MissionMapMarker>.Dispose
	|-List.Enumerator<Modifier>.Dispose
	|-List.Enumerator<ModifierDefintion>.Dispose
	|-List.Enumerator<SqliteFunctionAttribute>.Dispose
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.Dispose
	|-List.Enumerator<SqliteParameter>.Dispose
	|-List.Enumerator<MonumentInfo>.Dispose
	|-List.Enumerator<MonumentMarker>.Dispose
	|-List.Enumerator<MorphCache>.Dispose
	|-List.Enumerator<Connection>.Dispose
	|-List.Enumerator<IXmlNode>.Dispose
	|-List.Enumerator<JsonPosition>.Dispose
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.Dispose
	|-List.Enumerator<SerializationCallback>.Dispose
	|-List.Enumerator<OutlineObject>.Dispose
	|-List.Enumerator<PaintableItem>.Dispose
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.Dispose
	|-List.Enumerator<PathFinder.Node>.Dispose
	|-List.Enumerator<PathFinder.Point>.Dispose
	|-List.Enumerator<PathList.MeshObject>.Dispose
	|-List.Enumerator<PathList>.Dispose
	|-List.Enumerator<PatternFireworkStar>.Dispose
	|-List.Enumerator<PetCommandList.PetCommandDesc>.Dispose
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.Dispose
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.Dispose
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.Dispose
	|-List.Enumerator<PlayerItemRecipe>.Dispose
	|-List.Enumerator<PlayerModel>.Dispose
	|-List.Enumerator<PlayerModelSkin>.Dispose
	|-List.Enumerator<PowerlineNode>.Dispose
	|-List.Enumerator<Projectile>.Dispose
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.Dispose
	|-List.Enumerator<AIEventData>.Dispose
	|-List.Enumerator<AIStateContainer>.Dispose
	|-List.Enumerator<ArcadeGame.arcadeEnt>.Dispose
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.Dispose
	|-List.Enumerator<DemoShot>.Dispose
	|-List.Enumerator<DemoShotFloatKeyframe>.Dispose
	|-List.Enumerator<DemoShotParentKeyframe>.Dispose
	|-List.Enumerator<DemoShotQuaternionKeyframe>.Dispose
	|-List.Enumerator<DemoShotVectorKeyframe>.Dispose
	|-List.Enumerator<EggHunt.EggHunter>.Dispose
	|-List.Enumerator<FileStorageCacheData>.Dispose
	|-List.Enumerator<GameMode.PlayerScore>.Dispose
	|-List.Enumerator<GameMode.ScoreColumn>.Dispose
	|-List.Enumerator<GameMode.TeamInfo>.Dispose
	|-List.Enumerator<InstrumentMidiBinding>.Dispose
	|-List.Enumerator<InstrumentRecordingNote>.Dispose
	|-List.Enumerator<Item>.Dispose
	|-List.Enumerator<ItemContainer>.Dispose
	|-List.Enumerator<LightString.StringPoint>.Dispose
	|-List.Enumerator<LinePoint>.Dispose
	|-List.Enumerator<MapNote>.Dispose
	|-List.Enumerator<MarketTerminal.PendingOrder>.Dispose
	|-List.Enumerator<MissionInstance>.Dispose
	|-List.Enumerator<Modifier>.Dispose
	|-List.Enumerator<NeonSign.Lights>.Dispose
	|-List.Enumerator<PatternFirework.Star>.Dispose
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.Dispose
	|-List.Enumerator<PlayerLifeStory.GenericStat>.Dispose
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.Dispose
	|-List.Enumerator<PlayerTeam.TeamMember>.Dispose
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.Dispose
	|-List.Enumerator<RespawnInformation.SpawnOptions>.Dispose
	|-List.Enumerator<Tree>.Dispose
	|-List.Enumerator<VectorData>.Dispose
	|-List.Enumerator<VendingMachine.SellOrder>.Dispose
	|-List.Enumerator<VoicemailEntry>.Dispose
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.Dispose
	|-List.Enumerator<Recipe>.Dispose
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.Dispose
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.Dispose
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.Dispose
	|-List.Enumerator<WaypointSet.Waypoint>.Dispose
	|-List.Enumerator<DamageTypeEntry>.Dispose
	|-List.Enumerator<TransformSnapshot>.Dispose
	|-List.Enumerator<ConditionalObject>.Dispose
	|-List.Enumerator<TimelineEvent>.Dispose
	|-List.Enumerator<Option>.Dispose
	|-List.Enumerator<TickRenderer.Tick>.Dispose
	|-List.Enumerator<RustButton>.Dispose
	|-List.Enumerator<ServerAdminPlayerEntry>.Dispose
	|-List.Enumerator<ServerAdminUGCEntry>.Dispose
	|-List.Enumerator<ServerAdminUGCEntryPattern>.Dispose
	|-List.Enumerator<TimelineMarker>.Dispose
	|-List.Enumerator<SellOrderEntry>.Dispose
	|-List.Enumerator<ServerInfo>.Dispose
	|-List.Enumerator<ShoutcastStream>.Dispose
	|-List.Enumerator<ShoutcastStreamer>.Dispose
	|-List.Enumerator<SkinnedMultiMesh.Part>.Dispose
	|-List.Enumerator<SleepingBag>.Dispose
	|-List.Enumerator<SleepingBagClusterMapMarker>.Dispose
	|-List.Enumerator<SleepingBagMapMarker>.Dispose
	|-List.Enumerator<SlotMachinePayoutWidget>.Dispose
	|-List.Enumerator<SmokeGrenade>.Dispose
	|-List.Enumerator<Socket_Base>.Dispose
	|-List.Enumerator<SubmarineSonar.SonarBlip>.Dispose
	|-List.Enumerator<Sound>.Dispose
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.Dispose
	|-List.Enumerator<SpawnIndividual>.Dispose
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.Dispose
	|-List.Enumerator<SteamNewsSource.Story>.Dispose
	|-List.Enumerator<Achievement>.Dispose
	|-List.Enumerator<InventoryDefId>.Dispose
	|-List.Enumerator<MatchMakingKeyValuePair>.Dispose
	|-List.Enumerator<ServerInfo>.Dispose
	|-List.Enumerator<Dispatch.Callback>.Dispose
	|-List.Enumerator<Friend>.Dispose
	|-List.Enumerator<InventoryItem.Amount>.Dispose
	|-List.Enumerator<InventoryItem>.Dispose
	|-List.Enumerator<InventoryRecipe.Ingredient>.Dispose
	|-List.Enumerator<InventoryRecipe>.Dispose
	|-List.Enumerator<SteamClass>.Dispose
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.Dispose
	|-List.Enumerator<SynchronizedClock.TimedEvent>.Dispose
	|-List.Enumerator<Action>.Dispose
	|-List.Enumerator<Action<IntPtr>>.Dispose
	|-List.Enumerator<bool>.Dispose
	|-List.Enumerator<byte>.Dispose
	|-List.Enumerator<char>.Dispose
	|-List.Enumerator<DictionaryEntry>.Dispose
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.Dispose
	|-List.Enumerator<KeyValuePair<DateTime, object>>.Dispose
	|-List.Enumerator<KeyValuePair<int, object>>.Dispose
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|-List.Enumerator<KeyValuePair<object, object>>.Dispose
	|-List.Enumerator<KeyValuePair<object, float>>.Dispose
	|-List.Enumerator<KeyValuePair<object, Color>>.Dispose
	|-List.Enumerator<KeyValuePair<uint, object>>.Dispose
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.Dispose
	|-List.Enumerator<List<int>>.Dispose
	|-List.Enumerator<DataColumn>.Dispose
	|-List.Enumerator<DataRelation>.Dispose
	|-List.Enumerator<DataRow>.Dispose
	|-List.Enumerator<DataTable>.Dispose
	|-List.Enumerator<Index>.Dispose
	|-List.Enumerator<DateTime>.Dispose
	|-List.Enumerator<DateTimeOffset>.Dispose
	|-List.Enumerator<Decimal>.Dispose
	|-List.Enumerator<EtwSession>.Dispose
	|-List.Enumerator<EventProvider.SessionInfo>.Dispose
	|-List.Enumerator<FieldMetadata>.Dispose
	|-List.Enumerator<double>.Dispose
	|-List.Enumerator<CultureInfo>.Dispose
	|-List.Enumerator<Guid>.Dispose
	|-List.Enumerator<short>.Dispose
	|-List.Enumerator<int>.Dispose
	|-List.Enumerator<Int32Enum>.Dispose
	|-List.Enumerator<long>.Dispose
	|-List.Enumerator<ModifierSpec>.Dispose
	|-List.Enumerator<NameValueHeaderValue>.Dispose
	|-List.Enumerator<RangeItemHeaderValue>.Dispose
	|-List.Enumerator<IPAddress>.Dispose
	|-List.Enumerator<MonoChunkStream.Chunk>.Dispose
	|-List.Enumerator<WebConnection>.Dispose
	|-List.Enumerator<WebConnectionGroup>.Dispose
	|-List.Enumerator<object>.Dispose
	|-List.Enumerator<FieldInfo>.Dispose
	|-List.Enumerator<MemberInfo>.Dispose
	|-List.Enumerator<MethodInfo>.Dispose
	|-List.Enumerator<ExceptionDispatchInfo>.Dispose
	|-List.Enumerator<IContextProperty>.Dispose
	|-List.Enumerator<sbyte>.Dispose
	|-List.Enumerator<X509CertificateImpl>.Dispose
	|-List.Enumerator<float>.Dispose
	|-List.Enumerator<string>.Dispose
	|-List.Enumerator<IAsyncLocal>.Dispose
	|-List.Enumerator<Task>.Dispose
	|-List.Enumerator<Thread>.Dispose
	|-List.Enumerator<TimeSpan>.Dispose
	|-List.Enumerator<IEnlistmentNotification>.Dispose
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.Dispose
	|-List.Enumerator<Type>.Dispose
	|-List.Enumerator<TypeIdentifier>.Dispose
	|-List.Enumerator<ushort>.Dispose
	|-List.Enumerator<uint>.Dispose
	|-List.Enumerator<ulong>.Dispose
	|-List.Enumerator<ValueTuple<object, object>>.Dispose
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.Dispose
	|-List.Enumerator<WeakReference>.Dispose
	|-List.Enumerator<WeakReference<EtwSession>>.Dispose
	|-List.Enumerator<RangePositionInfo>.Dispose
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Dispose
	|-List.Enumerator<XmlReflectionMember>.Dispose
	|-List.Enumerator<XmlQualifiedName>.Dispose
	|-List.Enumerator<TechTreeData.NodeInstance>.Dispose
	|-List.Enumerator<TechTreeLine>.Dispose
	|-List.Enumerator<TextTable.Row>.Dispose
	|-List.Enumerator<TickInterpolator.Segment>.Dispose
	|-List.Enumerator<TraceInfo>.Dispose
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.Dispose
	|-List.Enumerator<TriggerBase>.Dispose
	|-List.Enumerator<TriggerSafeZone>.Dispose
	|-List.Enumerator<UIMapVendingMachineMarker>.Dispose
	|-List.Enumerator<Underwear>.Dispose
	|-List.Enumerator<NavMeshBuildMarkup>.Dispose
	|-List.Enumerator<NavMeshBuildSource>.Dispose
	|-List.Enumerator<NavMeshLink>.Dispose
	|-List.Enumerator<NavMeshModifier>.Dispose
	|-List.Enumerator<NavMeshModifierVolume>.Dispose
	|-List.Enumerator<AudioSource>.Dispose
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|-List.Enumerator<CharacterJoint>.Dispose
	|-List.Enumerator<Collider>.Dispose
	|-List.Enumerator<Color32>.Dispose
	|-List.Enumerator<Color>.Dispose
	|-List.Enumerator<Component>.Dispose
	|-List.Enumerator<ConfigurableJoint>.Dispose
	|-List.Enumerator<DDraw.BaseObject>.Dispose
	|-List.Enumerator<RaycastResult>.Dispose
	|-List.Enumerator<PersistentCall>.Dispose
	|-List.Enumerator<GUILayoutEntry>.Dispose
	|-List.Enumerator<GameObject>.Dispose
	|-List.Enumerator<ISubsystem>.Dispose
	|-List.Enumerator<ISubsystemDescriptor>.Dispose
	|-List.Enumerator<ISubsystemDescriptorImpl>.Dispose
	|-List.Enumerator<Joint>.Dispose
	|-List.Enumerator<KeyCode>.Dispose
	|-List.Enumerator<LODGroup>.Dispose
	|-List.Enumerator<Material>.Dispose
	|-List.Enumerator<MeshCollider>.Dispose
	|-List.Enumerator<MeshRenderer>.Dispose
	|-List.Enumerator<ParticleSystem>.Dispose
	|-List.Enumerator<PhysicMaterial>.Dispose
	|-List.Enumerator<RaycastHit2D>.Dispose
	|-List.Enumerator<RaycastHit>.Dispose
	|-List.Enumerator<Rect>.Dispose
	|-List.Enumerator<RenderTexture>.Dispose
	|-List.Enumerator<Renderer>.Dispose
	|-List.Enumerator<CommandBuffer>.Dispose
	|-List.Enumerator<PostProcessBundle>.Dispose
	|-List.Enumerator<PostProcessEffectSettings>.Dispose
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.Dispose
	|-List.Enumerator<PostProcessVolume>.Dispose
	|-List.Enumerator<RenderTargetIdentifier>.Dispose
	|-List.Enumerator<Resolution>.Dispose
	|-List.Enumerator<Rigidbody>.Dispose
	|-List.Enumerator<SkinnedMeshRenderer>.Dispose
	|-List.Enumerator<Terrain>.Dispose
	|-List.Enumerator<GlyphRect>.Dispose
	|-List.Enumerator<Texture2D>.Dispose
	|-List.Enumerator<Texture>.Dispose
	|-List.Enumerator<TrailRenderer>.Dispose
	|-List.Enumerator<Transform>.Dispose
	|-List.Enumerator<TreeInstance>.Dispose
	|-List.Enumerator<MaskableGraphic>.Dispose
	|-List.Enumerator<UICharInfo>.Dispose
	|-List.Enumerator<EventCallbackFunctorBase>.Dispose
	|-List.Enumerator<FocusController.FocusedElement>.Dispose
	|-List.Enumerator<IEventDispatchingStrategy>.Dispose
	|-List.Enumerator<Panel>.Dispose
	|-List.Enumerator<VisualElement>.Dispose
	|-List.Enumerator<UILineInfo>.Dispose
	|-List.Enumerator<UIVertex>.Dispose
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|-List.Enumerator<Vector2>.Dispose
	|-List.Enumerator<Vector2[]>.Dispose
	|-List.Enumerator<Vector3>.Dispose
	|-List.Enumerator<Vector4>.Dispose
	|-List.Enumerator<Vector2i>.Dispose
	|-List.Enumerator<ViewModelDrawEvent>.Dispose
	|-List.Enumerator<ViewShake.ShakeParameters>.Dispose
	|-List.Enumerator<VirtualItemIcon>.Dispose
	|-List.Enumerator<VoiceProcessor>.Dispose
	|-List.Enumerator<VoicemailEntry>.Dispose
	|-List.Enumerator<WaterRuntime>.Dispose
	|-List.Enumerator<WearableHairCap>.Dispose
	|-List.Enumerator<WeightedAudioClip>.Dispose
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.Dispose
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB00 Offset: 0x11BF00 VA: 0x18011CB00
	|-List.Enumerator<AIMovePoint>.MoveNext
	|-List.Enumerator<BaseAIEvent>.MoveNext
	|-List.Enumerator<BaseBulb>.MoveNext
	|-List.Enumerator<BaseCollision>.MoveNext
	|-List.Enumerator<BaseEntity>.MoveNext
	|-List.Enumerator<BaseMeshPaintable>.MoveNext
	|-List.Enumerator<BaseMission.MissionInstance>.MoveNext
	|-List.Enumerator<BaseNetworkable>.MoveNext
	|-List.Enumerator<BaseNpc>.MoveNext
	|-List.Enumerator<BasePathNode>.MoveNext
	|-List.Enumerator<BasePlayer>.MoveNext
	|-List.Enumerator<BaseVehicle.MountPointInfo>.MoveNext
	|-List.Enumerator<BaseVehicle>.MoveNext
	|-List.Enumerator<BaseVehicleModule>.MoveNext
	|-List.Enumerator<BaseViewModel>.MoveNext
	|-List.Enumerator<BlendedSoundLoops.Loop>.MoveNext
	|-List.Enumerator<BoneRetarget>.MoveNext
	|-List.Enumerator<BuildingBlock>.MoveNext
	|-List.Enumerator<CH47DropZone>.MoveNext
	|-List.Enumerator<CH47LandingZone>.MoveNext
	|-List.Enumerator<CinematicEntity>.MoveNext
	|-List.Enumerator<ClientIOLine>.MoveNext
	|-List.Enumerator<CoalingTower>.MoveNext
	|-List.Enumerator<ComponentInfo>.MoveNext
	|-List.Enumerator<ConnectedSpeaker>.MoveNext
	|-List.Enumerator<ConvarComponent.ConvarEvent>.MoveNext
	|-List.Enumerator<CoverageQueries.Query>.MoveNext
	|-List.Enumerator<DecalRecycle>.MoveNext
	|-List.Enumerator<DecorSpawn>.MoveNext
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.MoveNext
	|-List.Enumerator<DemoShotEntry>.MoveNext
	|-List.Enumerator<DemoShotListFolderWidget>.MoveNext
	|-List.Enumerator<DroppedItem>.MoveNext
	|-List.Enumerator<DungeonBaseInfo>.MoveNext
	|-List.Enumerator<DungeonBaseLink>.MoveNext
	|-List.Enumerator<DungeonBaseSocket>.MoveNext
	|-List.Enumerator<DungeonGridCell>.MoveNext
	|-List.Enumerator<DungeonGridInfo>.MoveNext
	|-List.Enumerator<DungeonVolume>.MoveNext
	|-List.Enumerator<ERDecal>.MoveNext
	|-List.Enumerator<ERLaneConnector>.MoveNext
	|-List.Enumerator<ERLocalGrid>.MoveNext
	|-List.Enumerator<ERMarkerExt>.MoveNext
	|-List.Enumerator<ERMesh>.MoveNext
	|-List.Enumerator<ERModularRoad>.MoveNext
	|-List.Enumerator<ERSOMarkerExt>.MoveNext
	|-List.Enumerator<ERSORoadExt>.MoveNext
	|-List.Enumerator<ERSideWalk>.MoveNext
	|-List.Enumerator<ERTerrainData>.MoveNext
	|-List.Enumerator<ERTreeInstance>.MoveNext
	|-List.Enumerator<OQQCCQCDQQ>.MoveNext
	|-List.Enumerator<QDOODOQQDQODD>.MoveNext
	|-List.Enumerator<QDQDOOQQDQODD>.MoveNext
	|-List.Enumerator<SideObject>.MoveNext
	|-List.Enumerator<tPoint>.MoveNext
	|-List.Enumerator<BurstCloth>.MoveNext
	|-List.Enumerator<Input.Button>.MoveNext
	|-List.Enumerator<RCon.RConClient>.MoveNext
	|-List.Enumerator<SkeletonSkin>.MoveNext
	|-List.Enumerator<FavouriteRadioStation>.MoveNext
	|-List.Enumerator<FruitScale>.MoveNext
	|-List.Enumerator<ICommandCenterListener>.MoveNext
	|-List.Enumerator<JSONNode>.MoveNext
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.MoveNext
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.MoveNext
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.MoveNext
	|-List.Enumerator<GenerateRailRing.RingNode>.MoveNext
	|-List.Enumerator<GenerateRoadLayout.PathNode>.MoveNext
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.MoveNext
	|-List.Enumerator<GenerateRoadRing.RingNode>.MoveNext
	|-List.Enumerator<Gib>.MoveNext
	|-List.Enumerator<GlassPane>.MoveNext
	|-List.Enumerator<GraveyardFence>.MoveNext
	|-List.Enumerator<HitboxDefinition>.MoveNext
	|-List.Enumerator<HitboxSystem.HitboxShape>.MoveNext
	|-List.Enumerator<IClientComponentEx>.MoveNext
	|-List.Enumerator<IEffect>.MoveNext
	|-List.Enumerator<IItemSetup>.MoveNext
	|-List.Enumerator<IItemUpdate>.MoveNext
	|-List.Enumerator<IPlayerItemDefinition>.MoveNext
	|-List.Enumerator<IPrefabPostProcess>.MoveNext
	|-List.Enumerator<IPrefabPreProcess>.MoveNext
	|-List.Enumerator<IRagdollInhert>.MoveNext
	|-List.Enumerator<IServerComponentEx>.MoveNext
	|-List.Enumerator<IconSkin>.MoveNext
	|-List.Enumerator<ImageEffectLayer>.MoveNext
	|-List.Enumerator<InstrumentKeyController>.MoveNext
	|-List.Enumerator<Item>.MoveNext
	|-List.Enumerator<ItemAmount>.MoveNext
	|-List.Enumerator<ItemBlueprint>.MoveNext
	|-List.Enumerator<ItemContainer>.MoveNext
	|-List.Enumerator<ItemDefinition>.MoveNext
	|-List.Enumerator<ItemIcon>.MoveNext
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.MoveNext
	|-List.Enumerator<ItemPickupNotice>.MoveNext
	|-List.Enumerator<Value>.MoveNext
	|-List.Enumerator<KeyframeWidget>.MoveNext
	|-List.Enumerator<LODComponent>.MoveNext
	|-List.Enumerator<LandmarkInfo>.MoveNext
	|-List.Enumerator<LifeScale>.MoveNext
	|-List.Enumerator<LoadAssetsResult>.MoveNext
	|-List.Enumerator<MapMarker>.MoveNext
	|-List.Enumerator<MaterialReplacement>.MoveNext
	|-List.Enumerator<ValueChange<TimeSignature>>.MoveNext
	|-List.Enumerator<MissionMapMarker>.MoveNext
	|-List.Enumerator<Modifier>.MoveNext
	|-List.Enumerator<ModifierDefintion>.MoveNext
	|-List.Enumerator<SqliteFunctionAttribute>.MoveNext
	|-List.Enumerator<SqliteParameter>.MoveNext
	|-List.Enumerator<MonumentInfo>.MoveNext
	|-List.Enumerator<MonumentMarker>.MoveNext
	|-List.Enumerator<MorphCache>.MoveNext
	|-List.Enumerator<Connection>.MoveNext
	|-List.Enumerator<IXmlNode>.MoveNext
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.MoveNext
	|-List.Enumerator<SerializationCallback>.MoveNext
	|-List.Enumerator<OutlineObject>.MoveNext
	|-List.Enumerator<PaintableItem>.MoveNext
	|-List.Enumerator<PathFinder.Node>.MoveNext
	|-List.Enumerator<PathList.MeshObject>.MoveNext
	|-List.Enumerator<PathList>.MoveNext
	|-List.Enumerator<PatternFireworkStar>.MoveNext
	|-List.Enumerator<PlayerModel>.MoveNext
	|-List.Enumerator<PlayerModelSkin>.MoveNext
	|-List.Enumerator<PowerlineNode>.MoveNext
	|-List.Enumerator<Projectile>.MoveNext
	|-List.Enumerator<AIEventData>.MoveNext
	|-List.Enumerator<AIStateContainer>.MoveNext
	|-List.Enumerator<ArcadeGame.arcadeEnt>.MoveNext
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.MoveNext
	|-List.Enumerator<DemoShot>.MoveNext
	|-List.Enumerator<EggHunt.EggHunter>.MoveNext
	|-List.Enumerator<FileStorageCacheData>.MoveNext
	|-List.Enumerator<GameMode.PlayerScore>.MoveNext
	|-List.Enumerator<GameMode.ScoreColumn>.MoveNext
	|-List.Enumerator<GameMode.TeamInfo>.MoveNext
	|-List.Enumerator<InstrumentMidiBinding>.MoveNext
	|-List.Enumerator<InstrumentRecordingNote>.MoveNext
	|-List.Enumerator<Item>.MoveNext
	|-List.Enumerator<ItemContainer>.MoveNext
	|-List.Enumerator<LightString.StringPoint>.MoveNext
	|-List.Enumerator<LinePoint>.MoveNext
	|-List.Enumerator<MapNote>.MoveNext
	|-List.Enumerator<MarketTerminal.PendingOrder>.MoveNext
	|-List.Enumerator<MissionInstance>.MoveNext
	|-List.Enumerator<Modifier>.MoveNext
	|-List.Enumerator<NeonSign.Lights>.MoveNext
	|-List.Enumerator<PatternFirework.Star>.MoveNext
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.MoveNext
	|-List.Enumerator<PlayerLifeStory.GenericStat>.MoveNext
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.MoveNext
	|-List.Enumerator<PlayerTeam.TeamMember>.MoveNext
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.MoveNext
	|-List.Enumerator<RespawnInformation.SpawnOptions>.MoveNext
	|-List.Enumerator<Tree>.MoveNext
	|-List.Enumerator<VendingMachine.SellOrder>.MoveNext
	|-List.Enumerator<VoicemailEntry>.MoveNext
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.MoveNext
	|-List.Enumerator<Recipe>.MoveNext
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.MoveNext
	|-List.Enumerator<DamageTypeEntry>.MoveNext
	|-List.Enumerator<ConditionalObject>.MoveNext
	|-List.Enumerator<RustButton>.MoveNext
	|-List.Enumerator<ServerAdminPlayerEntry>.MoveNext
	|-List.Enumerator<ServerAdminUGCEntry>.MoveNext
	|-List.Enumerator<ServerAdminUGCEntryPattern>.MoveNext
	|-List.Enumerator<TimelineMarker>.MoveNext
	|-List.Enumerator<SellOrderEntry>.MoveNext
	|-List.Enumerator<ShoutcastStream>.MoveNext
	|-List.Enumerator<ShoutcastStreamer>.MoveNext
	|-List.Enumerator<SleepingBag>.MoveNext
	|-List.Enumerator<SleepingBagClusterMapMarker>.MoveNext
	|-List.Enumerator<SleepingBagMapMarker>.MoveNext
	|-List.Enumerator<SlotMachinePayoutWidget>.MoveNext
	|-List.Enumerator<SmokeGrenade>.MoveNext
	|-List.Enumerator<Socket_Base>.MoveNext
	|-List.Enumerator<Sound>.MoveNext
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.MoveNext
	|-List.Enumerator<SteamClass>.MoveNext
	|-List.Enumerator<Action>.MoveNext
	|-List.Enumerator<Action<IntPtr>>.MoveNext
	|-List.Enumerator<List<int>>.MoveNext
	|-List.Enumerator<DataColumn>.MoveNext
	|-List.Enumerator<DataRelation>.MoveNext
	|-List.Enumerator<DataRow>.MoveNext
	|-List.Enumerator<DataTable>.MoveNext
	|-List.Enumerator<Index>.MoveNext
	|-List.Enumerator<EtwSession>.MoveNext
	|-List.Enumerator<FieldMetadata>.MoveNext
	|-List.Enumerator<CultureInfo>.MoveNext
	|-List.Enumerator<ModifierSpec>.MoveNext
	|-List.Enumerator<NameValueHeaderValue>.MoveNext
	|-List.Enumerator<RangeItemHeaderValue>.MoveNext
	|-List.Enumerator<IPAddress>.MoveNext
	|-List.Enumerator<MonoChunkStream.Chunk>.MoveNext
	|-List.Enumerator<WebConnection>.MoveNext
	|-List.Enumerator<WebConnectionGroup>.MoveNext
	|-List.Enumerator<object>.MoveNext
	|-List.Enumerator<FieldInfo>.MoveNext
	|-List.Enumerator<MemberInfo>.MoveNext
	|-List.Enumerator<MethodInfo>.MoveNext
	|-List.Enumerator<ExceptionDispatchInfo>.MoveNext
	|-List.Enumerator<IContextProperty>.MoveNext
	|-List.Enumerator<X509CertificateImpl>.MoveNext
	|-List.Enumerator<string>.MoveNext
	|-List.Enumerator<IAsyncLocal>.MoveNext
	|-List.Enumerator<Task>.MoveNext
	|-List.Enumerator<Thread>.MoveNext
	|-List.Enumerator<IEnlistmentNotification>.MoveNext
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.MoveNext
	|-List.Enumerator<Type>.MoveNext
	|-List.Enumerator<TypeIdentifier>.MoveNext
	|-List.Enumerator<WeakReference>.MoveNext
	|-List.Enumerator<WeakReference<EtwSession>>.MoveNext
	|-List.Enumerator<XmlReflectionMember>.MoveNext
	|-List.Enumerator<XmlQualifiedName>.MoveNext
	|-List.Enumerator<TechTreeData.NodeInstance>.MoveNext
	|-List.Enumerator<TechTreeLine>.MoveNext
	|-List.Enumerator<TextTable.Row>.MoveNext
	|-List.Enumerator<TriggerBase>.MoveNext
	|-List.Enumerator<TriggerSafeZone>.MoveNext
	|-List.Enumerator<UIMapVendingMachineMarker>.MoveNext
	|-List.Enumerator<Underwear>.MoveNext
	|-List.Enumerator<NavMeshLink>.MoveNext
	|-List.Enumerator<NavMeshModifier>.MoveNext
	|-List.Enumerator<NavMeshModifierVolume>.MoveNext
	|-List.Enumerator<AudioSource>.MoveNext
	|-List.Enumerator<CharacterJoint>.MoveNext
	|-List.Enumerator<Collider>.MoveNext
	|-List.Enumerator<Component>.MoveNext
	|-List.Enumerator<ConfigurableJoint>.MoveNext
	|-List.Enumerator<DDraw.BaseObject>.MoveNext
	|-List.Enumerator<PersistentCall>.MoveNext
	|-List.Enumerator<GUILayoutEntry>.MoveNext
	|-List.Enumerator<GameObject>.MoveNext
	|-List.Enumerator<ISubsystem>.MoveNext
	|-List.Enumerator<ISubsystemDescriptor>.MoveNext
	|-List.Enumerator<ISubsystemDescriptorImpl>.MoveNext
	|-List.Enumerator<Joint>.MoveNext
	|-List.Enumerator<LODGroup>.MoveNext
	|-List.Enumerator<Material>.MoveNext
	|-List.Enumerator<MeshCollider>.MoveNext
	|-List.Enumerator<MeshRenderer>.MoveNext
	|-List.Enumerator<ParticleSystem>.MoveNext
	|-List.Enumerator<PhysicMaterial>.MoveNext
	|-List.Enumerator<RenderTexture>.MoveNext
	|-List.Enumerator<Renderer>.MoveNext
	|-List.Enumerator<CommandBuffer>.MoveNext
	|-List.Enumerator<PostProcessBundle>.MoveNext
	|-List.Enumerator<PostProcessEffectSettings>.MoveNext
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.MoveNext
	|-List.Enumerator<PostProcessVolume>.MoveNext
	|-List.Enumerator<Rigidbody>.MoveNext
	|-List.Enumerator<SkinnedMeshRenderer>.MoveNext
	|-List.Enumerator<Terrain>.MoveNext
	|-List.Enumerator<Texture2D>.MoveNext
	|-List.Enumerator<Texture>.MoveNext
	|-List.Enumerator<TrailRenderer>.MoveNext
	|-List.Enumerator<Transform>.MoveNext
	|-List.Enumerator<MaskableGraphic>.MoveNext
	|-List.Enumerator<EventCallbackFunctorBase>.MoveNext
	|-List.Enumerator<IEventDispatchingStrategy>.MoveNext
	|-List.Enumerator<Panel>.MoveNext
	|-List.Enumerator<VisualElement>.MoveNext
	|-List.Enumerator<Vector2[]>.MoveNext
	|-List.Enumerator<ViewShake.ShakeParameters>.MoveNext
	|-List.Enumerator<VirtualItemIcon>.MoveNext
	|-List.Enumerator<VoiceProcessor>.MoveNext
	|-List.Enumerator<VoicemailEntry>.MoveNext
	|-List.Enumerator<WaterRuntime>.MoveNext
	|-List.Enumerator<WearableHairCap>.MoveNext
	|-List.Enumerator<WeightedAudioClip>.MoveNext
	|
	|-RVA: 0x11C700 Offset: 0x11BB00 VA: 0x18011C700
	|-List.Enumerator<AIState>.MoveNext
	|-List.Enumerator<ItemSlot>.MoveNext
	|-List.Enumerator<InventoryDefId>.MoveNext
	|-List.Enumerator<int>.MoveNext
	|-List.Enumerator<Int32Enum>.MoveNext
	|-List.Enumerator<float>.MoveNext
	|-List.Enumerator<uint>.MoveNext
	|-List.Enumerator<Color32>.MoveNext
	|-List.Enumerator<KeyCode>.MoveNext
	|
	|-RVA: 0x11D4C0 Offset: 0x11C8C0 VA: 0x18011D4C0
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.MoveNext
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.MoveNext
	|-List.Enumerator<ERChildsSO>.MoveNext
	|-List.Enumerator<TickRenderer.Tick>.MoveNext
	|
	|-RVA: 0x11C8A0 Offset: 0x11BCA0 VA: 0x18011C8A0
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.MoveNext
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.MoveNext
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.MoveNext
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.MoveNext
	|-List.Enumerator<CombineClass>.MoveNext
	|-List.Enumerator<EntityRef<LootContainer>>.MoveNext
	|-List.Enumerator<EntityRef<object>>.MoveNext
	|-List.Enumerator<TabbedPanel.Tab>.MoveNext
	|-List.Enumerator<RCon.BannedAddresses>.MoveNext
	|-List.Enumerator<GameStat.Stat>.MoveNext
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.MoveNext
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.MoveNext
	|-List.Enumerator<PlayerItemRecipe>.MoveNext
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.MoveNext
	|-List.Enumerator<MatchMakingKeyValuePair>.MoveNext
	|-List.Enumerator<Dispatch.Callback>.MoveNext
	|-List.Enumerator<DictionaryEntry>.MoveNext
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNext
	|-List.Enumerator<ValueTuple<object, object>>.MoveNext
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.MoveNext
	|-List.Enumerator<RangePositionInfo>.MoveNext
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNext
	|-List.Enumerator<FocusController.FocusedElement>.MoveNext
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.MoveNext
	|
	|-RVA: 0x148150 Offset: 0x147550 VA: 0x180148150
	|-List.Enumerator<BaseEntity.ServerFileRequest>.MoveNext
	|
	|-RVA: 0x11D2F0 Offset: 0x11C6F0 VA: 0x18011D2F0
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.MoveNext
	|-List.Enumerator<ItemSkinDirectory.Skin>.MoveNext
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.MoveNext
	|-List.Enumerator<MidiConvar.KnobBinding>.MoveNext
	|-List.Enumerator<MidiConvar.NoteBinding>.MoveNext
	|-List.Enumerator<Option>.MoveNext
	|
	|-RVA: 0x11C420 Offset: 0x11B820 VA: 0x18011C420
	|-List.Enumerator<Cassette.LoadRequest>.MoveNext
	|-List.Enumerator<Admin.ServerConvarInfo>.MoveNext
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.MoveNext
	|-List.Enumerator<MapView.MapMarkerCluster>.MoveNext
	|-List.Enumerator<MapView.SleepingBagCluster>.MoveNext
	|-List.Enumerator<TimelineEvent>.MoveNext
	|-List.Enumerator<InventoryRecipe>.MoveNext
	|-List.Enumerator<KeyValuePair<object, Color>>.MoveNext
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x11D990 Offset: 0x11CD90 VA: 0x18011D990
	|-List.Enumerator<Admin.PlayerInfo>.MoveNext
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.MoveNext
	|
	|-RVA: 0x148670 Offset: 0x147A70 VA: 0x180148670
	|-List.Enumerator<Admin.ServerUGCInfo>.MoveNext
	|
	|-RVA: 0x11C960 Offset: 0x11BD60 VA: 0x18011C960
	|-List.Enumerator<Chat.MuteEntry>.MoveNext
	|-List.Enumerator<JsonPosition>.MoveNext
	|-List.Enumerator<InventoryRecipe.Ingredient>.MoveNext
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNext
	|
	|-RVA: 0x11C340 Offset: 0x11B740 VA: 0x18011C340
	|-List.Enumerator<Demos.DemoInfo>.MoveNext
	|-List.Enumerator<Output.Entry>.MoveNext
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.MoveNext
	|-List.Enumerator<InvokeAction>.MoveNext
	|-List.Enumerator<WaypointSet.Waypoint>.MoveNext
	|-List.Enumerator<SkinnedMultiMesh.Part>.MoveNext
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNext
	|
	|-RVA: 0x11BF00 Offset: 0x11B300 VA: 0x18011BF00
	|-List.Enumerator<CRedge>.MoveNext
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.MoveNext
	|-List.Enumerator<VectorData>.MoveNext
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.MoveNext
	|-List.Enumerator<Resolution>.MoveNext
	|-List.Enumerator<UICharInfo>.MoveNext
	|-List.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x11CA40 Offset: 0x11BE40 VA: 0x18011CA40
	|-List.Enumerator<ERCell>.MoveNext
	|-List.Enumerator<ERConnectionGUIStatus>.MoveNext
	|-List.Enumerator<ERTerrainChange>.MoveNext
	|-List.Enumerator<NormalPairs>.MoveNext
	|-List.Enumerator<PathFinder.Point>.MoveNext
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.MoveNext
	|-List.Enumerator<Friend>.MoveNext
	|-List.Enumerator<DateTime>.MoveNext
	|-List.Enumerator<EventProvider.SessionInfo>.MoveNext
	|-List.Enumerator<double>.MoveNext
	|-List.Enumerator<long>.MoveNext
	|-List.Enumerator<TimeSpan>.MoveNext
	|-List.Enumerator<ulong>.MoveNext
	|-List.Enumerator<Vector2i>.MoveNext
	|
	|-RVA: 0x11BFD0 Offset: 0x11B3D0 VA: 0x18011BFD0
	|-List.Enumerator<ERLane>.MoveNext
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.MoveNext
	|-List.Enumerator<DemoShotVectorKeyframe>.MoveNext
	|-List.Enumerator<DateTimeOffset>.MoveNext
	|-List.Enumerator<Decimal>.MoveNext
	|-List.Enumerator<Guid>.MoveNext
	|-List.Enumerator<TickInterpolator.Segment>.MoveNext
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNext
	|-List.Enumerator<Color>.MoveNext
	|-List.Enumerator<Rect>.MoveNext
	|-List.Enumerator<GlyphRect>.MoveNext
	|-List.Enumerator<UILineInfo>.MoveNext
	|-List.Enumerator<Vector4>.MoveNext
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.MoveNext
	|
	|-RVA: 0x147E30 Offset: 0x147230 VA: 0x180147E30
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.MoveNext
	|-List.Enumerator<Option>.MoveNext
	|
	|-RVA: 0x1489C0 Offset: 0x147DC0 VA: 0x1801489C0
	|-List.Enumerator<ERSOSection>.MoveNext
	|
	|-RVA: 0x148570 Offset: 0x147970 VA: 0x180148570
	|-List.Enumerator<ERSplatmap>.MoveNext
	|
	|-RVA: 0x148480 Offset: 0x147880 VA: 0x180148480
	|-List.Enumerator<ERVSData>.MoveNext
	|
	|-RVA: 0x11DD50 Offset: 0x11D150 VA: 0x18011DD50
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.MoveNext
	|-List.Enumerator<DemoShotFloatKeyframe>.MoveNext
	|-List.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x11C150 Offset: 0x11B550 VA: 0x18011C150
	|-List.Enumerator<BurstCloth.Chain>.MoveNext
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.MoveNext
	|-List.Enumerator<Achievement>.MoveNext
	|
	|-RVA: 0x11DB50 Offset: 0x11CF50 VA: 0x18011DB50
	|-List.Enumerator<CapsuleParams>.MoveNext
	|-List.Enumerator<SteamNewsSource.Story>.MoveNext
	|-List.Enumerator<ViewModelDrawEvent>.MoveNext
	|
	|-RVA: 0x148050 Offset: 0x147450 VA: 0x180148050
	|-List.Enumerator<BoneData>.MoveNext
	|
	|-RVA: 0x148390 Offset: 0x147790 VA: 0x180148390
	|-List.Enumerator<SkeletonDefinition.Bone>.MoveNext
	|
	|-RVA: 0x11C7B0 Offset: 0x11BBB0 VA: 0x18011C7B0
	|-List.Enumerator<Tick.Entry>.MoveNext
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.MoveNext
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.MoveNext
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.MoveNext
	|
	|-RVA: 0x147F40 Offset: 0x147340 VA: 0x180147F40
	|-List.Enumerator<RenderInfo.RendererInstance>.MoveNext
	|
	|-RVA: 0x11CF50 Offset: 0x11C350 VA: 0x18011CF50
	|-List.Enumerator<WeightedStringList.Container>.MoveNext
	|-List.Enumerator<DemoShotParentKeyframe>.MoveNext
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.MoveNext
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|-List.Enumerator<KeyValuePair<uint, object>>.MoveNext
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x1488C0 Offset: 0x147CC0 VA: 0x1801488C0
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.MoveNext
	|
	|-RVA: 0x148B00 Offset: 0x147F00 VA: 0x180148B00
	|-List.Enumerator<Gibbable.OverrideMesh>.MoveNext
	|
	|-RVA: 0x11D590 Offset: 0x11C990 VA: 0x18011D590
	|-List.Enumerator<LocalClock.TimedEvent>.MoveNext
	|-List.Enumerator<SynchronizedClock.TimedEvent>.MoveNext
	|
	|-RVA: 0x11CCC0 Offset: 0x11C0C0 VA: 0x18011CCC0
	|-List.Enumerator<SevenBitNumber>.MoveNext
	|-List.Enumerator<bool>.MoveNext
	|-List.Enumerator<byte>.MoveNext
	|-List.Enumerator<sbyte>.MoveNext
	|
	|-RVA: 0x11C500 Offset: 0x11B900 VA: 0x18011C500
	|-List.Enumerator<MeshColliderInstance>.MoveNext
	|
	|-RVA: 0x11C210 Offset: 0x11B610 VA: 0x18011C210
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.MoveNext
	|
	|-RVA: 0x11D3D0 Offset: 0x11C7D0 VA: 0x18011D3D0
	|-List.Enumerator<MeshInstance>.MoveNext
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.MoveNext
	|
	|-RVA: 0x11D870 Offset: 0x11CC70 VA: 0x18011D870
	|-List.Enumerator<MeshRendererInstance>.MoveNext
	|
	|-RVA: 0x11CBC0 Offset: 0x11BFC0 VA: 0x18011CBC0
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.MoveNext
	|
	|-RVA: 0x11CE60 Offset: 0x11C260 VA: 0x18011CE60
	|-List.Enumerator<PetCommandList.PetCommandDesc>.MoveNext
	|
	|-RVA: 0x11DA80 Offset: 0x11CE80 VA: 0x18011DA80
	|-List.Enumerator<DemoShotQuaternionKeyframe>.MoveNext
	|
	|-RVA: 0x11CD80 Offset: 0x11C180 VA: 0x18011CD80
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.MoveNext
	|-List.Enumerator<RenderTargetIdentifier>.MoveNext
	|-List.Enumerator<TreeInstance>.MoveNext
	|
	|-RVA: 0x11C620 Offset: 0x11BA20 VA: 0x18011C620
	|-List.Enumerator<TransformSnapshot>.MoveNext
	|-List.Enumerator<SubmarineSonar.SonarBlip>.MoveNext
	|-List.Enumerator<SpawnIndividual>.MoveNext
	|
	|-RVA: 0x11D020 Offset: 0x11C420 VA: 0x18011D020
	|-List.Enumerator<ServerInfo>.MoveNext
	|
	|-RVA: 0x11D770 Offset: 0x11CB70 VA: 0x18011D770
	|-List.Enumerator<ServerInfo>.MoveNext
	|
	|-RVA: 0x11D200 Offset: 0x11C600 VA: 0x18011D200
	|-List.Enumerator<InventoryItem.Amount>.MoveNext
	|
	|-RVA: 0x11D120 Offset: 0x11C520 VA: 0x18011D120
	|-List.Enumerator<InventoryItem>.MoveNext
	|
	|-RVA: 0x11C090 Offset: 0x11B490 VA: 0x18011C090
	|-List.Enumerator<char>.MoveNext
	|-List.Enumerator<short>.MoveNext
	|-List.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x11D670 Offset: 0x11CA70 VA: 0x18011D670
	|-List.Enumerator<TraceInfo>.MoveNext
	|
	|-RVA: 0x11DC40 Offset: 0x11D040 VA: 0x18011DC40
	|-List.Enumerator<NavMeshBuildSource>.MoveNext
	|
	|-RVA: 0x21C1D0 Offset: 0x21B5D0 VA: 0x18021C1D0
	|-List.Enumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x21C2E0 Offset: 0x21B6E0 VA: 0x18021C2E0
	|-List.Enumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x21C0E0 Offset: 0x21B4E0 VA: 0x18021C0E0
	|-List.Enumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x21C3C0 Offset: 0x21B7C0 VA: 0x18021C3C0
	|-List.Enumerator<UIVertex>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA20 Offset: 0x11AE20 VA: 0x18011BA20
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.MoveNextRare
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.MoveNextRare
	|-List.Enumerator<Cassette.LoadRequest>.MoveNextRare
	|-List.Enumerator<Admin.ServerConvarInfo>.MoveNextRare
	|-List.Enumerator<Chat.MuteEntry>.MoveNextRare
	|-List.Enumerator<ERChildsSO>.MoveNextRare
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.MoveNextRare
	|-List.Enumerator<LocalClock.TimedEvent>.MoveNextRare
	|-List.Enumerator<MapView.MapMarkerCluster>.MoveNextRare
	|-List.Enumerator<MapView.SleepingBagCluster>.MoveNextRare
	|-List.Enumerator<JsonPosition>.MoveNextRare
	|-List.Enumerator<TimelineEvent>.MoveNextRare
	|-List.Enumerator<TickRenderer.Tick>.MoveNextRare
	|-List.Enumerator<InventoryRecipe.Ingredient>.MoveNextRare
	|-List.Enumerator<InventoryRecipe>.MoveNextRare
	|-List.Enumerator<SynchronizedClock.TimedEvent>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, Color>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.MoveNextRare
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.MoveNextRare
	|
	|-RVA: 0x11BA70 Offset: 0x11AE70 VA: 0x18011BA70
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.MoveNextRare
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.MoveNextRare
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.MoveNextRare
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.MoveNextRare
	|-List.Enumerator<CombineClass>.MoveNextRare
	|-List.Enumerator<ERLane>.MoveNextRare
	|-List.Enumerator<EntityRef<object>>.MoveNextRare
	|-List.Enumerator<TabbedPanel.Tab>.MoveNextRare
	|-List.Enumerator<RCon.BannedAddresses>.MoveNextRare
	|-List.Enumerator<WeightedStringList.Container>.MoveNextRare
	|-List.Enumerator<GameStat.Stat>.MoveNextRare
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.MoveNextRare
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.MoveNextRare
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.MoveNextRare
	|-List.Enumerator<PlayerItemRecipe>.MoveNextRare
	|-List.Enumerator<DemoShotParentKeyframe>.MoveNextRare
	|-List.Enumerator<DemoShotVectorKeyframe>.MoveNextRare
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.MoveNextRare
	|-List.Enumerator<MatchMakingKeyValuePair>.MoveNextRare
	|-List.Enumerator<Dispatch.Callback>.MoveNextRare
	|-List.Enumerator<DictionaryEntry>.MoveNextRare
	|-List.Enumerator<KeyValuePair<DateTime, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<int, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, object>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<object, float>>.MoveNextRare
	|-List.Enumerator<KeyValuePair<uint, object>>.MoveNextRare
	|-List.Enumerator<DateTimeOffset>.MoveNextRare
	|-List.Enumerator<Decimal>.MoveNextRare
	|-List.Enumerator<Guid>.MoveNextRare
	|-List.Enumerator<ValueTuple<object, object>>.MoveNextRare
	|-List.Enumerator<RangePositionInfo>.MoveNextRare
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNextRare
	|-List.Enumerator<TickInterpolator.Segment>.MoveNextRare
	|-List.Enumerator<NavMeshBuildMarkup>.MoveNextRare
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.MoveNextRare
	|-List.Enumerator<Color>.MoveNextRare
	|-List.Enumerator<Rect>.MoveNextRare
	|-List.Enumerator<GlyphRect>.MoveNextRare
	|-List.Enumerator<FocusController.FocusedElement>.MoveNextRare
	|-List.Enumerator<UILineInfo>.MoveNextRare
	|-List.Enumerator<Vector4>.MoveNextRare
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.MoveNextRare
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.MoveNextRare
	|
	|-RVA: 0x11B930 Offset: 0x11AD30 VA: 0x18011B930
	|-List.Enumerator<BaseEntity.ServerFileRequest>.MoveNextRare
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.MoveNextRare
	|-List.Enumerator<Demos.DemoInfo>.MoveNextRare
	|-List.Enumerator<Output.Entry>.MoveNextRare
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.MoveNextRare
	|-List.Enumerator<InvokeAction>.MoveNextRare
	|-List.Enumerator<ItemSkinDirectory.Skin>.MoveNextRare
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.MoveNextRare
	|-List.Enumerator<MidiConvar.KnobBinding>.MoveNextRare
	|-List.Enumerator<MidiConvar.NoteBinding>.MoveNextRare
	|-List.Enumerator<WaypointSet.Waypoint>.MoveNextRare
	|-List.Enumerator<TransformSnapshot>.MoveNextRare
	|-List.Enumerator<Option>.MoveNextRare
	|-List.Enumerator<SkinnedMultiMesh.Part>.MoveNextRare
	|-List.Enumerator<SubmarineSonar.SonarBlip>.MoveNextRare
	|-List.Enumerator<SpawnIndividual>.MoveNextRare
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.MoveNextRare
	|-List.Enumerator<InventoryItem>.MoveNextRare
	|
	|-RVA: 0x11BE30 Offset: 0x11B230 VA: 0x18011BE30
	|-List.Enumerator<Admin.PlayerInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.MoveNextRare
	|
	|-RVA: 0x11BAC0 Offset: 0x11AEC0 VA: 0x18011BAC0
	|-List.Enumerator<Admin.ServerUGCInfo>.MoveNextRare
	|-List.Enumerator<CapsuleParams>.MoveNextRare
	|-List.Enumerator<SkeletonDefinition.Bone>.MoveNextRare
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.MoveNextRare
	|-List.Enumerator<SteamNewsSource.Story>.MoveNextRare
	|-List.Enumerator<InventoryItem.Amount>.MoveNextRare
	|-List.Enumerator<RenderTargetIdentifier>.MoveNextRare
	|-List.Enumerator<TreeInstance>.MoveNextRare
	|-List.Enumerator<ViewModelDrawEvent>.MoveNextRare
	|
	|-RVA: 0x11BBE0 Offset: 0x11AFE0 VA: 0x18011BBE0
	|-List.Enumerator<CRedge>.MoveNextRare
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.MoveNextRare
	|-List.Enumerator<VectorData>.MoveNextRare
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.MoveNextRare
	|-List.Enumerator<Resolution>.MoveNextRare
	|-List.Enumerator<UICharInfo>.MoveNextRare
	|-List.Enumerator<Vector3>.MoveNextRare
	|
	|-RVA: 0x11B9D0 Offset: 0x11ADD0 VA: 0x18011B9D0
	|-List.Enumerator<ERCell>.MoveNextRare
	|-List.Enumerator<ERConnectionGUIStatus>.MoveNextRare
	|-List.Enumerator<ERTerrainChange>.MoveNextRare
	|-List.Enumerator<NormalPairs>.MoveNextRare
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.MoveNextRare
	|-List.Enumerator<BurstCloth.Chain>.MoveNextRare
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.MoveNextRare
	|-List.Enumerator<PathFinder.Point>.MoveNextRare
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.MoveNextRare
	|-List.Enumerator<DemoShotFloatKeyframe>.MoveNextRare
	|-List.Enumerator<Achievement>.MoveNextRare
	|-List.Enumerator<Friend>.MoveNextRare
	|-List.Enumerator<DateTime>.MoveNextRare
	|-List.Enumerator<EventProvider.SessionInfo>.MoveNextRare
	|-List.Enumerator<double>.MoveNextRare
	|-List.Enumerator<long>.MoveNextRare
	|-List.Enumerator<object>.MoveNextRare
	|-List.Enumerator<TimeSpan>.MoveNextRare
	|-List.Enumerator<ulong>.MoveNextRare
	|-List.Enumerator<Vector2>.MoveNextRare
	|-List.Enumerator<Vector2i>.MoveNextRare
	|
	|-RVA: 0x147AE0 Offset: 0x146EE0 VA: 0x180147AE0
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.MoveNextRare
	|-List.Enumerator<RenderInfo.RendererInstance>.MoveNextRare
	|-List.Enumerator<Option>.MoveNextRare
	|
	|-RVA: 0x147C70 Offset: 0x147070 VA: 0x180147C70
	|-List.Enumerator<ERSOSection>.MoveNextRare
	|
	|-RVA: 0x147B40 Offset: 0x146F40 VA: 0x180147B40
	|-List.Enumerator<ERSplatmap>.MoveNextRare
	|
	|-RVA: 0x11BD60 Offset: 0x11B160 VA: 0x18011BD60
	|-List.Enumerator<ERVSData>.MoveNextRare
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.MoveNextRare
	|
	|-RVA: 0x147C00 Offset: 0x147000 VA: 0x180147C00
	|-List.Enumerator<BoneData>.MoveNextRare
	|
	|-RVA: 0x11BB20 Offset: 0x11AF20 VA: 0x18011BB20
	|-List.Enumerator<Tick.Entry>.MoveNextRare
	|-List.Enumerator<Gibbable.OverrideMesh>.MoveNextRare
	|-List.Enumerator<MeshInstance>.MoveNextRare
	|-List.Enumerator<PetCommandList.PetCommandDesc>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.MoveNextRare
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.MoveNextRare
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.MoveNextRare
	|
	|-RVA: 0x147BA0 Offset: 0x146FA0 VA: 0x180147BA0
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.MoveNextRare
	|
	|-RVA: 0x11B8E0 Offset: 0x11ACE0 VA: 0x18011B8E0
	|-List.Enumerator<SevenBitNumber>.MoveNextRare
	|-List.Enumerator<bool>.MoveNextRare
	|-List.Enumerator<byte>.MoveNextRare
	|-List.Enumerator<sbyte>.MoveNextRare
	|
	|-RVA: 0x11BD50 Offset: 0x11B150 VA: 0x18011BD50
	|-List.Enumerator<MeshColliderInstance>.MoveNextRare
	|
	|-RVA: 0x11BE90 Offset: 0x11B290 VA: 0x18011BE90
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.MoveNextRare
	|
	|-RVA: 0x11BCF0 Offset: 0x11B0F0 VA: 0x18011BCF0
	|-List.Enumerator<MeshRendererInstance>.MoveNextRare
	|
	|-RVA: 0x11BD00 Offset: 0x11B100 VA: 0x18011BD00
	|-List.Enumerator<DemoShotQuaternionKeyframe>.MoveNextRare
	|
	|-RVA: 0x11BC80 Offset: 0x11B080 VA: 0x18011BC80
	|-List.Enumerator<ServerInfo>.MoveNextRare
	|-List.Enumerator<ServerInfo>.MoveNextRare
	|
	|-RVA: 0x11B980 Offset: 0x11AD80 VA: 0x18011B980
	|-List.Enumerator<InventoryDefId>.MoveNextRare
	|-List.Enumerator<int>.MoveNextRare
	|-List.Enumerator<Int32Enum>.MoveNextRare
	|-List.Enumerator<float>.MoveNextRare
	|-List.Enumerator<uint>.MoveNextRare
	|-List.Enumerator<Color32>.MoveNextRare
	|
	|-RVA: 0x11BC30 Offset: 0x11B030 VA: 0x18011BC30
	|-List.Enumerator<char>.MoveNextRare
	|-List.Enumerator<short>.MoveNextRare
	|-List.Enumerator<ushort>.MoveNextRare
	|
	|-RVA: 0x11BB80 Offset: 0x11AF80 VA: 0x18011BB80
	|-List.Enumerator<TraceInfo>.MoveNextRare
	|-List.Enumerator<RaycastResult>.MoveNextRare
	|
	|-RVA: 0x11BDC0 Offset: 0x11B1C0 VA: 0x18011BDC0
	|-List.Enumerator<NavMeshBuildSource>.MoveNextRare
	|
	|-RVA: 0x21C080 Offset: 0x21B480 VA: 0x18021C080
	|-List.Enumerator<RaycastHit2D>.MoveNextRare
	|
	|-RVA: 0x21C020 Offset: 0x21B420 VA: 0x18021C020
	|-List.Enumerator<RaycastHit>.MoveNextRare
	|
	|-RVA: 0x21BFC0 Offset: 0x21B3C0 VA: 0x18021BFC0
	|-List.Enumerator<UIVertex>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	|-List.Enumerator<AIMovePoint>.get_Current
	|-List.Enumerator<BaseAIEvent>.get_Current
	|-List.Enumerator<BaseBulb>.get_Current
	|-List.Enumerator<BaseCollision>.get_Current
	|-List.Enumerator<BaseEntity>.get_Current
	|-List.Enumerator<BaseMeshPaintable>.get_Current
	|-List.Enumerator<BaseMission.MissionInstance>.get_Current
	|-List.Enumerator<BaseNetworkable>.get_Current
	|-List.Enumerator<BaseNpc>.get_Current
	|-List.Enumerator<BasePathNode>.get_Current
	|-List.Enumerator<BasePlayer>.get_Current
	|-List.Enumerator<BaseVehicle.MountPointInfo>.get_Current
	|-List.Enumerator<BaseVehicle>.get_Current
	|-List.Enumerator<BaseVehicleModule>.get_Current
	|-List.Enumerator<BaseViewModel>.get_Current
	|-List.Enumerator<BlendedSoundLoops.Loop>.get_Current
	|-List.Enumerator<BoneRetarget>.get_Current
	|-List.Enumerator<BuildingBlock>.get_Current
	|-List.Enumerator<CH47DropZone>.get_Current
	|-List.Enumerator<CH47LandingZone>.get_Current
	|-List.Enumerator<CinematicEntity>.get_Current
	|-List.Enumerator<ClientIOLine>.get_Current
	|-List.Enumerator<CoalingTower>.get_Current
	|-List.Enumerator<ComponentInfo>.get_Current
	|-List.Enumerator<ConnectedSpeaker>.get_Current
	|-List.Enumerator<ConvarComponent.ConvarEvent>.get_Current
	|-List.Enumerator<CoverageQueries.Query>.get_Current
	|-List.Enumerator<DecalRecycle>.get_Current
	|-List.Enumerator<DecorSpawn>.get_Current
	|-List.Enumerator<DeferredMeshDecal.InstanceData>.get_Current
	|-List.Enumerator<DemoShotEntry>.get_Current
	|-List.Enumerator<DemoShotListFolderWidget>.get_Current
	|-List.Enumerator<DroppedItem>.get_Current
	|-List.Enumerator<DungeonBaseInfo>.get_Current
	|-List.Enumerator<DungeonBaseLink>.get_Current
	|-List.Enumerator<DungeonBaseSocket>.get_Current
	|-List.Enumerator<DungeonGridCell>.get_Current
	|-List.Enumerator<DungeonGridInfo>.get_Current
	|-List.Enumerator<DungeonVolume>.get_Current
	|-List.Enumerator<ERDecal>.get_Current
	|-List.Enumerator<ERLaneConnector>.get_Current
	|-List.Enumerator<ERLocalGrid>.get_Current
	|-List.Enumerator<ERMarkerExt>.get_Current
	|-List.Enumerator<ERMesh>.get_Current
	|-List.Enumerator<ERModularRoad>.get_Current
	|-List.Enumerator<ERSOMarkerExt>.get_Current
	|-List.Enumerator<ERSORoadExt>.get_Current
	|-List.Enumerator<ERSideWalk>.get_Current
	|-List.Enumerator<ERTerrainData>.get_Current
	|-List.Enumerator<ERTreeInstance>.get_Current
	|-List.Enumerator<OQQCCQCDQQ>.get_Current
	|-List.Enumerator<QDOODOQQDQODD>.get_Current
	|-List.Enumerator<QDQDOOQQDQODD>.get_Current
	|-List.Enumerator<SideObject>.get_Current
	|-List.Enumerator<tPoint>.get_Current
	|-List.Enumerator<BurstCloth.Chain>.get_Current
	|-List.Enumerator<BurstCloth>.get_Current
	|-List.Enumerator<Input.Button>.get_Current
	|-List.Enumerator<RCon.RConClient>.get_Current
	|-List.Enumerator<SkeletonSkin>.get_Current
	|-List.Enumerator<FavouriteRadioStation>.get_Current
	|-List.Enumerator<FruitScale>.get_Current
	|-List.Enumerator<ICommandCenterListener>.get_Current
	|-List.Enumerator<JSONNode>.get_Current
	|-List.Enumerator<GenerateDungeonBase.DungeonSegment>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathLink>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathLinkSegment>.get_Current
	|-List.Enumerator<GenerateDungeonGrid.PathSegment>.get_Current
	|-List.Enumerator<GeneratePowerlineLayout.PathSegment>.get_Current
	|-List.Enumerator<GenerateRailRing.RingNode>.get_Current
	|-List.Enumerator<GenerateRoadLayout.PathNode>.get_Current
	|-List.Enumerator<GenerateRoadLayout.PathSegment>.get_Current
	|-List.Enumerator<GenerateRoadRing.RingNode>.get_Current
	|-List.Enumerator<Gib>.get_Current
	|-List.Enumerator<GlassPane>.get_Current
	|-List.Enumerator<GraveyardFence>.get_Current
	|-List.Enumerator<HitboxDefinition>.get_Current
	|-List.Enumerator<HitboxSystem.HitboxShape>.get_Current
	|-List.Enumerator<IClientComponentEx>.get_Current
	|-List.Enumerator<IEffect>.get_Current
	|-List.Enumerator<IItemSetup>.get_Current
	|-List.Enumerator<IItemUpdate>.get_Current
	|-List.Enumerator<IPlayerItemDefinition>.get_Current
	|-List.Enumerator<IPrefabPostProcess>.get_Current
	|-List.Enumerator<IPrefabPreProcess>.get_Current
	|-List.Enumerator<IRagdollInhert>.get_Current
	|-List.Enumerator<IServerComponentEx>.get_Current
	|-List.Enumerator<IconSkin>.get_Current
	|-List.Enumerator<ImageEffectLayer>.get_Current
	|-List.Enumerator<InstrumentKeyController>.get_Current
	|-List.Enumerator<Item>.get_Current
	|-List.Enumerator<ItemAmount>.get_Current
	|-List.Enumerator<ItemBlueprint>.get_Current
	|-List.Enumerator<ItemContainer>.get_Current
	|-List.Enumerator<ItemDefinition>.get_Current
	|-List.Enumerator<ItemIcon>.get_Current
	|-List.Enumerator<ItemModConsumable.ConsumableEffect>.get_Current
	|-List.Enumerator<ItemPickupNotice>.get_Current
	|-List.Enumerator<Value>.get_Current
	|-List.Enumerator<KeyframeWidget>.get_Current
	|-List.Enumerator<LODComponent>.get_Current
	|-List.Enumerator<LandmarkInfo>.get_Current
	|-List.Enumerator<LifeScale>.get_Current
	|-List.Enumerator<LoadAssetsResult>.get_Current
	|-List.Enumerator<MapMarker>.get_Current
	|-List.Enumerator<MaterialReplacement>.get_Current
	|-List.Enumerator<ValueChange<TimeSignature>>.get_Current
	|-List.Enumerator<MissionMapMarker>.get_Current
	|-List.Enumerator<Modifier>.get_Current
	|-List.Enumerator<ModifierDefintion>.get_Current
	|-List.Enumerator<SqliteFunctionAttribute>.get_Current
	|-List.Enumerator<SqliteParameter>.get_Current
	|-List.Enumerator<MonumentInfo>.get_Current
	|-List.Enumerator<MonumentMarker>.get_Current
	|-List.Enumerator<MorphCache>.get_Current
	|-List.Enumerator<Connection>.get_Current
	|-List.Enumerator<IXmlNode>.get_Current
	|-List.Enumerator<JsonSerializerInternalReader.CreatorPropertyContext>.get_Current
	|-List.Enumerator<SerializationCallback>.get_Current
	|-List.Enumerator<OutlineObject>.get_Current
	|-List.Enumerator<PaintableItem>.get_Current
	|-List.Enumerator<PathFinder.Node>.get_Current
	|-List.Enumerator<PathFinder.Point>.get_Current
	|-List.Enumerator<PathList.MeshObject>.get_Current
	|-List.Enumerator<PathList>.get_Current
	|-List.Enumerator<PatternFireworkStar>.get_Current
	|-List.Enumerator<PlayerModel>.get_Current
	|-List.Enumerator<PlayerModelSkin>.get_Current
	|-List.Enumerator<PowerlineNode>.get_Current
	|-List.Enumerator<Projectile>.get_Current
	|-List.Enumerator<AIEventData>.get_Current
	|-List.Enumerator<AIStateContainer>.get_Current
	|-List.Enumerator<ArcadeGame.arcadeEnt>.get_Current
	|-List.Enumerator<CardTable.WinnerBreakdown.Winner>.get_Current
	|-List.Enumerator<DemoShot>.get_Current
	|-List.Enumerator<EggHunt.EggHunter>.get_Current
	|-List.Enumerator<FileStorageCacheData>.get_Current
	|-List.Enumerator<GameMode.PlayerScore>.get_Current
	|-List.Enumerator<GameMode.ScoreColumn>.get_Current
	|-List.Enumerator<GameMode.TeamInfo>.get_Current
	|-List.Enumerator<InstrumentMidiBinding>.get_Current
	|-List.Enumerator<InstrumentRecordingNote>.get_Current
	|-List.Enumerator<Item>.get_Current
	|-List.Enumerator<ItemContainer>.get_Current
	|-List.Enumerator<LightString.StringPoint>.get_Current
	|-List.Enumerator<LinePoint>.get_Current
	|-List.Enumerator<MapNote>.get_Current
	|-List.Enumerator<MarketTerminal.PendingOrder>.get_Current
	|-List.Enumerator<MissionInstance>.get_Current
	|-List.Enumerator<Modifier>.get_Current
	|-List.Enumerator<NeonSign.Lights>.get_Current
	|-List.Enumerator<PatternFirework.Star>.get_Current
	|-List.Enumerator<PhoneDirectory.DirectoryEntry>.get_Current
	|-List.Enumerator<PlayerLifeStory.GenericStat>.get_Current
	|-List.Enumerator<PlayerLifeStory.WeaponStats>.get_Current
	|-List.Enumerator<PlayerTeam.TeamMember>.get_Current
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.get_Current
	|-List.Enumerator<RespawnInformation.SpawnOptions>.get_Current
	|-List.Enumerator<Tree>.get_Current
	|-List.Enumerator<VendingMachine.SellOrder>.get_Current
	|-List.Enumerator<VoicemailEntry>.get_Current
	|-List.Enumerator<RainSurfaceAmbience.SurfaceSound>.get_Current
	|-List.Enumerator<Recipe>.get_Current
	|-List.Enumerator<RelationshipManager.PlayerRelationshipInfo>.get_Current
	|-List.Enumerator<DamageTypeEntry>.get_Current
	|-List.Enumerator<ConditionalObject>.get_Current
	|-List.Enumerator<RustButton>.get_Current
	|-List.Enumerator<ServerAdminPlayerEntry>.get_Current
	|-List.Enumerator<ServerAdminUGCEntry>.get_Current
	|-List.Enumerator<ServerAdminUGCEntryPattern>.get_Current
	|-List.Enumerator<TimelineMarker>.get_Current
	|-List.Enumerator<SellOrderEntry>.get_Current
	|-List.Enumerator<ShoutcastStream>.get_Current
	|-List.Enumerator<ShoutcastStreamer>.get_Current
	|-List.Enumerator<SleepingBag>.get_Current
	|-List.Enumerator<SleepingBagClusterMapMarker>.get_Current
	|-List.Enumerator<SleepingBagMapMarker>.get_Current
	|-List.Enumerator<SlotMachinePayoutWidget>.get_Current
	|-List.Enumerator<SmokeGrenade>.get_Current
	|-List.Enumerator<Socket_Base>.get_Current
	|-List.Enumerator<Sound>.get_Current
	|-List.Enumerator<SoundDefinition.DistanceAudioClipList>.get_Current
	|-List.Enumerator<SteamClass>.get_Current
	|-List.Enumerator<Action>.get_Current
	|-List.Enumerator<Action<IntPtr>>.get_Current
	|-List.Enumerator<List<int>>.get_Current
	|-List.Enumerator<DataColumn>.get_Current
	|-List.Enumerator<DataRelation>.get_Current
	|-List.Enumerator<DataRow>.get_Current
	|-List.Enumerator<DataTable>.get_Current
	|-List.Enumerator<Index>.get_Current
	|-List.Enumerator<NameValueHeaderValue>.get_Current
	|-List.Enumerator<RangeItemHeaderValue>.get_Current
	|-List.Enumerator<IPAddress>.get_Current
	|-List.Enumerator<MonoChunkStream.Chunk>.get_Current
	|-List.Enumerator<WebConnection>.get_Current
	|-List.Enumerator<WebConnectionGroup>.get_Current
	|-List.Enumerator<FieldInfo>.get_Current
	|-List.Enumerator<MemberInfo>.get_Current
	|-List.Enumerator<X509CertificateImpl>.get_Current
	|-List.Enumerator<Thread>.get_Current
	|-List.Enumerator<IEnlistmentNotification>.get_Current
	|-List.Enumerator<Type>.get_Current
	|-List.Enumerator<XmlReflectionMember>.get_Current
	|-List.Enumerator<XmlQualifiedName>.get_Current
	|-List.Enumerator<TechTreeData.NodeInstance>.get_Current
	|-List.Enumerator<TechTreeLine>.get_Current
	|-List.Enumerator<TextTable.Row>.get_Current
	|-List.Enumerator<TriggerBase>.get_Current
	|-List.Enumerator<TriggerSafeZone>.get_Current
	|-List.Enumerator<UIMapVendingMachineMarker>.get_Current
	|-List.Enumerator<Underwear>.get_Current
	|-List.Enumerator<NavMeshLink>.get_Current
	|-List.Enumerator<NavMeshModifier>.get_Current
	|-List.Enumerator<NavMeshModifierVolume>.get_Current
	|-List.Enumerator<AudioSource>.get_Current
	|-List.Enumerator<CharacterJoint>.get_Current
	|-List.Enumerator<Collider>.get_Current
	|-List.Enumerator<Component>.get_Current
	|-List.Enumerator<ConfigurableJoint>.get_Current
	|-List.Enumerator<DDraw.BaseObject>.get_Current
	|-List.Enumerator<PersistentCall>.get_Current
	|-List.Enumerator<GUILayoutEntry>.get_Current
	|-List.Enumerator<GameObject>.get_Current
	|-List.Enumerator<ISubsystem>.get_Current
	|-List.Enumerator<ISubsystemDescriptor>.get_Current
	|-List.Enumerator<ISubsystemDescriptorImpl>.get_Current
	|-List.Enumerator<Joint>.get_Current
	|-List.Enumerator<LODGroup>.get_Current
	|-List.Enumerator<Material>.get_Current
	|-List.Enumerator<MeshCollider>.get_Current
	|-List.Enumerator<MeshRenderer>.get_Current
	|-List.Enumerator<ParticleSystem>.get_Current
	|-List.Enumerator<PhysicMaterial>.get_Current
	|-List.Enumerator<RenderTexture>.get_Current
	|-List.Enumerator<Renderer>.get_Current
	|-List.Enumerator<CommandBuffer>.get_Current
	|-List.Enumerator<PostProcessBundle>.get_Current
	|-List.Enumerator<PostProcessEffectSettings>.get_Current
	|-List.Enumerator<PostProcessLayer.SerializedBundleRef>.get_Current
	|-List.Enumerator<PostProcessVolume>.get_Current
	|-List.Enumerator<Rigidbody>.get_Current
	|-List.Enumerator<SkinnedMeshRenderer>.get_Current
	|-List.Enumerator<Terrain>.get_Current
	|-List.Enumerator<Texture2D>.get_Current
	|-List.Enumerator<Texture>.get_Current
	|-List.Enumerator<TrailRenderer>.get_Current
	|-List.Enumerator<Transform>.get_Current
	|-List.Enumerator<MaskableGraphic>.get_Current
	|-List.Enumerator<EventCallbackFunctorBase>.get_Current
	|-List.Enumerator<IEventDispatchingStrategy>.get_Current
	|-List.Enumerator<Panel>.get_Current
	|-List.Enumerator<VisualElement>.get_Current
	|-List.Enumerator<Vector2[]>.get_Current
	|-List.Enumerator<Vector2i>.get_Current
	|-List.Enumerator<ViewShake.ShakeParameters>.get_Current
	|-List.Enumerator<VirtualItemIcon>.get_Current
	|-List.Enumerator<VoiceProcessor>.get_Current
	|-List.Enumerator<VoicemailEntry>.get_Current
	|-List.Enumerator<WaterRuntime>.get_Current
	|-List.Enumerator<WearableHairCap>.get_Current
	|-List.Enumerator<WeightedAudioClip>.get_Current
	|-List.Enumerator<ERCell>.get_Current
	|-List.Enumerator<ERConnectionGUIStatus>.get_Current
	|-List.Enumerator<ERTerrainChange>.get_Current
	|-List.Enumerator<NormalPairs>.get_Current
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.get_Current
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.get_Current
	|-List.Enumerator<Achievement>.get_Current
	|-List.Enumerator<Friend>.get_Current
	|-List.Enumerator<DateTime>.get_Current
	|-List.Enumerator<EtwSession>.get_Current
	|-List.Enumerator<EventProvider.SessionInfo>.get_Current
	|-List.Enumerator<FieldMetadata>.get_Current
	|-List.Enumerator<CultureInfo>.get_Current
	|-List.Enumerator<long>.get_Current
	|-List.Enumerator<ModifierSpec>.get_Current
	|-List.Enumerator<object>.get_Current
	|-List.Enumerator<MethodInfo>.get_Current
	|-List.Enumerator<ExceptionDispatchInfo>.get_Current
	|-List.Enumerator<IContextProperty>.get_Current
	|-List.Enumerator<string>.get_Current
	|-List.Enumerator<IAsyncLocal>.get_Current
	|-List.Enumerator<Task>.get_Current
	|-List.Enumerator<TimeSpan>.get_Current
	|-List.Enumerator<Tuple<EventProvider.SessionInfo, bool>>.get_Current
	|-List.Enumerator<TypeIdentifier>.get_Current
	|-List.Enumerator<ulong>.get_Current
	|-List.Enumerator<WeakReference>.get_Current
	|-List.Enumerator<WeakReference<EtwSession>>.get_Current
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-List.Enumerator<AIState>.get_Current
	|-List.Enumerator<ItemSlot>.get_Current
	|-List.Enumerator<uint>.get_Current
	|-List.Enumerator<KeyCode>.get_Current
	|-List.Enumerator<InventoryDefId>.get_Current
	|-List.Enumerator<int>.get_Current
	|-List.Enumerator<Int32Enum>.get_Current
	|-List.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x116AB0 Offset: 0x115EB0 VA: 0x180116AB0
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.get_Current
	|-List.Enumerator<Chat.MuteEntry>.get_Current
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.get_Current
	|-List.Enumerator<MapView.MapMarkerCluster>.get_Current
	|-List.Enumerator<MapView.SleepingBagCluster>.get_Current
	|-List.Enumerator<JsonPosition>.get_Current
	|-List.Enumerator<TickRenderer.Tick>.get_Current
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.get_Current
	|-List.Enumerator<Cassette.LoadRequest>.get_Current
	|-List.Enumerator<Admin.ServerConvarInfo>.get_Current
	|-List.Enumerator<ERChildsSO>.get_Current
	|-List.Enumerator<LocalClock.TimedEvent>.get_Current
	|-List.Enumerator<TimelineEvent>.get_Current
	|-List.Enumerator<InventoryRecipe.Ingredient>.get_Current
	|-List.Enumerator<InventoryRecipe>.get_Current
	|-List.Enumerator<SynchronizedClock.TimedEvent>.get_Current
	|-List.Enumerator<KeyValuePair<object, Color>>.get_Current
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.get_Current
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x116A70 Offset: 0x115E70 VA: 0x180116A70
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.get_Current
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.get_Current
	|-List.Enumerator<InvokeAction>.get_Current
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.get_Current
	|-List.Enumerator<MidiConvar.KnobBinding>.get_Current
	|-List.Enumerator<MidiConvar.NoteBinding>.get_Current
	|-List.Enumerator<TransformSnapshot>.get_Current
	|-List.Enumerator<SkinnedMultiMesh.Part>.get_Current
	|-List.Enumerator<BaseEntity.ServerFileRequest>.get_Current
	|-List.Enumerator<Demos.DemoInfo>.get_Current
	|-List.Enumerator<Output.Entry>.get_Current
	|-List.Enumerator<ItemSkinDirectory.Skin>.get_Current
	|-List.Enumerator<WaypointSet.Waypoint>.get_Current
	|-List.Enumerator<Option>.get_Current
	|-List.Enumerator<SubmarineSonar.SonarBlip>.get_Current
	|-List.Enumerator<SpawnIndividual>.get_Current
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.get_Current
	|-List.Enumerator<InventoryItem>.get_Current
	|
	|-RVA: 0x116AD0 Offset: 0x115ED0 VA: 0x180116AD0
	|-List.Enumerator<Admin.ServerUGCInfo>.get_Current
	|-List.Enumerator<CapsuleParams>.get_Current
	|-List.Enumerator<ViewModelDrawEvent>.get_Current
	|-List.Enumerator<SkeletonDefinition.Bone>.get_Current
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.get_Current
	|-List.Enumerator<SteamNewsSource.Story>.get_Current
	|-List.Enumerator<InventoryItem.Amount>.get_Current
	|-List.Enumerator<RenderTargetIdentifier>.get_Current
	|-List.Enumerator<TreeInstance>.get_Current
	|
	|-RVA: 0x10AB30 Offset: 0x109F30 VA: 0x18010AB30
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.get_Current
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.get_Current
	|-List.Enumerator<CombineClass>.get_Current
	|-List.Enumerator<ERLane>.get_Current
	|-List.Enumerator<EntityRef<LootContainer>>.get_Current
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.get_Current
	|-List.Enumerator<DemoShotVectorKeyframe>.get_Current
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.get_Current
	|-List.Enumerator<Dispatch.Callback>.get_Current
	|-List.Enumerator<KeyValuePair<HairCapMask, Renderer>>.get_Current
	|-List.Enumerator<ValueTuple<string, AssetBundleRequest>>.get_Current
	|-List.Enumerator<Rect>.get_Current
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.get_Current
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.get_Current
	|-List.Enumerator<EntityRef<object>>.get_Current
	|-List.Enumerator<TabbedPanel.Tab>.get_Current
	|-List.Enumerator<RCon.BannedAddresses>.get_Current
	|-List.Enumerator<WeightedStringList.Container>.get_Current
	|-List.Enumerator<GameStat.Stat>.get_Current
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.get_Current
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.get_Current
	|-List.Enumerator<PlayerItemRecipe>.get_Current
	|-List.Enumerator<DemoShotParentKeyframe>.get_Current
	|-List.Enumerator<MatchMakingKeyValuePair>.get_Current
	|-List.Enumerator<DictionaryEntry>.get_Current
	|-List.Enumerator<KeyValuePair<DateTime, object>>.get_Current
	|-List.Enumerator<KeyValuePair<int, object>>.get_Current
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|-List.Enumerator<KeyValuePair<object, object>>.get_Current
	|-List.Enumerator<KeyValuePair<object, float>>.get_Current
	|-List.Enumerator<KeyValuePair<uint, object>>.get_Current
	|-List.Enumerator<DateTimeOffset>.get_Current
	|-List.Enumerator<Decimal>.get_Current
	|-List.Enumerator<Guid>.get_Current
	|-List.Enumerator<ValueTuple<object, object>>.get_Current
	|-List.Enumerator<RangePositionInfo>.get_Current
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Current
	|-List.Enumerator<TickInterpolator.Segment>.get_Current
	|-List.Enumerator<NavMeshBuildMarkup>.get_Current
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|-List.Enumerator<Color>.get_Current
	|-List.Enumerator<GlyphRect>.get_Current
	|-List.Enumerator<FocusController.FocusedElement>.get_Current
	|-List.Enumerator<UILineInfo>.get_Current
	|-List.Enumerator<Vector4>.get_Current
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.get_Current
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.get_Current
	|
	|-RVA: 0x149C50 Offset: 0x149050 VA: 0x180149C50
	|-List.Enumerator<ERSplatmap>.get_Current
	|
	|-RVA: 0x149C80 Offset: 0x149080 VA: 0x180149C80
	|-List.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x149C10 Offset: 0x149010 VA: 0x180149C10
	|-List.Enumerator<Option>.get_Current
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.get_Current
	|-List.Enumerator<RenderInfo.RendererInstance>.get_Current
	|
	|-RVA: 0x11FCA0 Offset: 0x11F0A0 VA: 0x18011FCA0
	|-List.Enumerator<PetCommandList.PetCommandDesc>.get_Current
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.get_Current
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.get_Current
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.get_Current
	|-List.Enumerator<Tick.Entry>.get_Current
	|-List.Enumerator<Gibbable.OverrideMesh>.get_Current
	|-List.Enumerator<MeshInstance>.get_Current
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.get_Current
	|
	|-RVA: 0x11FC70 Offset: 0x11F070 VA: 0x18011FC70
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.get_Current
	|-List.Enumerator<Admin.PlayerInfo>.get_Current
	|
	|-RVA: 0x11FD50 Offset: 0x11F150 VA: 0x18011FD50
	|-List.Enumerator<DemoShotFloatKeyframe>.get_Current
	|-List.Enumerator<Vector2>.get_Current
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.get_Current
	|
	|-RVA: 0x11FCF0 Offset: 0x11F0F0 VA: 0x18011FCF0
	|-List.Enumerator<DemoShotQuaternionKeyframe>.get_Current
	|
	|-RVA: 0x116A90 Offset: 0x115E90 VA: 0x180116A90
	|-List.Enumerator<VectorData>.get_Current
	|-List.Enumerator<Resolution>.get_Current
	|-List.Enumerator<Vector3>.get_Current
	|-List.Enumerator<CRedge>.get_Current
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.get_Current
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.get_Current
	|-List.Enumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x11FE40 Offset: 0x11F240 VA: 0x18011FE40
	|-List.Enumerator<ServerInfo>.get_Current
	|-List.Enumerator<ServerInfo>.get_Current
	|
	|-RVA: 0x10AB50 Offset: 0x109F50 VA: 0x18010AB50
	|-List.Enumerator<bool>.get_Current
	|-List.Enumerator<SevenBitNumber>.get_Current
	|-List.Enumerator<byte>.get_Current
	|-List.Enumerator<sbyte>.get_Current
	|
	|-RVA: 0x11FD10 Offset: 0x11F110 VA: 0x18011FD10
	|-List.Enumerator<NavMeshBuildSource>.get_Current
	|
	|-RVA: 0x11FED0 Offset: 0x11F2D0 VA: 0x18011FED0
	|-List.Enumerator<RaycastResult>.get_Current
	|-List.Enumerator<TraceInfo>.get_Current
	|
	|-RVA: 0x21C9C0 Offset: 0x21BDC0 VA: 0x18021C9C0
	|-List.Enumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x149B70 Offset: 0x148F70 VA: 0x180149B70
	|-List.Enumerator<ERSOSection>.get_Current
	|
	|-RVA: 0x11FCC0 Offset: 0x11F0C0 VA: 0x18011FCC0
	|-List.Enumerator<ERVSData>.get_Current
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.get_Current
	|
	|-RVA: 0x149BE0 Offset: 0x148FE0 VA: 0x180149BE0
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.get_Current
	|
	|-RVA: 0x11FD70 Offset: 0x11F170 VA: 0x18011FD70
	|-List.Enumerator<MeshColliderInstance>.get_Current
	|
	|-RVA: 0x11FE90 Offset: 0x11F290 VA: 0x18011FE90
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.get_Current
	|
	|-RVA: 0x11FDE0 Offset: 0x11F1E0 VA: 0x18011FDE0
	|-List.Enumerator<MeshRendererInstance>.get_Current
	|
	|-RVA: 0x10AB20 Offset: 0x109F20 VA: 0x18010AB20
	|-List.Enumerator<char>.get_Current
	|-List.Enumerator<short>.get_Current
	|-List.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x10AB40 Offset: 0x109F40 VA: 0x18010AB40
	|-List.Enumerator<double>.get_Current
	|
	|-RVA: 0x116A60 Offset: 0x115E60 VA: 0x180116A60
	|-List.Enumerator<float>.get_Current
	|
	|-RVA: 0x21C9A0 Offset: 0x21BDA0 VA: 0x18021C9A0
	|-List.Enumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x21C960 Offset: 0x21BD60 VA: 0x18021C960
	|-List.Enumerator<UIVertex>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E700 Offset: 0x11DB00 VA: 0x18011E700
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Cassette.LoadRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Admin.ServerConvarInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Chat.MuteEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERChildsSO>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<LocalClock.TimedEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MapView.MapMarkerCluster>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MapView.SleepingBagCluster>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TimelineEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TickRenderer.Tick>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryRecipe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SynchronizedClock.TimedEvent>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E650 Offset: 0x11DA50 VA: 0x18011E650
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CombineClass>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERLane>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<EntityRef<object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TabbedPanel.Tab>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RCon.BannedAddresses>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WeightedStringList.Container>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<GameStat.Stat>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlayerItemRecipe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotParentKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotVectorKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MatchMakingKeyValuePair>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Dispatch.Callback>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Guid>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TickInterpolator.Segment>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E420 Offset: 0x11D820 VA: 0x18011E420
	|-List.Enumerator<BaseEntity.ServerFileRequest>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Demos.DemoInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Output.Entry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InvokeAction>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MidiConvar.KnobBinding>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MidiConvar.NoteBinding>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<WaypointSet.Waypoint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TransformSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Option>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SubmarineSonar.SonarBlip>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SpawnIndividual>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EC60 Offset: 0x11E060 VA: 0x18011EC60
	|-List.Enumerator<Admin.PlayerInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EB90 Offset: 0x11DF90 VA: 0x18011EB90
	|-List.Enumerator<Admin.ServerUGCInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<CapsuleParams>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SteamNewsSource.Story>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<InventoryItem.Amount>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TreeInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E4E0 Offset: 0x11D8E0 VA: 0x18011E4E0
	|-List.Enumerator<CRedge>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<VectorData>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Resolution>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E870 Offset: 0x11DC70 VA: 0x18011E870
	|-List.Enumerator<ERCell>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERConnectionGUIStatus>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ERTerrainChange>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<NormalPairs>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<BurstCloth.Chain>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PathFinder.Point>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Achievement>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<EventProvider.SessionInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<long>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector2i>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149290 Offset: 0x148690 VA: 0x180149290
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RenderInfo.RendererInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Option>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149170 Offset: 0x148570 VA: 0x180149170
	|-List.Enumerator<ERSOSection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x148F80 Offset: 0x148380 VA: 0x180148F80
	|-List.Enumerator<ERSplatmap>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F410 Offset: 0x11E810 VA: 0x18011F410
	|-List.Enumerator<ERVSData>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E5A0 Offset: 0x11D9A0 VA: 0x18011E5A0
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<DemoShotFloatKeyframe>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<double>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149060 Offset: 0x148460 VA: 0x180149060
	|-List.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E920 Offset: 0x11DD20 VA: 0x18011E920
	|-List.Enumerator<Tick.Entry>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Gibbable.OverrideMesh>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<MeshInstance>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PetCommandList.PetCommandDesc>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x149380 Offset: 0x148780 VA: 0x180149380
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EF60 Offset: 0x11E360 VA: 0x18011EF60
	|-List.Enumerator<SevenBitNumber>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<bool>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F010 Offset: 0x11E410 VA: 0x18011F010
	|-List.Enumerator<MeshColliderInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E9E0 Offset: 0x11DDE0 VA: 0x18011E9E0
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11ED30 Offset: 0x11E130 VA: 0x18011ED30
	|-List.Enumerator<MeshRendererInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F350 Offset: 0x11E750 VA: 0x18011F350
	|-List.Enumerator<DemoShotQuaternionKeyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F140 Offset: 0x11E540 VA: 0x18011F140
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11E7C0 Offset: 0x11DBC0 VA: 0x18011E7C0
	|-List.Enumerator<InventoryDefId>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EAE0 Offset: 0x11DEE0 VA: 0x18011EAE0
	|-List.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<short>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EF00 Offset: 0x11E300 VA: 0x18011EF00
	|-List.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11EE50 Offset: 0x11E250 VA: 0x18011EE50
	|-List.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F4E0 Offset: 0x11E8E0 VA: 0x18011F4E0
	|-List.Enumerator<TraceInfo>.System.Collections.IEnumerator.get_Current
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F250 Offset: 0x11E650 VA: 0x18011F250
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21C790 Offset: 0x21BB90 VA: 0x18021C790
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21C6C0 Offset: 0x21BAC0 VA: 0x18021C6C0
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21C5D0 Offset: 0x21B9D0 VA: 0x18021C5D0
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11DE60 Offset: 0x11D260 VA: 0x18011DE60
	|-List.Enumerator<AdvancedChristmasLights.pointEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<AlignedLineDrawer.LinePoint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Cassette.LoadRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Admin.ServerConvarInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Chat.MuteEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERChildsSO>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ExpandedLifeStats.GenericStatDisplay>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<LocalClock.TimedEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MapView.MapMarkerCluster>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MapView.SleepingBagCluster>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<JsonPosition>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TimelineEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TickRenderer.Tick>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryRecipe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SynchronizedClock.TimedEvent>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, Color>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<ulong, Dispatch.ResultCallback>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DFA0 Offset: 0x11D3A0 VA: 0x18011DFA0
	|-List.Enumerator<AtmosphereVolumeRenderer.CurrentVolumeEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DamageRenderer.DamageShowingRenderer>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DeferredExtensionMesh.MaterialLink>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DeferredMeshDecal.MaterialLink>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CombineClass>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERLane>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EntityRef<object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TabbedPanel.Tab>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RCon.BannedAddresses>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WeightedStringList.Container>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<GameStat.Stat>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ImageStorageEntity.ImageRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MagnetCrane.MagnetCraneSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ParticleSystemContainer.ParticleSystemGroup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlayerItemRecipe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotParentKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotVectorKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ReflectionProbeEx.RenderListEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MatchMakingKeyValuePair>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Dispatch.Callback>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Decimal>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Guid>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RangePositionInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TickInterpolator.Segment>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<NavMeshBuildMarkup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Color>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Rect>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<FocusController.FocusedElement>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector4>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WindZoneExManager.CurrentZoneEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WorldSplineData.LUTEntry.LUTPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E0B0 Offset: 0x11D4B0 VA: 0x18011E0B0
	|-List.Enumerator<BaseEntity.ServerFileRequest>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CardTableUI.KeycodeWithAction>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Demos.DemoInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Output.Entry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<IconSkinPicker.SkinButtonSetup>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InvokeAction>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ItemSkinDirectory.Skin>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<KeyframeView.UIKeyframeValue>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MidiConvar.KnobBinding>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MidiConvar.NoteBinding>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<WaypointSet.Waypoint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TransformSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Option>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SkinnedMultiMesh.Part>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SubmarineSonar.SonarBlip>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SpawnIndividual>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SpecialPurposeCamera.RenderEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DE10 Offset: 0x11D210 VA: 0x18011DE10
	|-List.Enumerator<Admin.PlayerInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonuments.SpawnInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DFE0 Offset: 0x11D3E0 VA: 0x18011DFE0
	|-List.Enumerator<Admin.ServerUGCInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<CapsuleParams>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SkeletonDefinition.Bone>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ReflectionProbeEx.CubemapSkyboxVertex>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SteamNewsSource.Story>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<InventoryItem.Amount>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TreeInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ViewModelDrawEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E100 Offset: 0x11D500 VA: 0x18011E100
	|-List.Enumerator<CRedge>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ProjectileWeaponMod.Modifier>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<VectorData>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TrainCar.TrainCarSnapshot>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Resolution>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DEF0 Offset: 0x11D2F0 VA: 0x18011DEF0
	|-List.Enumerator<ERCell>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERConnectionGUIStatus>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ERTerrainChange>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<NormalPairs>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EngineDamageOverTime.RecentDamage>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<BurstCloth.Chain>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MeshRendererLookup.LookupEntry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PathFinder.Point>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlayerItemRecipe.Ingredient>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DemoShotFloatKeyframe>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Achievement>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Friend>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<DateTime>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<EventProvider.SessionInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<double>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<long>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<object>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Vector2i>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148CF0 Offset: 0x1480F0 VA: 0x180148CF0
	|-List.Enumerator<ERMeshCombineUtility.MeshInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RenderInfo.RendererInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Option>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148D50 Offset: 0x148150 VA: 0x180148D50
	|-List.Enumerator<ERSOSection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148DA0 Offset: 0x1481A0 VA: 0x180148DA0
	|-List.Enumerator<ERSplatmap>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E200 Offset: 0x11D600 VA: 0x18011E200
	|-List.Enumerator<ERVSData>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SqliteKeyReader.KeyInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148C80 Offset: 0x148080 VA: 0x180148C80
	|-List.Enumerator<BoneData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E140 Offset: 0x11D540 VA: 0x18011E140
	|-List.Enumerator<Tick.Entry>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Gibbable.OverrideMesh>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<MeshInstance>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PetCommandList.PetCommandDesc>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsOffshore.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsRailside.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<PlaceMonumentsRoadside.SpawnInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<SubsurfaceProfileTexture.SubsurfaceProfileEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x148DF0 Offset: 0x1481F0 VA: 0x180148DF0
	|-List.Enumerator<FoliageGridMeshData.FoliageVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E030 Offset: 0x11D430 VA: 0x18011E030
	|-List.Enumerator<SevenBitNumber>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<bool>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E2A0 Offset: 0x11D6A0 VA: 0x18011E2A0
	|-List.Enumerator<MeshColliderInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E360 Offset: 0x11D760 VA: 0x18011E360
	|-List.Enumerator<MeshColliderLookup.LookupEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E190 Offset: 0x11D590 VA: 0x18011E190
	|-List.Enumerator<MeshRendererInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E250 Offset: 0x11D650 VA: 0x18011E250
	|-List.Enumerator<DemoShotQuaternionKeyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DF30 Offset: 0x11D330 VA: 0x18011DF30
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ServerInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11DEB0 Offset: 0x11D2B0 VA: 0x18011DEB0
	|-List.Enumerator<InventoryDefId>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<int>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<float>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E070 Offset: 0x11D470 VA: 0x18011E070
	|-List.Enumerator<char>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<short>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E310 Offset: 0x11D710 VA: 0x18011E310
	|-List.Enumerator<TraceInfo>.System.Collections.IEnumerator.Reset
	|-List.Enumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11E3C0 Offset: 0x11D7C0 VA: 0x18011E3C0
	|-List.Enumerator<NavMeshBuildSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21C4D0 Offset: 0x21B8D0 VA: 0x18021C4D0
	|-List.Enumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21C580 Offset: 0x21B980 VA: 0x18021C580
	|-List.Enumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21C520 Offset: 0x21B920 VA: 0x18021C520
	|-List.Enumerator<UIVertex>.System.Collections.IEnumerator.Reset
	*/

}

public static class List // TypeDefIndex: 4843
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void Compare<T, TListA, TListB>(TListA a, TListB b, List<T> added, List<T> removed, List<T> remained) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15731B0 Offset: 0x15717B0 VA: 0x1815731B0
	|-List.Compare<Connection, List<Connection>, List<Connection>>
	|-List.Compare<Group, ListHashSet<Group>, List<Group>>
	|-List.Compare<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void Compare<TListA, TListB, TItemA, TItemB, TKey>(TListA a, TListB b, HashSet<TKey> added, HashSet<TKey> removed, HashSet<TKey> remained, Func<TItemA, TKey> selectorA, Func<TItemB, TKey> selectorB) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573510 Offset: 0x1571B10 VA: 0x181573510
	|-List.Compare<Dictionary.KeyCollection<ulong, RelationshipManager.PlayerRelationshipInfo>, List<RelationshipManager.PlayerRelationshipInfo>, ulong, RelationshipManager.PlayerRelationshipInfo, ulong>
	|-List.Compare<object, object, ulong, object, ulong>
	|
	|-RVA: 0x1572BB0 Offset: 0x15711B0 VA: 0x181572BB0
	|-List.Compare<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static TItem FindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8680 Offset: 0x15B6C80 VA: 0x1815B8680
	|-List.FindWith<Manifest.NewsInfo.BlogInfo, string>
	|-List.FindWith<object, object>
	|
	|-RVA: 0x15B8900 Offset: 0x15B6F00 VA: 0x1815B8900
	|-List.FindWith<MarketTerminal.PendingOrder, uint>
	|-List.FindWith<object, uint>
	|
	|-RVA: 0x15B8B80 Offset: 0x15B7180 VA: 0x1815B8B80
	|-List.FindWith<PlayerTeam.TeamMember, ulong>
	|-List.FindWith<object, ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static Nullable<TItem> TryFindWith<TItem, TKey>(IReadOnlyCollection<TItem> items, Func<TItem, TKey> selector, TKey search, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5700 Offset: 0xED3D00 VA: 0x180ED5700
	|-List.TryFindWith<ImageStorageEntity.ImageRequest, IImageReceiver>
	|-List.TryFindWith<ImageStorageEntity.ImageRequest, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static int FindIndexWith<TItem, TKey>(IReadOnlyList<TItem> items, Func<TItem, TKey> selector, TKey search) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1179EE0 Offset: 0x11784E0 VA: 0x181179EE0
	|-List.FindIndexWith<object, object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static void <Compare>g__InitializeWith|1_0<TListA, TListB, TItemA, TItemB, TKey>(HashSet<TKey> set, HashSet<TKey> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1573B70 Offset: 0x1572170 VA: 0x181573B70
	|-List.<Compare>g__InitializeWith|1_0<object, object, object, object, object>
	|
	|-RVA: 0x1573D60 Offset: 0x1572360 VA: 0x181573D60
	|-List.<Compare>g__InitializeWith|1_0<object, object, ulong, object, ulong>
	*/

}

