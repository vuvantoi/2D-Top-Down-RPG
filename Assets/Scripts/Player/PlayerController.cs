using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    public PlayerMovement Movement { get; private set; }
    public Knockback Knockback { get; private set; }

    [SerializeField] private Transform weaponCollider;

    protected override void Awake()
    {
        base.Awake();

        Movement = GetComponent<PlayerMovement>();
        Knockback = GetComponent<Knockback>();
    }
    
    public Transform GetWeaponCollider()
    {
        return weaponCollider;
    }
    public bool FacingLeft => Movement.FacingLeft;
}