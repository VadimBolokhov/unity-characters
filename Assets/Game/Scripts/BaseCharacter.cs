using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    private static readonly int Death = Animator.StringToHash("Death");
    
    private Animator _animator;

    private bool _isAlive = true; 
    
    [SerializeField]
    private BaseCharacter enemy;



    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DealDamage()
    {
        if (enemy != null)
        {
            enemy.Kill();
        }
    }

    private void Kill()
    {
        if (_isAlive)
        {
            _animator.SetTrigger(Death);
            _isAlive = false;
        }
    }
}
