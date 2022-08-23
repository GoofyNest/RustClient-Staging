public static class Pool // TypeDefIndex: 4835
{	public static Dictionary<Type, Pool.ICollection> directory; // 0x1347D


	public static void FreeList<T>(ref List<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578E30 Offset: 0x1577430 VA: 0x181578E30
	|-Pool.FreeList<BaseEntity.ServerFileRequest>
	|
	|-RVA: 0x1578D50 Offset: 0x1577350 VA: 0x181578D50
	|-Pool.FreeList<BaseEntity>
	|-Pool.FreeList<BaseNetworkable>
	|-Pool.FreeList<BasePlayer>
	|-Pool.FreeList<BaseVehicle>
	|-Pool.FreeList<BaseVehicleModule>
	|-Pool.FreeList<BuildingBlock>
	|-Pool.FreeList<CollectableEasterEgg>
	|-Pool.FreeList<DecalRecycle>
	|-Pool.FreeList<DroppedItem>
	|-Pool.FreeList<EffectRecycle>
	|-Pool.FreeList<EnvironmentVolume>
	|-Pool.FreeList<PlayingCard>
	|-Pool.FreeList<Input.Button>
	|-Pool.FreeList<FoliageCell>
	|-Pool.FreeList<Gib>
	|-Pool.FreeList<GraveyardFence>
	|-Pool.FreeList<HitboxDefinition>
	|-Pool.FreeList<IBlueprintsChanged>
	|-Pool.FreeList<IClothingChanged>
	|-Pool.FreeList<IEffect>
	|-Pool.FreeList<IInventoryChanged>
	|-Pool.FreeList<IItemAmountChanged>
	|-Pool.FreeList<IItemIconChanged>
	|-Pool.FreeList<IItemSetup>
	|-Pool.FreeList<IItemUpdate>
	|-Pool.FreeList<IOEntity>
	|-Pool.FreeList<IOnParentDestroying>
	|-Pool.FreeList<IOnParentSpawning>
	|-Pool.FreeList<IOnPostNetworkUpdate>
	|-Pool.FreeList<IOnSendNetworkUpdate>
	|-Pool.FreeList<IRagdollInhert>
	|-Pool.FreeList<IViewModeChanged>
	|-Pool.FreeList<IViewModelUpdated>
	|-Pool.FreeList<Item>
	|-Pool.FreeList<ItemAmount>
	|-Pool.FreeList<ItemBlueprint>
	|-Pool.FreeList<LODComponent>
	|-Pool.FreeList<LightOccludee>
	|-Pool.FreeList<MapMarker>
	|-Pool.FreeList<MaterialReplacement>
	|-Pool.FreeList<MissionEntity>
	|-Pool.FreeList<MorphCache>
	|-Pool.FreeList<Connection>
	|-Pool.FreeList<Group>
	|-Pool.FreeList<Prefab>
	|-Pool.FreeList<AIEventData>
	|-Pool.FreeList<AIStateContainer>
	|-Pool.FreeList<AppChatMessage>
	|-Pool.FreeList<AppEntityPayload.Item>
	|-Pool.FreeList<AppMap.Monument>
	|-Pool.FreeList<AppMarker.SellOrder>
	|-Pool.FreeList<AppMarker>
	|-Pool.FreeList<AppTeamInfo.Member>
	|-Pool.FreeList<AppTeamInfo.Note>
	|-Pool.FreeList<ArcadeGame.arcadeEnt>
	|-Pool.FreeList<ArcadeMachine.ScoreEntry>
	|-Pool.FreeList<BaseVehicle.MountPoint>
	|-Pool.FreeList<CardTable.CardPlayer>
	|-Pool.FreeList<CardTable.WinnerBreakdown.Winner>
	|-Pool.FreeList<ClientReady.ClientInfo>
	|-Pool.FreeList<EggHunt.EggHunter>
	|-Pool.FreeList<Entity>
	|-Pool.FreeList<FileStorageCacheData>
	|-Pool.FreeList<GameMode.PlayerScore>
	|-Pool.FreeList<GameMode.ScoreColumn>
	|-Pool.FreeList<GameMode.TeamInfo>
	|-Pool.FreeList<GenericSpawner.SpawnedEnt>
	|-Pool.FreeList<IOEntity.IOConnection.LineVec>
	|-Pool.FreeList<IOEntity.IOConnection>
	|-Pool.FreeList<InstrumentMidiBinding>
	|-Pool.FreeList<InstrumentRecordingNote>
	|-Pool.FreeList<Item>
	|-Pool.FreeList<ItemContainer>
	|-Pool.FreeList<LightString.StringPoint>
	|-Pool.FreeList<LinePoint>
	|-Pool.FreeList<MapData>
	|-Pool.FreeList<MapNote>
	|-Pool.FreeList<MarketTerminal.PendingOrder>
	|-Pool.FreeList<MissionInstance>
	|-Pool.FreeList<MissionPoint>
	|-Pool.FreeList<MissionReward>
	|-Pool.FreeList<Modifier>
	|-Pool.FreeList<NeonSign.Lights>
	|-Pool.FreeList<ObjectiveStatus>
	|-Pool.FreeList<PathData>
	|-Pool.FreeList<PatternFirework.Star>
	|-Pool.FreeList<PhoneDirectory.DirectoryEntry>
	|-Pool.FreeList<PlayerLifeStory.GenericStat>
	|-Pool.FreeList<PlayerLifeStory.WeaponStats>
	|-Pool.FreeList<PlayerNameID>
	|-Pool.FreeList<PlayerTeam.TeamMember>
	|-Pool.FreeList<PlayerTeam>
	|-Pool.FreeList<PrefabData>
	|-Pool.FreeList<ProjectileShoot.Projectile>
	|-Pool.FreeList<ReclaimManager.ReclaimInfo>
	|-Pool.FreeList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.FreeList<RelationshipManager.PlayerRelationships>
	|-Pool.FreeList<RespawnInformation.SpawnOptions>
	|-Pool.FreeList<Tree>
	|-Pool.FreeList<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.FreeList<VehicleVendor.PlayerStorage>
	|-Pool.FreeList<VendingMachine.SellOrder>
	|-Pool.FreeList<VendingMachine>
	|-Pool.FreeList<VoicemailEntry>
	|-Pool.FreeList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.FreeList<RendererBatch>
	|-Pool.FreeList<ItemModEngineItem>
	|-Pool.FreeList<ServerAdminUGCEntry>
	|-Pool.FreeList<ServerAdminUGCEntryPattern>
	|-Pool.FreeList<ShoutcastStreamer>
	|-Pool.FreeList<SleepingBag>
	|-Pool.FreeList<Socket_Base>
	|-Pool.FreeList<IEnumerator>
	|-Pool.FreeList<object>
	|-Pool.FreeList<string>
	|-Pool.FreeList<TechTreeData.NodeInstance>
	|-Pool.FreeList<TriggerBase>
	|-Pool.FreeList<AudioSource>
	|-Pool.FreeList<Collider>
	|-Pool.FreeList<GameObject>
	|-Pool.FreeList<LODGroup>
	|-Pool.FreeList<Material>
	|-Pool.FreeList<MeshRenderer>
	|-Pool.FreeList<ParticleSystem>
	|-Pool.FreeList<Renderer>
	|-Pool.FreeList<Rigidbody>
	|-Pool.FreeList<SkinnedMeshRenderer>
	|-Pool.FreeList<TrailRenderer>
	|-Pool.FreeList<Transform>
	|-Pool.FreeList<VendingMachineMapMarker>
	|-Pool.FreeList<WaterVolume>
	|-Pool.FreeList<Wearable>
	|-Pool.FreeList<WearableHairCap>
	|
	|-RVA: 0x15783B0 Offset: 0x15769B0 VA: 0x1815783B0
	|-Pool.FreeList<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x1578B90 Offset: 0x1577190 VA: 0x181578B90
	|-Pool.FreeList<Option>
	|
	|-RVA: 0x1578FF0 Offset: 0x15775F0 VA: 0x181578FF0
	|-Pool.FreeList<IconSkinPicker.SkinButtonSetup>
	|
	|-RVA: 0x1578490 Offset: 0x1576A90 VA: 0x181578490
	|-Pool.FreeList<ImageStorageEntity.ImageRequest>
	|
	|-RVA: 0x1578650 Offset: 0x1576C50 VA: 0x181578650
	|-Pool.FreeList<InvokeAction>
	|
	|-RVA: 0x1578810 Offset: 0x1576E10 VA: 0x181578810
	|-Pool.FreeList<MapView.MapMarkerCluster>
	|
	|-RVA: 0x15790D0 Offset: 0x15776D0 VA: 0x1815790D0
	|-Pool.FreeList<MapView.SleepingBagCluster>
	|
	|-RVA: 0x15788F0 Offset: 0x1576EF0 VA: 0x1815788F0
	|-Pool.FreeList<MeshColliderInstance>
	|
	|-RVA: 0x15789D0 Offset: 0x1576FD0 VA: 0x1815789D0
	|-Pool.FreeList<MeshInstance>
	|
	|-RVA: 0x1578AB0 Offset: 0x15770B0 VA: 0x181578AB0
	|-Pool.FreeList<MeshRendererInstance>
	|
	|-RVA: 0x1578030 Offset: 0x1576630 VA: 0x181578030
	|-Pool.FreeList<DemoShotFloatKeyframe>
	|
	|-RVA: 0x1578110 Offset: 0x1576710 VA: 0x181578110
	|-Pool.FreeList<DemoShotParentKeyframe>
	|
	|-RVA: 0x15781F0 Offset: 0x15767F0 VA: 0x1815781F0
	|-Pool.FreeList<DemoShotQuaternionKeyframe>
	|
	|-RVA: 0x15782D0 Offset: 0x15768D0 VA: 0x1815782D0
	|-Pool.FreeList<DemoShotVectorKeyframe>
	|
	|-RVA: 0x1579990 Offset: 0x1577F90 VA: 0x181579990
	|-Pool.FreeList<VectorData>
	|
	|-RVA: 0x15791B0 Offset: 0x15777B0 VA: 0x1815791B0
	|-Pool.FreeList<SubmarineSonar.SonarBlip>
	|
	|-RVA: 0x1577E70 Offset: 0x1576470 VA: 0x181577E70
	|-Pool.FreeList<bool>
	|
	|-RVA: 0x1578730 Offset: 0x1576D30 VA: 0x181578730
	|-Pool.FreeList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.FreeList<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1578570 Offset: 0x1576B70 VA: 0x181578570
	|-Pool.FreeList<int>
	|
	|-RVA: 0x1578F10 Offset: 0x1577510 VA: 0x181578F10
	|-Pool.FreeList<float>
	|
	|-RVA: 0x1579370 Offset: 0x1577970 VA: 0x181579370
	|-Pool.FreeList<uint>
	|
	|-RVA: 0x1579450 Offset: 0x1577A50 VA: 0x181579450
	|-Pool.FreeList<ulong>
	|
	|-RVA: 0x1579530 Offset: 0x1577B30 VA: 0x181579530
	|-Pool.FreeList<ValueTuple<object, object>>
	|-Pool.FreeList<ValueTuple<string, AssetBundleRequest>>
	|
	|-RVA: 0x1579290 Offset: 0x1577890 VA: 0x181579290
	|-Pool.FreeList<TraceInfo>
	|
	|-RVA: 0x1577F50 Offset: 0x1576550 VA: 0x181577F50
	|-Pool.FreeList<Color32>
	|
	|-RVA: 0x1578C70 Offset: 0x1577270 VA: 0x181578C70
	|-Pool.FreeList<RaycastHit>
	|
	|-RVA: 0x1579610 Offset: 0x1577C10 VA: 0x181579610
	|-Pool.FreeList<Vector2>
	|
	|-RVA: 0x15797D0 Offset: 0x1577DD0 VA: 0x1815797D0
	|-Pool.FreeList<Vector3>
	|
	|-RVA: 0x15798B0 Offset: 0x1577EB0 VA: 0x1815798B0
	|-Pool.FreeList<Vector4>
	|
	|-RVA: 0x15796F0 Offset: 0x1577CF0 VA: 0x1815796F0
	|-Pool.FreeList<Vector2i>
	*/

	public static void FreeMemoryStream(ref MemoryStream obj) { }

	public static void Free<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579A70 Offset: 0x1578070 VA: 0x181579A70
	|-Pool.Free<BaseMission.MissionInstance>
	|-Pool.Free<BaseVehicle.Enumerator.Box>
	|-Pool.Free<BuildingManager.Building>
	|-Pool.Free<EffectData>
	|-Pool.Free<EngineAudioClip.Grain>
	|-Pool.Free<EntityLink>
	|-Pool.Free<FoliageGroup>
	|-Pool.Free<GranularAudioClip.Grain>
	|-Pool.Free<ImpostorBatch>
	|-Pool.Free<InputMessage>
	|-Pool.Free<LODCell>
	|-Pool.Free<ListDictionary<FoliageKey, FoliageGroup>>
	|-Pool.Free<ModelState>
	|-Pool.Free<MusicClipLoader.LoadedAudioClip>
	|-Pool.Free<MusicManager.ClipPlaybackData>
	|-Pool.Free<NativeList<uint>>
	|-Pool.Free<NativeList<Vector4>>
	|-Pool.Free<Message>
	|-Pool.Free<Networkable>
	|-Pool.Free<Stats.Node>
	|-Pool.Free<Subscriber>
	|-Pool.Free<PlayerTick>
	|-Pool.Free<PositionLerp>
	|-Pool.Free<AIDesign>
	|-Pool.Free<AIEventData>
	|-Pool.Free<AIStateContainer>
	|-Pool.Free<AggressionTimerAIEventData>
	|-Pool.Free<AmmoBelowAIEventData>
	|-Pool.Free<AppBroadcast>
	|-Pool.Free<AppChatMessage>
	|-Pool.Free<AppEmpty>
	|-Pool.Free<AppEntityChanged>
	|-Pool.Free<AppEntityInfo>
	|-Pool.Free<AppEntityPayload.Item>
	|-Pool.Free<AppEntityPayload>
	|-Pool.Free<AppError>
	|-Pool.Free<AppFlag>
	|-Pool.Free<AppInfo>
	|-Pool.Free<AppMap.Monument>
	|-Pool.Free<AppMap>
	|-Pool.Free<AppMapMarkers>
	|-Pool.Free<AppMarker.SellOrder>
	|-Pool.Free<AppMarker>
	|-Pool.Free<AppMessage>
	|-Pool.Free<AppPromoteToLeader>
	|-Pool.Free<AppRequest>
	|-Pool.Free<AppResponse>
	|-Pool.Free<AppSendMessage>
	|-Pool.Free<AppSetEntityValue>
	|-Pool.Free<AppSuccess>
	|-Pool.Free<AppTeamChanged>
	|-Pool.Free<AppTeamChat>
	|-Pool.Free<AppTeamInfo.Member>
	|-Pool.Free<AppTeamInfo.Note>
	|-Pool.Free<AppTeamInfo>
	|-Pool.Free<AppTeamMessage>
	|-Pool.Free<AppTime>
	|-Pool.Free<Approval>
	|-Pool.Free<ArcadeGame.arcadeEnt>
	|-Pool.Free<ArcadeGame>
	|-Pool.Free<ArcadeMachine.ScoreEntry>
	|-Pool.Free<ArcadeMachine>
	|-Pool.Free<Attack>
	|-Pool.Free<AudioEntity>
	|-Pool.Free<AutoTurret>
	|-Pool.Free<BaseCombat>
	|-Pool.Free<BaseEntity>
	|-Pool.Free<BaseNPC>
	|-Pool.Free<BaseNetworkable>
	|-Pool.Free<BasePlayer>
	|-Pool.Free<BaseProjectile>
	|-Pool.Free<BaseResource>
	|-Pool.Free<BaseTrain>
	|-Pool.Free<BaseVehicle.MountPoint>
	|-Pool.Free<BaseVehicle>
	|-Pool.Free<BoomBox>
	|-Pool.Free<BradleyAPC>
	|-Pool.Free<BuildingBlock>
	|-Pool.Free<BuildingPrivilege>
	|-Pool.Free<CamperModule>
	|-Pool.Free<CardTable.CardList>
	|-Pool.Free<CardTable.CardPlayer>
	|-Pool.Free<CardTable.TexasHoldEm>
	|-Pool.Free<CardTable.WinnerBreakdown.Winner>
	|-Pool.Free<CardTable.WinnerBreakdown>
	|-Pool.Free<CardTable>
	|-Pool.Free<CargoPlane>
	|-Pool.Free<Cassette>
	|-Pool.Free<ChanceAIEventData>
	|-Pool.Free<ClientReady.ClientInfo>
	|-Pool.Free<ClientReady>
	|-Pool.Free<CoalingTower>
	|-Pool.Free<CodeLock.Private>
	|-Pool.Free<CodeLock>
	|-Pool.Free<Composter>
	|-Pool.Free<ComputerStation>
	|-Pool.Free<ConnectedSpeaker>
	|-Pool.Free<Corpse>
	|-Pool.Free<Crane>
	|-Pool.Free<CreateBuilding>
	|-Pool.Free<DecayEntity>
	|-Pool.Free<DeliveryDrone>
	|-Pool.Free<DemoHeader>
	|-Pool.Free<DemoShot>
	|-Pool.Free<DemoShotFloatTrack>
	|-Pool.Free<DemoShotParentTrack>
	|-Pool.Free<DemoShotQuaternionTrack>
	|-Pool.Free<DemoShotVectorTrack>
	|-Pool.Free<DudExplosive>
	|-Pool.Free<EggHunt.EggHunter>
	|-Pool.Free<EggHunt>
	|-Pool.Free<Elevator>
	|-Pool.Free<EngineStorage>
	|-Pool.Free<Entity>
	|-Pool.Free<EntityIdList>
	|-Pool.Free<EntityList>
	|-Pool.Free<EntitySlots>
	|-Pool.Free<Environment>
	|-Pool.Free<FileStorageCacheData>
	|-Pool.Free<FrankensteinTable>
	|-Pool.Free<GameMode.PlayerScore>
	|-Pool.Free<GameMode.ScoreColumn>
	|-Pool.Free<GameMode.TeamInfo>
	|-Pool.Free<GameMode>
	|-Pool.Free<GenericSpawner.SpawnedEnt>
	|-Pool.Free<GenericSpawner>
	|-Pool.Free<GrowableEntity>
	|-Pool.Free<HealthBelowAIEventData>
	|-Pool.Free<HeldEntity>
	|-Pool.Free<Helicopter>
	|-Pool.Free<Horse>
	|-Pool.Free<HotAirBalloon>
	|-Pool.Free<HungerAboveAIEventData>
	|-Pool.Free<IOEntity.IOConnection.LinePointList>
	|-Pool.Free<IOEntity.IOConnection.LineVec>
	|-Pool.Free<IOEntity.IOConnection>
	|-Pool.Free<IOEntity>
	|-Pool.Free<InRangeAIEventData>
	|-Pool.Free<InRangeOfHomeAIEventData>
	|-Pool.Free<InstrumentMidiBinding>
	|-Pool.Free<InstrumentMidiBindings>
	|-Pool.Free<InstrumentRecording>
	|-Pool.Free<InstrumentRecordingNote>
	|-Pool.Free<Item.ConditionData>
	|-Pool.Free<Item.InstanceData>
	|-Pool.Free<Item>
	|-Pool.Free<ItemAmountList>
	|-Pool.Free<ItemContainer>
	|-Pool.Free<KeyLock>
	|-Pool.Free<Landmine>
	|-Pool.Free<Lift>
	|-Pool.Free<LightDeployer>
	|-Pool.Free<LightString.StringPoint>
	|-Pool.Free<LightString>
	|-Pool.Free<LinePoint>
	|-Pool.Free<Loot>
	|-Pool.Free<LootableCorpse.Private>
	|-Pool.Free<LootableCorpse>
	|-Pool.Free<MLRS>
	|-Pool.Free<Magazine>
	|-Pool.Free<MapData>
	|-Pool.Free<MapEntity>
	|-Pool.Free<MapNote>
	|-Pool.Free<MapNoteList>
	|-Pool.Free<MarketTerminal.PendingOrder>
	|-Pool.Free<MarketTerminal>
	|-Pool.Free<MemoryBank>
	|-Pool.Free<MicrophoneStand>
	|-Pool.Free<Minicopter>
	|-Pool.Free<MiningQuarry>
	|-Pool.Free<MissionInstance>
	|-Pool.Free<MissionPoint>
	|-Pool.Free<MissionReward>
	|-Pool.Free<Missions>
	|-Pool.Free<MixingTable>
	|-Pool.Free<Modifier>
	|-Pool.Free<ModularCar>
	|-Pool.Free<ModularVehicle>
	|-Pool.Free<ModuleMessage>
	|-Pool.Free<Motorboat>
	|-Pool.Free<NeonSign.Lights>
	|-Pool.Free<NeonSign>
	|-Pool.Free<ObjectiveStatus>
	|-Pool.Free<OwnerInfo>
	|-Pool.Free<PaintableSign>
	|-Pool.Free<PaintedItem>
	|-Pool.Free<ParentInfo>
	|-Pool.Free<PathData>
	|-Pool.Free<PatternFirework.Design>
	|-Pool.Free<PatternFirework.SavedDesign>
	|-Pool.Free<PatternFirework.Star>
	|-Pool.Free<PatternFirework>
	|-Pool.Free<PersistantPlayer>
	|-Pool.Free<PhoneDirectory.DirectoryEntry>
	|-Pool.Free<PhoneDirectory>
	|-Pool.Free<Photo>
	|-Pool.Free<PhotoFrame>
	|-Pool.Free<PlayerAttack>
	|-Pool.Free<PlayerDetectedAIEventData>
	|-Pool.Free<PlayerInventory>
	|-Pool.Free<PlayerLifeStory.DeathInfo>
	|-Pool.Free<PlayerLifeStory.GenericStat>
	|-Pool.Free<PlayerLifeStory.WeaponStats>
	|-Pool.Free<PlayerLifeStory>
	|-Pool.Free<PlayerMetabolism>
	|-Pool.Free<PlayerModifiers>
	|-Pool.Free<PlayerNameID>
	|-Pool.Free<PlayerProjectileAttack>
	|-Pool.Free<PlayerProjectileRicochet>
	|-Pool.Free<PlayerProjectileUpdate>
	|-Pool.Free<PlayerState>
	|-Pool.Free<PlayerTeam.TeamMember>
	|-Pool.Free<PlayerTeam>
	|-Pool.Free<PlayerUpdateLoot>
	|-Pool.Free<PrefabData>
	|-Pool.Free<ProjectileShoot.Projectile>
	|-Pool.Free<ProjectileShoot>
	|-Pool.Free<PuzzleReset>
	|-Pool.Free<RCEntity>
	|-Pool.Free<RadioList>
	|-Pool.Free<ReclaimManager.ReclaimInfo>
	|-Pool.Free<ReclaimManager>
	|-Pool.Free<ReclaimTerminal>
	|-Pool.Free<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Free<RelationshipManager.PlayerRelationships>
	|-Pool.Free<RelationshipManager>
	|-Pool.Free<ResearchTable>
	|-Pool.Free<ResourceExtractor>
	|-Pool.Free<RespawnInformation.SpawnOptions>
	|-Pool.Free<RespawnInformation>
	|-Pool.Free<SAMSite>
	|-Pool.Free<ServerGib>
	|-Pool.Free<ShopKeeper>
	|-Pool.Free<Sign>
	|-Pool.Free<SimpleFloat>
	|-Pool.Free<SimpleUID>
	|-Pool.Free<SkullTrophy>
	|-Pool.Free<SleepingBag>
	|-Pool.Free<SleepingBagCamper>
	|-Pool.Free<SlotMachine>
	|-Pool.Free<SmartAlarm>
	|-Pool.Free<Snowmobile>
	|-Pool.Free<Spawnable>
	|-Pool.Free<SphereEntity>
	|-Pool.Free<SpinnerWheel>
	|-Pool.Free<Spray>
	|-Pool.Free<SprayLine>
	|-Pool.Free<SprayList>
	|-Pool.Free<StabilityEntity>
	|-Pool.Free<StorageBox>
	|-Pool.Free<SubEntityList>
	|-Pool.Free<Submarine>
	|-Pool.Free<TakeDamage>
	|-Pool.Free<TargetDetectedAIEventData>
	|-Pool.Free<Telephone>
	|-Pool.Free<ThreatDetectedAIEventData>
	|-Pool.Free<TimeSinceThreatAIEventData>
	|-Pool.Free<TimerAIEventData>
	|-Pool.Free<TirednessAboveAIEventData>
	|-Pool.Free<TrainEngine>
	|-Pool.Free<Tree>
	|-Pool.Free<TreeList>
	|-Pool.Free<UpdateItem>
	|-Pool.Free<UpdateItemContainer>
	|-Pool.Free<VehicleLift>
	|-Pool.Free<VehicleModule>
	|-Pool.Free<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.Free<VehicleVendor.PlayerStorage>
	|-Pool.Free<VehicleVendor>
	|-Pool.Free<VendingMachine.SellOrder>
	|-Pool.Free<VendingMachine.SellOrderContainer>
	|-Pool.Free<VendingMachine>
	|-Pool.Free<VoicemailEntry>
	|-Pool.Free<WaterPool>
	|-Pool.Free<WaterWell>
	|-Pool.Free<Whitelist>
	|-Pool.Free<WorldData>
	|-Pool.Free<WorldItem>
	|-Pool.Free<WorldMessage>
	|-Pool.Free<Zipline>
	|-Pool.Free<ZiplineArrivalPoint>
	|-Pool.Free<ZiplineMountable>
	|-Pool.Free<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Free<RendererCell>
	|-Pool.Free<RendererGroup>
	|-Pool.Free<SimpleList<Matrix4x4>>
	|-Pool.Free<SimpleList<WaterDynamics.InstanceData>>
	|-Pool.Free<SlicedGranularAudioClip.Grain>
	|-Pool.Free<SoundModulation.Modulator>
	|-Pool.Free<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Free<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Free<HashSet<int>>
	|-Pool.Free<HashSet<ulong>>
	|-Pool.Free<List<int>>
	|-Pool.Free<Stopwatch>
	|-Pool.Free<object>
	|-Pool.Free<WaitForSecondsRealtimeEx>
	|-Pool.Free<WaterDynamics.InstanceBatch>
	*/

	public static void FreeDynamic<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1577C10 Offset: 0x1576210 VA: 0x181577C10
	|-Pool.FreeDynamic<object>
	*/

	private static void FreeInternal<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1577DE0 Offset: 0x15763E0 VA: 0x181577DE0
	|-Pool.FreeInternal<MemoryStream>
	|-Pool.FreeInternal<object>
	*/

	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3740 Offset: 0x5D1D40 VA: 0x1805D3740
	|-Pool.Get<BaseMission.MissionInstance>
	|-Pool.Get<BaseVehicle.Enumerator.Box>
	|-Pool.Get<BuildingManager.Building>
	|-Pool.Get<EffectData>
	|-Pool.Get<EngineAudioClip.Grain>
	|-Pool.Get<EntityLink>
	|-Pool.Get<FoliageGroup>
	|-Pool.Get<GranularAudioClip.Grain>
	|-Pool.Get<ImpostorBatch>
	|-Pool.Get<InputMessage>
	|-Pool.Get<LODCell>
	|-Pool.Get<ListDictionary<FoliageKey, FoliageGroup>>
	|-Pool.Get<ModelState>
	|-Pool.Get<MusicClipLoader.LoadedAudioClip>
	|-Pool.Get<MusicManager.ClipPlaybackData>
	|-Pool.Get<NativeList<uint>>
	|-Pool.Get<NativeList<Vector4>>
	|-Pool.Get<Message>
	|-Pool.Get<Networkable>
	|-Pool.Get<Subscriber>
	|-Pool.Get<PlayerTick>
	|-Pool.Get<PositionLerp>
	|-Pool.Get<AIDesign>
	|-Pool.Get<AIEventData>
	|-Pool.Get<AIStateContainer>
	|-Pool.Get<AggressionTimerAIEventData>
	|-Pool.Get<AmmoBelowAIEventData>
	|-Pool.Get<AppBroadcast>
	|-Pool.Get<AppChatMessage>
	|-Pool.Get<AppEmpty>
	|-Pool.Get<AppEntityChanged>
	|-Pool.Get<AppEntityInfo>
	|-Pool.Get<AppEntityPayload.Item>
	|-Pool.Get<AppEntityPayload>
	|-Pool.Get<AppError>
	|-Pool.Get<AppFlag>
	|-Pool.Get<AppInfo>
	|-Pool.Get<AppMap.Monument>
	|-Pool.Get<AppMap>
	|-Pool.Get<AppMapMarkers>
	|-Pool.Get<AppMarker.SellOrder>
	|-Pool.Get<AppMarker>
	|-Pool.Get<AppMessage>
	|-Pool.Get<AppPromoteToLeader>
	|-Pool.Get<AppRequest>
	|-Pool.Get<AppResponse>
	|-Pool.Get<AppSendMessage>
	|-Pool.Get<AppSetEntityValue>
	|-Pool.Get<AppSuccess>
	|-Pool.Get<AppTeamChanged>
	|-Pool.Get<AppTeamChat>
	|-Pool.Get<AppTeamInfo.Member>
	|-Pool.Get<AppTeamInfo.Note>
	|-Pool.Get<AppTeamInfo>
	|-Pool.Get<AppTeamMessage>
	|-Pool.Get<AppTime>
	|-Pool.Get<Approval>
	|-Pool.Get<ArcadeGame.arcadeEnt>
	|-Pool.Get<ArcadeGame>
	|-Pool.Get<ArcadeMachine.ScoreEntry>
	|-Pool.Get<ArcadeMachine>
	|-Pool.Get<Attack>
	|-Pool.Get<AudioEntity>
	|-Pool.Get<AutoTurret>
	|-Pool.Get<BaseCombat>
	|-Pool.Get<BaseEntity>
	|-Pool.Get<BaseNPC>
	|-Pool.Get<BaseNetworkable>
	|-Pool.Get<BasePlayer>
	|-Pool.Get<BaseProjectile>
	|-Pool.Get<BaseResource>
	|-Pool.Get<BaseTrain>
	|-Pool.Get<BaseVehicle.MountPoint>
	|-Pool.Get<BaseVehicle>
	|-Pool.Get<BoomBox>
	|-Pool.Get<BradleyAPC>
	|-Pool.Get<BuildingBlock>
	|-Pool.Get<BuildingPrivilege>
	|-Pool.Get<CamperModule>
	|-Pool.Get<CardTable.CardList>
	|-Pool.Get<CardTable.CardPlayer>
	|-Pool.Get<CardTable.TexasHoldEm>
	|-Pool.Get<CardTable.WinnerBreakdown.Winner>
	|-Pool.Get<CardTable.WinnerBreakdown>
	|-Pool.Get<CardTable>
	|-Pool.Get<CargoPlane>
	|-Pool.Get<Cassette>
	|-Pool.Get<ChanceAIEventData>
	|-Pool.Get<ClientReady.ClientInfo>
	|-Pool.Get<ClientReady>
	|-Pool.Get<CoalingTower>
	|-Pool.Get<CodeLock.Private>
	|-Pool.Get<CodeLock>
	|-Pool.Get<Composter>
	|-Pool.Get<ComputerStation>
	|-Pool.Get<ConnectedSpeaker>
	|-Pool.Get<Corpse>
	|-Pool.Get<Crane>
	|-Pool.Get<CreateBuilding>
	|-Pool.Get<DecayEntity>
	|-Pool.Get<DeliveryDrone>
	|-Pool.Get<DemoHeader>
	|-Pool.Get<DemoShot>
	|-Pool.Get<DemoShotFloatTrack>
	|-Pool.Get<DemoShotParentTrack>
	|-Pool.Get<DemoShotQuaternionTrack>
	|-Pool.Get<DemoShotVectorTrack>
	|-Pool.Get<DudExplosive>
	|-Pool.Get<EggHunt.EggHunter>
	|-Pool.Get<EggHunt>
	|-Pool.Get<Elevator>
	|-Pool.Get<EngineStorage>
	|-Pool.Get<Entity>
	|-Pool.Get<EntityIdList>
	|-Pool.Get<EntityList>
	|-Pool.Get<EntitySlots>
	|-Pool.Get<Environment>
	|-Pool.Get<FileStorageCacheData>
	|-Pool.Get<FrankensteinTable>
	|-Pool.Get<GameMode.PlayerScore>
	|-Pool.Get<GameMode.ScoreColumn>
	|-Pool.Get<GameMode.TeamInfo>
	|-Pool.Get<GameMode>
	|-Pool.Get<GenericSpawner.SpawnedEnt>
	|-Pool.Get<GenericSpawner>
	|-Pool.Get<GrowableEntity>
	|-Pool.Get<HealthBelowAIEventData>
	|-Pool.Get<HeldEntity>
	|-Pool.Get<Helicopter>
	|-Pool.Get<Horse>
	|-Pool.Get<HotAirBalloon>
	|-Pool.Get<HungerAboveAIEventData>
	|-Pool.Get<IOEntity.IOConnection.LinePointList>
	|-Pool.Get<IOEntity.IOConnection.LineVec>
	|-Pool.Get<IOEntity.IOConnection>
	|-Pool.Get<IOEntity>
	|-Pool.Get<InRangeAIEventData>
	|-Pool.Get<InRangeOfHomeAIEventData>
	|-Pool.Get<InstrumentMidiBinding>
	|-Pool.Get<InstrumentMidiBindings>
	|-Pool.Get<InstrumentRecording>
	|-Pool.Get<InstrumentRecordingNote>
	|-Pool.Get<Item.ConditionData>
	|-Pool.Get<Item.InstanceData>
	|-Pool.Get<Item>
	|-Pool.Get<ItemAmountList>
	|-Pool.Get<ItemContainer>
	|-Pool.Get<KeyLock>
	|-Pool.Get<Landmine>
	|-Pool.Get<Lift>
	|-Pool.Get<LightDeployer>
	|-Pool.Get<LightString.StringPoint>
	|-Pool.Get<LightString>
	|-Pool.Get<LinePoint>
	|-Pool.Get<Loot>
	|-Pool.Get<LootableCorpse.Private>
	|-Pool.Get<LootableCorpse>
	|-Pool.Get<MLRS>
	|-Pool.Get<Magazine>
	|-Pool.Get<MapData>
	|-Pool.Get<MapEntity>
	|-Pool.Get<MapNote>
	|-Pool.Get<MapNoteList>
	|-Pool.Get<MarketTerminal.PendingOrder>
	|-Pool.Get<MarketTerminal>
	|-Pool.Get<MemoryBank>
	|-Pool.Get<MicrophoneStand>
	|-Pool.Get<Minicopter>
	|-Pool.Get<MiningQuarry>
	|-Pool.Get<MissionInstance>
	|-Pool.Get<MissionPoint>
	|-Pool.Get<MissionReward>
	|-Pool.Get<Missions>
	|-Pool.Get<MixingTable>
	|-Pool.Get<Modifier>
	|-Pool.Get<ModularCar>
	|-Pool.Get<ModularVehicle>
	|-Pool.Get<ModuleMessage>
	|-Pool.Get<Motorboat>
	|-Pool.Get<NeonSign.Lights>
	|-Pool.Get<NeonSign>
	|-Pool.Get<ObjectiveStatus>
	|-Pool.Get<OwnerInfo>
	|-Pool.Get<PaintableSign>
	|-Pool.Get<PaintedItem>
	|-Pool.Get<ParentInfo>
	|-Pool.Get<PathData>
	|-Pool.Get<PatternFirework.Design>
	|-Pool.Get<PatternFirework.SavedDesign>
	|-Pool.Get<PatternFirework.Star>
	|-Pool.Get<PatternFirework>
	|-Pool.Get<PersistantPlayer>
	|-Pool.Get<PhoneDirectory.DirectoryEntry>
	|-Pool.Get<PhoneDirectory>
	|-Pool.Get<Photo>
	|-Pool.Get<PhotoFrame>
	|-Pool.Get<PlayerAttack>
	|-Pool.Get<PlayerDetectedAIEventData>
	|-Pool.Get<PlayerInventory>
	|-Pool.Get<PlayerLifeStory.DeathInfo>
	|-Pool.Get<PlayerLifeStory.GenericStat>
	|-Pool.Get<PlayerLifeStory.WeaponStats>
	|-Pool.Get<PlayerLifeStory>
	|-Pool.Get<PlayerMetabolism>
	|-Pool.Get<PlayerModifiers>
	|-Pool.Get<PlayerNameID>
	|-Pool.Get<PlayerProjectileAttack>
	|-Pool.Get<PlayerProjectileRicochet>
	|-Pool.Get<PlayerProjectileUpdate>
	|-Pool.Get<PlayerState>
	|-Pool.Get<PlayerTeam.TeamMember>
	|-Pool.Get<PlayerTeam>
	|-Pool.Get<PlayerUpdateLoot>
	|-Pool.Get<PrefabData>
	|-Pool.Get<ProjectileShoot.Projectile>
	|-Pool.Get<ProjectileShoot>
	|-Pool.Get<PuzzleReset>
	|-Pool.Get<RCEntity>
	|-Pool.Get<RadioList>
	|-Pool.Get<ReclaimManager.ReclaimInfo>
	|-Pool.Get<ReclaimManager>
	|-Pool.Get<ReclaimTerminal>
	|-Pool.Get<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Get<RelationshipManager.PlayerRelationships>
	|-Pool.Get<RelationshipManager>
	|-Pool.Get<ResearchTable>
	|-Pool.Get<ResourceExtractor>
	|-Pool.Get<RespawnInformation.SpawnOptions>
	|-Pool.Get<RespawnInformation>
	|-Pool.Get<SAMSite>
	|-Pool.Get<ServerGib>
	|-Pool.Get<ShopKeeper>
	|-Pool.Get<Sign>
	|-Pool.Get<SimpleFloat>
	|-Pool.Get<SimpleUID>
	|-Pool.Get<SkullTrophy>
	|-Pool.Get<SleepingBag>
	|-Pool.Get<SleepingBagCamper>
	|-Pool.Get<SlotMachine>
	|-Pool.Get<SmartAlarm>
	|-Pool.Get<Snowmobile>
	|-Pool.Get<Spawnable>
	|-Pool.Get<SphereEntity>
	|-Pool.Get<SpinnerWheel>
	|-Pool.Get<Spray>
	|-Pool.Get<SprayLine>
	|-Pool.Get<SprayList>
	|-Pool.Get<StabilityEntity>
	|-Pool.Get<StorageBox>
	|-Pool.Get<SubEntityList>
	|-Pool.Get<Submarine>
	|-Pool.Get<TakeDamage>
	|-Pool.Get<TargetDetectedAIEventData>
	|-Pool.Get<Telephone>
	|-Pool.Get<ThreatDetectedAIEventData>
	|-Pool.Get<TimeSinceThreatAIEventData>
	|-Pool.Get<TimerAIEventData>
	|-Pool.Get<TirednessAboveAIEventData>
	|-Pool.Get<TrainEngine>
	|-Pool.Get<Tree>
	|-Pool.Get<TreeList>
	|-Pool.Get<UpdateItem>
	|-Pool.Get<UpdateItemContainer>
	|-Pool.Get<VehicleLift>
	|-Pool.Get<VehicleModule>
	|-Pool.Get<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.Get<VehicleVendor.PlayerStorage>
	|-Pool.Get<VehicleVendor>
	|-Pool.Get<VendingMachine.SellOrder>
	|-Pool.Get<VendingMachine.SellOrderContainer>
	|-Pool.Get<VendingMachine>
	|-Pool.Get<VoicemailEntry>
	|-Pool.Get<WaterPool>
	|-Pool.Get<WaterWell>
	|-Pool.Get<Whitelist>
	|-Pool.Get<WorldData>
	|-Pool.Get<WorldItem>
	|-Pool.Get<WorldMessage>
	|-Pool.Get<Zipline>
	|-Pool.Get<ZiplineArrivalPoint>
	|-Pool.Get<ZiplineMountable>
	|-Pool.Get<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Get<RelationshipManager.PlayerRelationships>
	|-Pool.Get<RendererCell>
	|-Pool.Get<RendererGroup>
	|-Pool.Get<SimpleList<Matrix4x4>>
	|-Pool.Get<SimpleList<WaterDynamics.InstanceData>>
	|-Pool.Get<SlicedGranularAudioClip.Grain>
	|-Pool.Get<SoundModulation.Modulator>
	|-Pool.Get<Dictionary<string, Stats.Node>>
	|-Pool.Get<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<HashSet<int>>
	|-Pool.Get<HashSet<ulong>>
	|-Pool.Get<List<AIEventData>>
	|-Pool.Get<List<AIStateContainer>>
	|-Pool.Get<List<AppChatMessage>>
	|-Pool.Get<List<AppEntityPayload.Item>>
	|-Pool.Get<List<AppMap.Monument>>
	|-Pool.Get<List<AppMarker.SellOrder>>
	|-Pool.Get<List<AppMarker>>
	|-Pool.Get<List<AppTeamInfo.Member>>
	|-Pool.Get<List<AppTeamInfo.Note>>
	|-Pool.Get<List<ArcadeGame.arcadeEnt>>
	|-Pool.Get<List<ArcadeMachine.ScoreEntry>>
	|-Pool.Get<List<BaseVehicle.MountPoint>>
	|-Pool.Get<List<CardTable.CardPlayer>>
	|-Pool.Get<List<CardTable.WinnerBreakdown.Winner>>
	|-Pool.Get<List<ClientReady.ClientInfo>>
	|-Pool.Get<List<DemoShotFloatKeyframe>>
	|-Pool.Get<List<DemoShotParentKeyframe>>
	|-Pool.Get<List<DemoShotQuaternionKeyframe>>
	|-Pool.Get<List<DemoShotVectorKeyframe>>
	|-Pool.Get<List<EggHunt.EggHunter>>
	|-Pool.Get<List<Entity>>
	|-Pool.Get<List<FileStorageCacheData>>
	|-Pool.Get<List<GameMode.PlayerScore>>
	|-Pool.Get<List<GameMode.ScoreColumn>>
	|-Pool.Get<List<GameMode.TeamInfo>>
	|-Pool.Get<List<GenericSpawner.SpawnedEnt>>
	|-Pool.Get<List<IOEntity.IOConnection.LineVec>>
	|-Pool.Get<List<IOEntity.IOConnection>>
	|-Pool.Get<List<InstrumentMidiBinding>>
	|-Pool.Get<List<InstrumentRecordingNote>>
	|-Pool.Get<List<Item>>
	|-Pool.Get<List<ItemContainer>>
	|-Pool.Get<List<LightString.StringPoint>>
	|-Pool.Get<List<LinePoint>>
	|-Pool.Get<List<MapData>>
	|-Pool.Get<List<MapNote>>
	|-Pool.Get<List<MarketTerminal.PendingOrder>>
	|-Pool.Get<List<MissionInstance>>
	|-Pool.Get<List<MissionPoint>>
	|-Pool.Get<List<MissionReward>>
	|-Pool.Get<List<Modifier>>
	|-Pool.Get<List<NeonSign.Lights>>
	|-Pool.Get<List<ObjectiveStatus>>
	|-Pool.Get<List<PathData>>
	|-Pool.Get<List<PatternFirework.Star>>
	|-Pool.Get<List<PhoneDirectory.DirectoryEntry>>
	|-Pool.Get<List<PlayerLifeStory.GenericStat>>
	|-Pool.Get<List<PlayerLifeStory.WeaponStats>>
	|-Pool.Get<List<PlayerNameID>>
	|-Pool.Get<List<PlayerTeam.TeamMember>>
	|-Pool.Get<List<PlayerTeam>>
	|-Pool.Get<List<PrefabData>>
	|-Pool.Get<List<ProjectileShoot.Projectile>>
	|-Pool.Get<List<ReclaimManager.ReclaimInfo>>
	|-Pool.Get<List<RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<List<RelationshipManager.PlayerRelationships>>
	|-Pool.Get<List<RespawnInformation.SpawnOptions>>
	|-Pool.Get<List<Tree>>
	|-Pool.Get<List<VectorData>>
	|-Pool.Get<List<VehicleVendor.PlayerStorage.PlayerStoredVehicle>>
	|-Pool.Get<List<VehicleVendor.PlayerStorage>>
	|-Pool.Get<List<VendingMachine.SellOrder>>
	|-Pool.Get<List<VoicemailEntry>>
	|-Pool.Get<List<int>>
	|-Pool.Get<List<float>>
	|-Pool.Get<List<string>>
	|-Pool.Get<List<uint>>
	|-Pool.Get<List<ulong>>
	|-Pool.Get<List<TriggerBase>>
	|-Pool.Get<Stopwatch>
	|-Pool.Get<MemoryStream>
	|-Pool.Get<WaitForSecondsRealtimeEx>
	|-Pool.Get<WaterDynamics.InstanceBatch>
	|-Pool.Get<object>
	*/

	public static List<T> GetList<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AFAD0 Offset: 0x12AE0D0 VA: 0x1812AFAD0
	|-Pool.GetList<BaseEntity.ServerFileRequest>
	|
	|-RVA: 0x12AFA70 Offset: 0x12AE070 VA: 0x1812AFA70
	|-Pool.GetList<BaseEntity>
	|-Pool.GetList<BaseNetworkable>
	|-Pool.GetList<BasePlayer>
	|-Pool.GetList<BaseVehicle>
	|-Pool.GetList<BaseVehicleModule>
	|-Pool.GetList<BuildingBlock>
	|-Pool.GetList<CollectableEasterEgg>
	|-Pool.GetList<DecalRecycle>
	|-Pool.GetList<DroppedItem>
	|-Pool.GetList<EffectRecycle>
	|-Pool.GetList<EnvironmentVolume>
	|-Pool.GetList<PlayingCard>
	|-Pool.GetList<Input.Button>
	|-Pool.GetList<FoliageCell>
	|-Pool.GetList<Gib>
	|-Pool.GetList<GraveyardFence>
	|-Pool.GetList<HitboxDefinition>
	|-Pool.GetList<IBlueprintsChanged>
	|-Pool.GetList<IClothingChanged>
	|-Pool.GetList<IEffect>
	|-Pool.GetList<IInventoryChanged>
	|-Pool.GetList<IItemAmountChanged>
	|-Pool.GetList<IItemIconChanged>
	|-Pool.GetList<IItemSetup>
	|-Pool.GetList<IItemUpdate>
	|-Pool.GetList<IOEntity>
	|-Pool.GetList<IOnParentDestroying>
	|-Pool.GetList<IOnParentSpawning>
	|-Pool.GetList<IOnPostNetworkUpdate>
	|-Pool.GetList<IOnSendNetworkUpdate>
	|-Pool.GetList<IRagdollInhert>
	|-Pool.GetList<IViewModeChanged>
	|-Pool.GetList<IViewModelUpdated>
	|-Pool.GetList<Item>
	|-Pool.GetList<ItemAmount>
	|-Pool.GetList<ItemBlueprint>
	|-Pool.GetList<LODComponent>
	|-Pool.GetList<LightOccludee>
	|-Pool.GetList<MapMarker>
	|-Pool.GetList<MaterialReplacement>
	|-Pool.GetList<MissionEntity>
	|-Pool.GetList<MorphCache>
	|-Pool.GetList<Connection>
	|-Pool.GetList<Group>
	|-Pool.GetList<Prefab>
	|-Pool.GetList<AIEventData>
	|-Pool.GetList<AIStateContainer>
	|-Pool.GetList<AppChatMessage>
	|-Pool.GetList<AppEntityPayload.Item>
	|-Pool.GetList<AppMap.Monument>
	|-Pool.GetList<AppMarker.SellOrder>
	|-Pool.GetList<AppMarker>
	|-Pool.GetList<AppTeamInfo.Member>
	|-Pool.GetList<AppTeamInfo.Note>
	|-Pool.GetList<ArcadeGame.arcadeEnt>
	|-Pool.GetList<ArcadeMachine.ScoreEntry>
	|-Pool.GetList<BaseVehicle.MountPoint>
	|-Pool.GetList<CardTable.CardPlayer>
	|-Pool.GetList<CardTable.WinnerBreakdown.Winner>
	|-Pool.GetList<ClientReady.ClientInfo>
	|-Pool.GetList<EggHunt.EggHunter>
	|-Pool.GetList<Entity>
	|-Pool.GetList<FileStorageCacheData>
	|-Pool.GetList<GameMode.PlayerScore>
	|-Pool.GetList<GameMode.ScoreColumn>
	|-Pool.GetList<GameMode.TeamInfo>
	|-Pool.GetList<GenericSpawner.SpawnedEnt>
	|-Pool.GetList<IOEntity.IOConnection.LineVec>
	|-Pool.GetList<IOEntity.IOConnection>
	|-Pool.GetList<InstrumentMidiBinding>
	|-Pool.GetList<InstrumentRecordingNote>
	|-Pool.GetList<Item>
	|-Pool.GetList<ItemContainer>
	|-Pool.GetList<LightString.StringPoint>
	|-Pool.GetList<LinePoint>
	|-Pool.GetList<MapData>
	|-Pool.GetList<MapNote>
	|-Pool.GetList<MarketTerminal.PendingOrder>
	|-Pool.GetList<MissionInstance>
	|-Pool.GetList<MissionPoint>
	|-Pool.GetList<MissionReward>
	|-Pool.GetList<Modifier>
	|-Pool.GetList<NeonSign.Lights>
	|-Pool.GetList<ObjectiveStatus>
	|-Pool.GetList<PathData>
	|-Pool.GetList<PatternFirework.Star>
	|-Pool.GetList<PhoneDirectory.DirectoryEntry>
	|-Pool.GetList<PlayerLifeStory.GenericStat>
	|-Pool.GetList<PlayerLifeStory.WeaponStats>
	|-Pool.GetList<PlayerNameID>
	|-Pool.GetList<PlayerTeam.TeamMember>
	|-Pool.GetList<PlayerTeam>
	|-Pool.GetList<PrefabData>
	|-Pool.GetList<ProjectileShoot.Projectile>
	|-Pool.GetList<ReclaimManager.ReclaimInfo>
	|-Pool.GetList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.GetList<RelationshipManager.PlayerRelationships>
	|-Pool.GetList<RespawnInformation.SpawnOptions>
	|-Pool.GetList<Tree>
	|-Pool.GetList<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.GetList<VehicleVendor.PlayerStorage>
	|-Pool.GetList<VendingMachine.SellOrder>
	|-Pool.GetList<VendingMachine>
	|-Pool.GetList<VoicemailEntry>
	|-Pool.GetList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.GetList<RendererBatch>
	|-Pool.GetList<ItemModEngineItem>
	|-Pool.GetList<ServerAdminUGCEntry>
	|-Pool.GetList<ServerAdminUGCEntryPattern>
	|-Pool.GetList<ShoutcastStreamer>
	|-Pool.GetList<SleepingBag>
	|-Pool.GetList<Socket_Base>
	|-Pool.GetList<IEnumerator>
	|-Pool.GetList<string>
	|-Pool.GetList<TechTreeData.NodeInstance>
	|-Pool.GetList<TriggerBase>
	|-Pool.GetList<AudioSource>
	|-Pool.GetList<Collider>
	|-Pool.GetList<GameObject>
	|-Pool.GetList<LODGroup>
	|-Pool.GetList<Material>
	|-Pool.GetList<MeshRenderer>
	|-Pool.GetList<ParticleSystem>
	|-Pool.GetList<Renderer>
	|-Pool.GetList<Rigidbody>
	|-Pool.GetList<SkinnedMeshRenderer>
	|-Pool.GetList<TrailRenderer>
	|-Pool.GetList<Transform>
	|-Pool.GetList<VendingMachineMapMarker>
	|-Pool.GetList<WaterVolume>
	|-Pool.GetList<Wearable>
	|-Pool.GetList<WearableHairCap>
	|-Pool.GetList<object>
	|
	|-RVA: 0x12AF650 Offset: 0x12ADC50 VA: 0x1812AF650
	|-Pool.GetList<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x12AF9B0 Offset: 0x12ADFB0 VA: 0x1812AF9B0
	|-Pool.GetList<Option>
	|
	|-RVA: 0x12AFB90 Offset: 0x12AE190 VA: 0x1812AFB90
	|-Pool.GetList<IconSkinPicker.SkinButtonSetup>
	|
	|-RVA: 0x12AF6B0 Offset: 0x12ADCB0 VA: 0x1812AF6B0
	|-Pool.GetList<ImageStorageEntity.ImageRequest>
	|
	|-RVA: 0x12AF770 Offset: 0x12ADD70 VA: 0x1812AF770
	|-Pool.GetList<InvokeAction>
	|
	|-RVA: 0x12AF830 Offset: 0x12ADE30 VA: 0x1812AF830
	|-Pool.GetList<MapView.MapMarkerCluster>
	|
	|-RVA: 0x12AFBF0 Offset: 0x12AE1F0 VA: 0x1812AFBF0
	|-Pool.GetList<MapView.SleepingBagCluster>
	|
	|-RVA: 0x12AF4D0 Offset: 0x12ADAD0 VA: 0x1812AF4D0
	|-Pool.GetList<DemoShotFloatKeyframe>
	|
	|-RVA: 0x12AF530 Offset: 0x12ADB30 VA: 0x1812AF530
	|-Pool.GetList<DemoShotParentKeyframe>
	|
	|-RVA: 0x12AF590 Offset: 0x12ADB90 VA: 0x1812AF590
	|-Pool.GetList<DemoShotQuaternionKeyframe>
	|
	|-RVA: 0x12AF5F0 Offset: 0x12ADBF0 VA: 0x1812AF5F0
	|-Pool.GetList<DemoShotVectorKeyframe>
	|
	|-RVA: 0x12AFFB0 Offset: 0x12AE5B0 VA: 0x1812AFFB0
	|-Pool.GetList<VectorData>
	|
	|-RVA: 0x12AFC50 Offset: 0x12AE250 VA: 0x1812AFC50
	|-Pool.GetList<SubmarineSonar.SonarBlip>
	|
	|-RVA: 0x12AF410 Offset: 0x12ADA10 VA: 0x1812AF410
	|-Pool.GetList<bool>
	|
	|-RVA: 0x12AF7D0 Offset: 0x12ADDD0 VA: 0x1812AF7D0
	|-Pool.GetList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.GetList<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x12AF710 Offset: 0x12ADD10 VA: 0x1812AF710
	|-Pool.GetList<int>
	|
	|-RVA: 0x12AFB30 Offset: 0x12AE130 VA: 0x1812AFB30
	|-Pool.GetList<float>
	|
	|-RVA: 0x12AFD10 Offset: 0x12AE310 VA: 0x1812AFD10
	|-Pool.GetList<uint>
	|
	|-RVA: 0x12AFD70 Offset: 0x12AE370 VA: 0x1812AFD70
	|-Pool.GetList<ulong>
	|
	|-RVA: 0x12AFDD0 Offset: 0x12AE3D0 VA: 0x1812AFDD0
	|-Pool.GetList<ValueTuple<string, AssetBundleRequest>>
	|-Pool.GetList<ValueTuple<object, object>>
	|
	|-RVA: 0x12AFCB0 Offset: 0x12AE2B0 VA: 0x1812AFCB0
	|-Pool.GetList<TraceInfo>
	|
	|-RVA: 0x12AF470 Offset: 0x12ADA70 VA: 0x1812AF470
	|-Pool.GetList<Color32>
	|
	|-RVA: 0x12AFA10 Offset: 0x12AE010 VA: 0x1812AFA10
	|-Pool.GetList<RaycastHit>
	|
	|-RVA: 0x12AFE30 Offset: 0x12AE430 VA: 0x1812AFE30
	|-Pool.GetList<Vector2>
	|
	|-RVA: 0x12AFEF0 Offset: 0x12AE4F0 VA: 0x1812AFEF0
	|-Pool.GetList<Vector3>
	|
	|-RVA: 0x12AFF50 Offset: 0x12AE550 VA: 0x1812AFF50
	|-Pool.GetList<Vector4>
	|
	|-RVA: 0x12AFE90 Offset: 0x12AE490 VA: 0x1812AFE90
	|-Pool.GetList<Vector2i>
	|
	|-RVA: 0x12AF890 Offset: 0x12ADE90 VA: 0x1812AF890
	|-Pool.GetList<MeshColliderInstance>
	|
	|-RVA: 0x12AF8F0 Offset: 0x12ADEF0 VA: 0x1812AF8F0
	|-Pool.GetList<MeshInstance>
	|
	|-RVA: 0x12AF950 Offset: 0x12ADF50 VA: 0x1812AF950
	|-Pool.GetList<MeshRendererInstance>
	*/

	public static void ResizeBuffer<T>(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579B70 Offset: 0x1578170 VA: 0x181579B70
	|-Pool.ResizeBuffer<EntityLink>
	|-Pool.ResizeBuffer<LODCell>
	|-Pool.ResizeBuffer<Networkable>
	|-Pool.ResizeBuffer<RendererCell>
	|-Pool.ResizeBuffer<RendererGroup>
	|-Pool.ResizeBuffer<object>
	*/

	public static void FillBuffer<T>(int count = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1577AE0 Offset: 0x15760E0 VA: 0x181577AE0
	|-Pool.FillBuffer<EntityLink>
	|-Pool.FillBuffer<LODCell>
	|-Pool.FillBuffer<Networkable>
	|-Pool.FillBuffer<RendererCell>
	|-Pool.FillBuffer<RendererGroup>
	|-Pool.FillBuffer<object>
	*/

	public static Pool.PoolCollection<T> FindCollection<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EB00 Offset: 0x125D100 VA: 0x18125EB00
	|-Pool.FindCollection<object>
	*/

	public static void Clear() { }

	private static void .cctor() { }

}

public class Pool.PoolCollection<T> : Pool.ICollection // TypeDefIndex: 4838
{	public T[] buffer; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ItemsInStack>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ItemsInUse>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ItemsCreated>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ItemsTaken>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <ItemsSpilled>k__BackingField; // 0x0

	public long ItemsInStack { get; set; }
	public long ItemsInUse { get; set; }
	public long ItemsCreated { get; set; }
	public long ItemsTaken { get; set; }
	public long ItemsSpilled { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public long get_ItemsInStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-Pool.PoolCollection<object>.get_ItemsInStack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemsInStack(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AFD0 Offset: 0x4995D0 VA: 0x18049AFD0
	|-Pool.PoolCollection<object>.set_ItemsInStack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public long get_ItemsInUse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	|-Pool.PoolCollection<object>.get_ItemsInUse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemsInUse(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE74D80 Offset: 0xE73380 VA: 0x180E74D80
	|-Pool.PoolCollection<object>.set_ItemsInUse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public long get_ItemsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EEAB0 Offset: 0x7ED0B0 VA: 0x1807EEAB0
	|-Pool.PoolCollection<object>.get_ItemsCreated
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemsCreated(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE73A70 Offset: 0xE72070 VA: 0x180E73A70
	|-Pool.PoolCollection<object>.set_ItemsCreated
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public long get_ItemsTaken() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	|-Pool.PoolCollection<object>.get_ItemsTaken
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemsTaken(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC15900 Offset: 0xC13F00 VA: 0x180C15900
	|-Pool.PoolCollection<object>.set_ItemsTaken
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public long get_ItemsSpilled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	|-Pool.PoolCollection<object>.get_ItemsSpilled
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ItemsSpilled(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC15910 Offset: 0xC13F10 VA: 0x180C15910
	|-Pool.PoolCollection<object>.set_ItemsSpilled
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894B90 Offset: 0x1893190 VA: 0x181894B90
	|-Pool.PoolCollection<object>..ctor
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894AB0 Offset: 0x18930B0 VA: 0x181894AB0
	|-Pool.PoolCollection<object>.Reset
	*/

	public void Add(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894850 Offset: 0x1892E50 VA: 0x181894850
	|-Pool.PoolCollection<object>.Add
	*/

	private void Facepunch.Pool.ICollection.Add(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1894A10 Offset: 0x1893010 VA: 0x181894A10
	|-Pool.PoolCollection<object>.Facepunch.Pool.ICollection.Add
	*/

}

public class Pool : ConsoleSystem // TypeDefIndex: 11955
{	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int mode; // 0x0
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool prewarm; // 0x4
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool enabled; // 0x5
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool debug; // 0x6


	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void print_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void print_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void print_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void clear_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void clear_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void clear_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static void export_prefabs(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Pool.<>c // TypeDefIndex: 11956
{	public static readonly Pool.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, Pool.ICollection>, long> <>9__4_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal long <print_memory>b__4_0(KeyValuePair<Type, Pool.ICollection> x) { }

}

