using System;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public static class Utilidades
	{
		public static void EndGame(int puntaje)
		{
			ScoreControl.control.guardarPuntajeActual(puntaje);
			GameEndHandler.gameEndHandler.isGameOver=true;
			SceneManager.LoadScene(1);
		}


	}
}

