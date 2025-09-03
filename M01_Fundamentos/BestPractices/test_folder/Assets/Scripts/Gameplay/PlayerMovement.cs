using UnityEngine;

namespace Gameplay
{
    /// <summary>
    /// Controla el movimiento básico del jugador en el juego.
    /// </summary>
    /// <remarks>
    /// Este script debe adjuntarse al GameObject del jugador.
    /// Calcula la velocidad en función de la aceleración y la entrada del usuario.
    /// </remarks>
    public class PlayerMovement : MonoBehaviour
    {
        // ==============================
        // Campos privados (convención _camelCase)
        // ==============================
        
        private float _velocidadJugador = 0f;
        private Rigidbody2D _rigidbody;
        
        // ==============================
        // Propiedades públicas (PascalCase)
        // ==============================
        
        /// <summary>
        /// Velocidad actual del jugador en unidades/segundo.
        /// </summary>
        public float VelocidadActual => _velocidadJugador;

        // ==============================
        // Métodos Unity
        // ==============================
        
        /// <summary>
        /// Inicializa las referencias necesarias.
        /// </summary>
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        /// <summary>
        /// Se ejecuta en cada frame. Calcula el movimiento en base al input.
        /// </summary>
        private void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal"); // camelCase
            CalcularVelocidad(horizontalInput, Time.deltaTime);
        }

        /// <summary>
        /// Se ejecuta en cada frame fijo de física. Aplica la velocidad al rigidbody.
        /// </summary>
        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector2(_velocidadJugador, _rigidbody.velocity.y);
        }

        // ==============================
        // Métodos públicos
        // ==============================

        /// <summary>
        /// Calcula y acumula la velocidad del jugador.
        /// </summary>
        /// <param name="input">Entrada del usuario (-1 a 1).</param>
        /// <param name="deltaTiempo">Tiempo transcurrido desde el último frame (segundos).</param>
        public void CalcularVelocidad(float input, float deltaTiempo)
        {
            float aceleracionBase = 5f; // variable local en camelCase
            _velocidadJugador = input * aceleracionBase * deltaTiempo * 60f; 
        }

        /// <summary>
        /// Devuelve la velocidad actual del jugador.
        /// </summary>
        /// <returns>Velocidad en unidades/segundo.</returns>
        public float ObtenerVelocidad()
        {
            return _velocidadJugador;
        }
    }
}
