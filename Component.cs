public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 2677
{	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	protected EventHandlerList Events { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	public virtual ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	[BrowsableAttribute] // RVA: 0x9E7C0 Offset: 0x9DBC0 VA: 0x18009E7C0
	protected bool DesignMode { get; }

	// Methods

	// RVA: 0x15BF7C0 Offset: 0x15BDDC0 VA: 0x1815BF7C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x4C2860 Offset: 0x4C0E60 VA: 0x1804C2860
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x15BFA40 Offset: 0x15BE040 VA: 0x1815BFA40
	protected EventHandlerList get_Events() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 9
	public virtual ISite get_Site() { }

	// RVA: 0x15BF750 Offset: 0x15BDD50 VA: 0x1815BF750 Slot: 7
	public void Dispose() { }

	// RVA: 0x15BF570 Offset: 0x15BDB70 VA: 0x1815BF570 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15BF860 Offset: 0x15BDE60 VA: 0x1815BF860 Slot: 11
	protected virtual object GetService(Type service) { }

	// RVA: 0x15BF9F0 Offset: 0x15BDFF0 VA: 0x1815BF9F0
	protected bool get_DesignMode() { }

	// RVA: 0x15BF8C0 Offset: 0x15BDEC0 VA: 0x1815BF8C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x15BF990 Offset: 0x15BDF90 VA: 0x1815BF990
	private static void .cctor() { }

}

public class Component : Object // TypeDefIndex: 3508
{	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xB9960 Offset: 0xB8D60 VA: 0x1800B9960
	// RVA: 0x1825610 Offset: 0x1823C10 VA: 0x181825610
	public Transform get_transform() { }

	[FreeFunctionAttribute] // RVA: 0xB9A30 Offset: 0xB8E30 VA: 0x1800B9A30
	// RVA: 0x18255D0 Offset: 0x1823BD0 VA: 0x1818255D0
	public GameObject get_gameObject() { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9BA0 Offset: 0xB8FA0 VA: 0x1800B9BA0
	// RVA: 0x18251B0 Offset: 0x18237B0 VA: 0x1818251B0
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xB9C70 Offset: 0xB9070 VA: 0x1800B9C70
	// RVA: 0x1825040 Offset: 0x1823640 VA: 0x181825040
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EAB0 Offset: 0x159D0B0 VA: 0x18159EAB0
	|-Component.GetComponent<AIInformationZone>
	|-Component.GetComponent<AddNewEventUIButton>
	|-Component.GetComponent<AddNewStateUIButton>
	|-Component.GetComponent<AdvancedChristmasLights>
	|-Component.GetComponent<AmbienceZone>
	|-Component.GetComponent<AmbientLightLOD>
	|-Component.GetComponent<AnimalSkin>
	|-Component.GetComponent<AnimationEvents>
	|-Component.GetComponent<ArcadeEntity>
	|-Component.GetComponent<ArticulatedOccludee>
	|-Component.GetComponent<BaseCollision>
	|-Component.GetComponent<BaseCombatEntity>
	|-Component.GetComponent<BaseEntity>
	|-Component.GetComponent<BaseEventUI>
	|-Component.GetComponent<BaseMelee>
	|-Component.GetComponent<BaseMeshPaintable>
	|-Component.GetComponent<BasePlayer>
	|-Component.GetComponent<BaseProjectile>
	|-Component.GetComponent<BaseStateUI>
	|-Component.GetComponent<BowWeapon>
	|-Component.GetComponent<BuildingBlock>
	|-Component.GetComponent<CardReader>
	|-Component.GetComponent<CargoShip>
	|-Component.GetComponent<ChippyArcadeGame>
	|-Component.GetComponent<ChippyBoss>
	|-Component.GetComponent<CollectableEasterEgg>
	|-Component.GetComponent<ColliderInfo>
	|-Component.GetComponent<CommandBufferManager>
	|-Component.GetComponent<CommunityEntity.FadeOut>
	|-Component.GetComponent<ComputerStation>
	|-Component.GetComponent<CoverageQueryFlare>
	|-Component.GetComponent<DamageRenderer>
	|-Component.GetComponent<DecorComponent>
	|-Component.GetComponent<DeferredDecal>
	|-Component.GetComponent<Deployable>
	|-Component.GetComponent<DistanceFlareLOD>
	|-Component.GetComponent<Door>
	|-Component.GetComponent<DudTimedExplosive>
	|-Component.GetComponent<DungeonBaseLink>
	|-Component.GetComponent<ERSurfaceScript>
	|-Component.GetComponent<ERModularBase>
	|-Component.GetComponent<ERModularRoad>
	|-Component.GetComponent<ERPrefabInstance>
	|-Component.GetComponent<ERRoundabouts>
	|-Component.GetComponent<ERSideObjectInstance>
	|-Component.GetComponent<EggSwap>
	|-Component.GetComponent<ElectricBattery>
	|-Component.GetComponent<EnumListItemUI>
	|-Component.GetComponent<FPSGraph>
	|-Component.GetComponent<Skeleton>
	|-Component.GetComponent<FishingBobber>
	|-Component.GetComponent<FishingRodViewmodel>
	|-Component.GetComponent<FootstepEffects>
	|-Component.GetComponent<IProvider>
	|-Component.GetComponent<Gib>
	|-Component.GetComponent<GlassPane>
	|-Component.GetComponent<GrenadeWeapon>
	|-Component.GetComponent<GrowableEntity>
	|-Component.GetComponent<Hammer>
	|-Component.GetComponent<HeldEntity>
	|-Component.GetComponent<HideIfOwnerFirstPerson>
	|-Component.GetComponent<HitboxSystem>
	|-Component.GetComponent<HorseCorpse>
	|-Component.GetComponent<IAIDesign>
	|-Component.GetComponent<IAudioConnectionSource>
	|-Component.GetComponent<IBatchingHandler>
	|-Component.GetComponent<IDraggable>
	|-Component.GetComponent<IItemContainerEntity>
	|-Component.GetComponent<IOEntity>
	|-Component.GetComponent<IRFObject>
	|-Component.GetComponent<IRemoteControllable>
	|-Component.GetComponent<ImageEffectComposite>
	|-Component.GetComponent<Impostor>
	|-Component.GetComponent<InstrumentKeyController>
	|-Component.GetComponent<InstrumentViewmodel>
	|-Component.GetComponent<InvisibleVendingMachine>
	|-Component.GetComponent<IronSights>
	|-Component.GetComponent<ItemBlueprint>
	|-Component.GetComponent<ItemCrafter>
	|-Component.GetComponent<ItemDefinition>
	|-Component.GetComponent<ItemFootstepSounds>
	|-Component.GetComponent<ItemIcon>
	|-Component.GetComponent<ItemModAnimalEquipment>
	|-Component.GetComponent<ItemModAssociatedEntityMobile>
	|-Component.GetComponent<ItemModChildIO>
	|-Component.GetComponent<ItemModConsumable>
	|-Component.GetComponent<ItemModConsume>
	|-Component.GetComponent<ItemModContainer>
	|-Component.GetComponent<ItemModDeployable>
	|-Component.GetComponent<ItemModEntity>
	|-Component.GetComponent<ItemModKeycard>
	|-Component.GetComponent<ItemModPetStats>
	|-Component.GetComponent<ItemModProjectile>
	|-Component.GetComponent<ItemModRFListener>
	|-Component.GetComponent<ItemModSign>
	|-Component.GetComponent<ItemModWearable>
	|-Component.GetComponent<LODComponent>
	|-Component.GetComponent<LODComponentParticleSystem>
	|-Component.GetComponent<LightEx>
	|-Component.GetComponent<LightLOD>
	|-Component.GetComponent<LightOccludee>
	|-Component.GetComponent<LiquidContainer>
	|-Component.GetComponent<LiquidWeaponEffects>
	|-Component.GetComponent<LootPanel>
	|-Component.GetComponent<MagnetLiftable>
	|-Component.GetComponent<MaterialColorLerp>
	|-Component.GetComponent<MeshLOD>
	|-Component.GetComponent<Model>
	|-Component.GetComponent<MorphCache>
	|-Component.GetComponent<NeedsCursor>
	|-Component.GetComponent<NeedsKeyboard>
	|-Component.GetComponent<OnePoleLowpassFilter>
	|-Component.GetComponent<PagerEntity>
	|-Component.GetComponent<PaintableItem>
	|-Component.GetComponent<Planner>
	|-Component.GetComponent<PlanterBox>
	|-Component.GetComponent<PlayerBlueprints>
	|-Component.GetComponent<PlayerEyes>
	|-Component.GetComponent<PlayerInput>
	|-Component.GetComponent<PlayerInventory>
	|-Component.GetComponent<PlayerLoot>
	|-Component.GetComponent<PlayerMetabolism>
	|-Component.GetComponent<PlayerModel>
	|-Component.GetComponent<PlayerModelHair>
	|-Component.GetComponent<PlayerModelHairCap>
	|-Component.GetComponent<PlayerModifiers>
	|-Component.GetComponent<PlayerVoiceRecorder>
	|-Component.GetComponent<PlayerVoiceSpeaker>
	|-Component.GetComponent<PlayingCardsViewmodel>
	|-Component.GetComponent<PostOpaqueDepth>
	|-Component.GetComponent<PowerLineWireConnectionHelper>
	|-Component.GetComponent<Projectile>
	|-Component.GetComponent<RealmedRemove>
	|-Component.GetComponent<RendererBatch>
	|-Component.GetComponent<CoverPointVolume>
	|-Component.GetComponent<IEntity>
	|-Component.GetComponent<ItemModEngineItem>
	|-Component.GetComponent<ItemModVehicleModule>
	|-Component.GetComponent<RustButton>
	|-Component.GetComponent<RustImageButton>
	|-Component.GetComponent<RustInput>
	|-Component.GetComponent<RustLayout>
	|-Component.GetComponent<RustText>
	|-Component.GetComponent<SteamInventoryItem>
	|-Component.GetComponent<WorkshopPlayerPreview>
	|-Component.GetComponent<SedanWheelSmoke>
	|-Component.GetComponent<ServerHistoryItem>
	|-Component.GetComponent<SkinnedMultiMesh>
	|-Component.GetComponent<Sound>
	|-Component.GetComponent<SoundFadeHQAudioFilter>
	|-Component.GetComponent<SpriteArcadeEntity>
	|-Component.GetComponent<SteamInventory>
	|-Component.GetComponent<SwapArrows>
	|-Component.GetComponent<SwapKeycard>
	|-Component.GetComponent<SwapRPG>
	|-Component.GetComponent<TMP_InputField>
	|-Component.GetComponent<TMP_Text>
	|-Component.GetComponent<TextMeshPro>
	|-Component.GetComponent<TextMeshProUGUI>
	|-Component.GetComponent<TOD_Animation>
	|-Component.GetComponent<TOD_Components>
	|-Component.GetComponent<TOD_Resources>
	|-Component.GetComponent<TOD_Scattering>
	|-Component.GetComponent<TOD_Sky>
	|-Component.GetComponent<TOD_Time>
	|-Component.GetComponent<TechTreeDialog>
	|-Component.GetComponent<TechTreeEntry>
	|-Component.GetComponent<TerrainAlphaMap>
	|-Component.GetComponent<TerrainBiomeMap>
	|-Component.GetComponent<TerrainBlendMap>
	|-Component.GetComponent<TerrainCollision>
	|-Component.GetComponent<TerrainCollisionProxy>
	|-Component.GetComponent<TerrainColors>
	|-Component.GetComponent<TerrainDistanceMap>
	|-Component.GetComponent<TerrainHeightMap>
	|-Component.GetComponent<TerrainMeta>
	|-Component.GetComponent<TerrainPath>
	|-Component.GetComponent<TerrainPhysics>
	|-Component.GetComponent<TerrainPlacementMap>
	|-Component.GetComponent<TerrainQuality>
	|-Component.GetComponent<TerrainSplatMap>
	|-Component.GetComponent<TerrainTexturing>
	|-Component.GetComponent<TerrainTopologyMap>
	|-Component.GetComponent<TerrainWaterMap>
	|-Component.GetComponent<Tooltip>
	|-Component.GetComponent<TreadAnimator>
	|-Component.GetComponent<TriggerLadder>
	|-Component.GetComponent<UIEscapeCapture>
	|-Component.GetComponent<Animation>
	|-Component.GetComponent<Animator>
	|-Component.GetComponent<AudioSource>
	|-Component.GetComponent<BoxCollider>
	|-Component.GetComponent<Camera>
	|-Component.GetComponent<Canvas>
	|-Component.GetComponent<CanvasGroup>
	|-Component.GetComponent<CanvasRenderer>
	|-Component.GetComponent<CapsuleCollider>
	|-Component.GetComponent<Collider>
	|-Component.GetComponent<EventSystem>
	|-Component.GetComponent<LODGroup>
	|-Component.GetComponent<Light>
	|-Component.GetComponent<LineRenderer>
	|-Component.GetComponent<MeshCollider>
	|-Component.GetComponent<MeshFilter>
	|-Component.GetComponent<MeshRenderer>
	|-Component.GetComponent<ParticleSystem>
	|-Component.GetComponent<ParticleSystemRenderer>
	|-Component.GetComponent<Projector>
	|-Component.GetComponent<RectTransform>
	|-Component.GetComponent<ReflectionProbe>
	|-Component.GetComponent<Renderer>
	|-Component.GetComponent<PostProcessLayer>
	|-Component.GetComponent<PostProcessVolume>
	|-Component.GetComponent<Rigidbody>
	|-Component.GetComponent<SkinnedMeshRenderer>
	|-Component.GetComponent<SphereCollider>
	|-Component.GetComponent<SpriteRenderer>
	|-Component.GetComponent<Terrain>
	|-Component.GetComponent<TerrainCollider>
	|-Component.GetComponent<TrailRenderer>
	|-Component.GetComponent<Transform>
	|-Component.GetComponent<Button>
	|-Component.GetComponent<CanvasScaler>
	|-Component.GetComponent<Graphic>
	|-Component.GetComponent<GraphicRaycaster>
	|-Component.GetComponent<ILayoutController>
	|-Component.GetComponent<Image>
	|-Component.GetComponent<InputField>
	|-Component.GetComponent<LayoutElement>
	|-Component.GetComponent<Mask>
	|-Component.GetComponent<RawImage>
	|-Component.GetComponent<ScrollRect>
	|-Component.GetComponent<Slider>
	|-Component.GetComponent<Text>
	|-Component.GetComponent<Toggle>
	|-Component.GetComponent<ToggleGroup>
	|-Component.GetComponent<VerticalLayoutGroup>
	|-Component.GetComponent<VideoPlayer>
	|-Component.GetComponent<WindZone>
	|-Component.GetComponent<TriggerZone>
	|-Component.GetComponent<VolumetricLightBeam>
	|-Component.GetComponent<VehicleModuleEngine>
	|-Component.GetComponent<VehicleModuleInformationPanel.IVehicleModuleInfo>
	|-Component.GetComponent<VehicleSpawner>
	|-Component.GetComponent<VertexColorStream>
	|-Component.GetComponent<ViewModel>
	|-Component.GetComponent<ViewmodelAspectOffset>
	|-Component.GetComponent<ViewmodelAttachment>
	|-Component.GetComponent<ViewmodelBob>
	|-Component.GetComponent<ViewmodelLower>
	|-Component.GetComponent<ViewmodelMountedAnchor>
	|-Component.GetComponent<ViewmodelPunch>
	|-Component.GetComponent<ViewmodelSway>
	|-Component.GetComponent<WaterCollision>
	|-Component.GetComponent<WaterDynamics>
	|-Component.GetComponent<WearableHairCap>
	|-Component.GetComponent<WearableReplacementByRace>
	|-Component.GetComponent<WearableShadowLod>
	|-Component.GetComponent<WireTool>
	|-Component.GetComponent<flamethrowerFire>
	|-Component.GetComponent<v_chainsaw>
	|-Component.GetComponent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE890 Offset: 0xBECE90 VA: 0x180BEE890
	|-Component.TryGetComponent<BeltBarIcon>
	|-Component.TryGetComponent<BoneRetarget>
	|-Component.TryGetComponent<ColliderInfo>
	|-Component.TryGetComponent<ConnectedSpeaker>
	|-Component.TryGetComponent<DragMeCustomParent>
	|-Component.TryGetComponent<DungeonGridInfo>
	|-Component.TryGetComponent<HitboxSystem>
	|-Component.TryGetComponent<IAnimationEventReceiver>
	|-Component.TryGetComponent<IAudioConnectionSource>
	|-Component.TryGetComponent<IAutoLayout>
	|-Component.TryGetComponent<IContainerSounds>
	|-Component.TryGetComponent<IPropRenderNotify>
	|-Component.TryGetComponent<InstrumentKeyController>
	|-Component.TryGetComponent<ItemModCassette>
	|-Component.TryGetComponent<ItemModCompostable>
	|-Component.TryGetComponent<ItemModDeployable>
	|-Component.TryGetComponent<ItemModEntity>
	|-Component.TryGetComponent<ItemModProjectile>
	|-Component.TryGetComponent<LootContainer>
	|-Component.TryGetComponent<NewsParagraph>
	|-Component.TryGetComponent<RendererLOD>
	|-Component.TryGetComponent<SprayCanViewmodel>
	|-Component.TryGetComponent<SwapKeycard>
	|-Component.TryGetComponent<object>
	|-Component.TryGetComponent<MeshFilter>
	|-Component.TryGetComponent<ParticleSystem>
	|-Component.TryGetComponent<Renderer>
	|-Component.TryGetComponent<ViewModel>
	|-Component.TryGetComponent<WaterBody>
	|-Component.TryGetComponent<v_chainsaw>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB9BA0 Offset: 0xB8FA0 VA: 0x1800B9BA0
	// RVA: 0x18250A0 Offset: 0x18236A0 VA: 0x1818250A0
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E830 Offset: 0x159CE30 VA: 0x18159E830
	|-Component.GetComponentInChildren<VirtualScroll>
	|-Component.GetComponentInChildren<Publisher>
	|-Component.GetComponentInChildren<WorkshopView>
	|-Component.GetComponentInChildren<MeshRenderer>
	|-Component.GetComponentInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E910 Offset: 0x159CF10 VA: 0x18159E910
	|-Component.GetComponentInChildren<AnimationEvents>
	|-Component.GetComponentInChildren<BlendedLoopEngineSound>
	|-Component.GetComponentInChildren<ConstructionPlaceholder>
	|-Component.GetComponentInChildren<DungeonBaseLink>
	|-Component.GetComponentInChildren<DungeonGridInfo>
	|-Component.GetComponentInChildren<DungeonGridLink>
	|-Component.GetComponentInChildren<DungeonVolume>
	|-Component.GetComponentInChildren<IAirSupply>
	|-Component.GetComponentInChildren<Impostor>
	|-Component.GetComponentInChildren<LODComponent>
	|-Component.GetComponentInChildren<MeshPaintController>
	|-Component.GetComponentInChildren<MeshPaintableSource>
	|-Component.GetComponentInChildren<NeedsCursor>
	|-Component.GetComponentInChildren<NeedsMouseButtons>
	|-Component.GetComponentInChildren<NeedsMouseWheel>
	|-Component.GetComponentInChildren<OutlineObject>
	|-Component.GetComponentInChildren<RustButton>
	|-Component.GetComponentInChildren<SteamInventoryItem>
	|-Component.GetComponentInChildren<TextMeshProUGUI>
	|-Component.GetComponentInChildren<TreeLOD>
	|-Component.GetComponentInChildren<Animator>
	|-Component.GetComponentInChildren<CanvasGroup>
	|-Component.GetComponentInChildren<Collider>
	|-Component.GetComponentInChildren<EventSystem>
	|-Component.GetComponentInChildren<TrailRenderer>
	|-Component.GetComponentInChildren<ScrollRect>
	|-Component.GetComponentInChildren<Text>
	|-Component.GetComponentInChildren<Toggle>
	|-Component.GetComponentInChildren<WaterBody>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1825290 Offset: 0x1823890 VA: 0x181825290
	public Component[] GetComponentsInChildren(Type t) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A374F0 Offset: 0x1A35AF0 VA: 0x181A374F0
	|-Component.GetComponentsInChildren<AchievementTodo>
	|-Component.GetComponentsInChildren<BaseScreenShake>
	|-Component.GetComponentsInChildren<BaseViewModel>
	|-Component.GetComponentsInChildren<BuildingProximity>
	|-Component.GetComponentsInChildren<EntityComponentBase>
	|-Component.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-Component.GetComponentsInChildren<IVitalNotice>
	|-Component.GetComponentsInChildren<ItemInformationPanel>
	|-Component.GetComponentsInChildren<ItemMod>
	|-Component.GetComponentsInChildren<MissionsHUDToDo>
	|-Component.GetComponentsInChildren<ModelConditionTest>
	|-Component.GetComponentsInChildren<ProceduralComponent>
	|-Component.GetComponentsInChildren<ProtectionValue>
	|-Component.GetComponentsInChildren<RendererBatch>
	|-Component.GetComponentsInChildren<NetGraphRow>
	|-Component.GetComponentsInChildren<MaterialRow>
	|-Component.GetComponentsInChildren<ServerBrowserList>
	|-Component.GetComponentsInChildren<SingletonComponent>
	|-Component.GetComponentsInChildren<SocketHandle>
	|-Component.GetComponentsInChildren<SocketMod>
	|-Component.GetComponentsInChildren<Socket_Base>
	|-Component.GetComponentsInChildren<SoundPlayer>
	|-Component.GetComponentsInChildren<TerrainPathConnect>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Canvas>
	|-Component.GetComponentsInChildren<LODGroup>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshCollider>
	|-Component.GetComponentsInChildren<MeshFilter>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<ParticleSystemRenderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<GraphicRaycaster>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<ViewmodelIgniteToggle>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB510 Offset: 0x5C9B10 VA: 0x1805CB510
	|-Component.GetComponentsInChildren<BaseVehicleModule>
	|-Component.GetComponentsInChildren<BoneRetarget>
	|-Component.GetComponentsInChildren<ComponentInfo>
	|-Component.GetComponentsInChildren<DungeonBaseSocket>
	|-Component.GetComponentsInChildren<DungeonVolume>
	|-Component.GetComponentsInChildren<EnvironmentVolume>
	|-Component.GetComponentsInChildren<SkeletonSkin>
	|-Component.GetComponentsInChildren<FruitScale>
	|-Component.GetComponentsInChildren<IRagdollInhert>
	|-Component.GetComponentsInChildren<LODComponent>
	|-Component.GetComponentsInChildren<LifeScale>
	|-Component.GetComponentsInChildren<LightOccludee>
	|-Component.GetComponentsInChildren<PlayerModelSkin>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<CharacterJoint>
	|-Component.GetComponentsInChildren<ConfigurableJoint>
	|-Component.GetComponentsInChildren<Joint>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<Wearable>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C40 Offset: 0x15A2240 VA: 0x1815A3C40
	|-Component.GetComponentsInChildren<AIMovePoint>
	|-Component.GetComponentsInChildren<ArcadeEntity>
	|-Component.GetComponentsInChildren<BasePathNode>
	|-Component.GetComponentsInChildren<BlueprintCraftGridRow>
	|-Component.GetComponentsInChildren<ContactsEntry>
	|-Component.GetComponentsInChildren<DevControlsTab>
	|-Component.GetComponentsInChildren<HideIfScoped>
	|-Component.GetComponentsInChildren<HitNumber>
	|-Component.GetComponentsInChildren<ItemIcon>
	|-Component.GetComponentsInChildren<ItemTextValue>
	|-Component.GetComponentsInChildren<PathInterestNode>
	|-Component.GetComponentsInChildren<PathSpeedZone>
	|-Component.GetComponentsInChildren<NetGraphItem>
	|-Component.GetComponentsInChildren<RustText>
	|-Component.GetComponentsInChildren<TimelineMarker>
	|-Component.GetComponentsInChildren<ServerBrowserTag>
	|-Component.GetComponentsInChildren<Sound>
	|-Component.GetComponentsInChildren<TMP_SubMesh>
	|-Component.GetComponentsInChildren<TMP_SubMeshUI>
	|-Component.GetComponentsInChildren<NavMeshModifier>
	|-Component.GetComponentsInChildren<NavMeshModifierVolume>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<Light>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<Button>
	|-Component.GetComponentsInChildren<LayoutGroup>
	|-Component.GetComponentsInChildren<Toggle>
	|-Component.GetComponentsInChildren<VehicleLight>
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB570 Offset: 0x5C9B70 VA: 0x1805CB570
	|-Component.GetComponentsInChildren<HitboxDefinition>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntry>
	|-Component.GetComponentsInChildren<ServerAdminUGCEntryPattern>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<AudioSource>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<Component>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<TrailRenderer>
	|-Component.GetComponentsInChildren<Transform>
	|-Component.GetComponentsInChildren<VolumetricLightBeam>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xB9BA0 Offset: 0xB8FA0 VA: 0x1800B9BA0
	// RVA: 0x1825130 Offset: 0x1823730 VA: 0x181825130
	public Component GetComponentInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E9E0 Offset: 0x159CFE0 VA: 0x18159E9E0
	|-Component.GetComponentInParent<BaseEntity>
	|-Component.GetComponentInParent<BaseEventUI>
	|-Component.GetComponentInParent<BaseMountable>
	|-Component.GetComponentInParent<BaseNetworkable>
	|-Component.GetComponentInParent<BaseVehicleModule>
	|-Component.GetComponentInParent<ChangeSignText>
	|-Component.GetComponentInParent<DeployableBoomBox>
	|-Component.GetComponentInParent<Skeleton>
	|-Component.GetComponentInParent<HitboxSystem>
	|-Component.GetComponentInParent<IronSights>
	|-Component.GetComponentInParent<LifeInfographic>
	|-Component.GetComponentInParent<MLRS>
	|-Component.GetComponentInParent<MapView>
	|-Component.GetComponentInParent<MonumentInfo>
	|-Component.GetComponentInParent<Ragdoll>
	|-Component.GetComponentInParent<WorkshopInterface>
	|-Component.GetComponentInParent<WorkshopItemEditor>
	|-Component.GetComponentInParent<Canvas>
	|-Component.GetComponentInParent<CanvasGroup>
	|-Component.GetComponentInParent<CanvasScaler>
	|-Component.GetComponentInParent<Dropdown>
	|-Component.GetComponentInParent<ILayoutGroup>
	|-Component.GetComponentInParent<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A374F0 Offset: 0x1A35AF0 VA: 0x181A374F0
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB510 Offset: 0x5C9B10 VA: 0x1805CB510
	|-Component.GetComponentsInParent<object>
	|-Component.GetComponentsInParent<Canvas>
	|-Component.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3C40 Offset: 0x15A2240 VA: 0x1815A3C40
	|-Component.GetComponentsInParent<BaseRaycaster>
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: 0x18252F0 Offset: 0x18238F0 VA: 0x1818252F0
	public Component[] GetComponents(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xB9C70 Offset: 0xB9070 VA: 0x1800B9C70
	// RVA: 0x1825230 Offset: 0x1823830 VA: 0x181825230
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x1825230 Offset: 0x1823830 VA: 0x181825230
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB5A0 Offset: 0x5C9BA0 VA: 0x1805CB5A0
	|-Component.GetComponents<object>
	|-Component.GetComponents<CanvasGroup>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInputModule>
	|-Component.GetComponents<IMaterialModifier>
	|-Component.GetComponents<Mask>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A37540 Offset: 0x1A35B40 VA: 0x181A37540
	|-Component.GetComponents<EZSoftBone>
	|-Component.GetComponents<IImageEffect>
	|-Component.GetComponents<ItemMod>
	|-Component.GetComponents<LODComponentParticleSystem>
	|-Component.GetComponents<TerrainExtension>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<BaseInput>
	|-Component.GetComponents<BaseRaycaster>
	|-Component.GetComponents<object>
	*/

	// RVA: 0x1824FC0 Offset: 0x18235C0 VA: 0x181824FC0
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xB9FA0 Offset: 0xB93A0 VA: 0x1800B9FA0
	// RVA: 0x18253E0 Offset: 0x18239E0 VA: 0x1818253E0
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1825520 Offset: 0x1823B20 VA: 0x181825520
	public void SendMessage(string methodName, object value) { }

	// RVA: 0x1825580 Offset: 0x1823B80 VA: 0x181825580
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBB570 Offset: 0xBA970 VA: 0x1800BB570
	// RVA: 0x18254B0 Offset: 0x1823AB0 VA: 0x1818254B0
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1825450 Offset: 0x1823A50 VA: 0x181825450
	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBB710 Offset: 0xBAB10 VA: 0x1800BB710
	// RVA: 0x1824F50 Offset: 0x1823550 VA: 0x181824F50
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1824F00 Offset: 0x1823500 VA: 0x181824F00
	public void BroadcastMessage(string methodName) { }

	// RVA: 0x1824EA0 Offset: 0x18234A0 VA: 0x181824EA0
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x181F9A0 Offset: 0x181DFA0 VA: 0x18181F9A0
	public void .ctor() { }

}

