using System;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public static class Utilidades
	{
		public static void EndGame(int puntaje)
		{
			ScoreControl.control.guardarPuntajeActual(puntaje);
			SceneManager.LoadScene(1);
		}
	}
}

