using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller> {
    [SerializeField]
    private playerctrl playerPrefab ;
    [SerializeField]
    private Bullet bulletPrefab;

    public override void InstallBindings() {
        Container.BindInterfacesAndSelfTo<controller>().AsSingle();
        Container.Bind<playerctrl>().FromComponentInNewPrefab( playerPrefab ).AsSingle();
        Container.Bind<Armony>().AsSingle();

        Container.Bind<Weapon>().To<rifle>().AsSingle();
        Container.Bind<Weapon>().To<RSPN_97>().AsSingle();
        Container.Bind<Weapon>().To<M10A5>().AsSingle();
        Container.Bind<Weapon>().To<M2605>().AsSingle();
        Container.Bind<Weapon>().To<P3A1>().AsSingle();

        Container.Bind<ThePool>().AsSingle();
        Container.Bind<Bullet>().FromInstance( bulletPrefab ).AsSingle();
    }
}
