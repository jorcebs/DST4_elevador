using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    /// <summary>
    /// Allows you to control an elevator.
    /// </summary>
    class Elevador
    {
        private int _pisoActual; //pa' validar
        private bool _puerta;
        public int totalPisos { get; } //si no requiere validación
        
        public int pisoActual //pa' validar
        {
            get { return _pisoActual; }
        }
        public bool puerta
        {
            get { return _puerta; }
        }

        /// <summary>
        /// Create a new elevator indicating the number of floors.
        /// </summary>
        /// <param name="totalPisos"></param>
        public Elevador(int totalPisos)
        {
            this.totalPisos = totalPisos;
            _pisoActual = 1;
            _puerta = true;
            
        }

        /// <summary>
        /// Makes the elevator to go up to the next floor.
        /// </summary>
        private void subir()
        {
            if (pisoActual < totalPisos)
                _pisoActual++;
        }

        /// <summary>
        /// Makes the elevator to go down to the previous floor.
        /// </summary>
        private void bajar()
        {
            if (pisoActual > 1)
                _pisoActual--;
        }

        /// <summary>
        /// Opens the elevator's door.
        /// </summary>
        public void abrirPuerta()
        {
            if (!_puerta)
                _puerta = true;
        }

        /// <summary>
        /// Closes the elevator's door.
        /// </summary>
        public void cerrarPuerta()
        {
            if (_puerta)
                _puerta = false;
        }

        /// <summary>
        /// Makes the elevator to go to the specified floor.
        /// </summary>
        /// <param name="destino"></param>
        public void irA(int destino)
        {
            if (!_puerta)
            {
                if (destino > _pisoActual)
                    while (destino != _pisoActual)
                        subir();
                else if (destino < _pisoActual)
                    while (destino != _pisoActual)
                        bajar();
            }
        }

        /// <summary>
        /// Gets the elevator's current floor and door state.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Piso: " + _pisoActual.ToString() + "   Puerta: " + ((_puerta) ? "Abierta" : "Cerrada");
        }
    }
}