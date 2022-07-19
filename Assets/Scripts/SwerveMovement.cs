using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float swerveSpeed = 0.5f;
    [SerializeField] private float maxServeAmount = 1f;


    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmount = _swerveInputSystem.MoveFactorX * Time.deltaTime * swerveSpeed;
        swerveAmount = Mathf.Clamp(value: swerveAmount, min: -maxServeAmount, max: maxServeAmount);
        transform.Translate(swerveAmount, 0, 0);
    }
}
