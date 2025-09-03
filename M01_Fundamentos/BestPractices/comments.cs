/// <summary>
/// Controla el movimiento básico del jugador.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Calcula y acumula la velocidad del jugador.
    /// </summary>
    /// <param name="deltaTiempo">Tiempo transcurrido desde el último frame (segundos).</param>
    public void CalcularVelocidad(float deltaTiempo) { /* ... */ }

    /// <summary>
    /// Devuelve la velocidad actual del jugador.
    /// </summary>
    /// <returns>Velocidad en unidades/segundo.</returns>
    public float ObtenerVelocidad() => 0f;
}
