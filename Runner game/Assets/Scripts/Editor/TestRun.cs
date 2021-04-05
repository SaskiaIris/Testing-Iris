﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
	public class TestRun
	{
		[UnityTest]
		public IEnumerator MoveLeftWithEnumeratorPasses() {
			PlayerMotor player = GameObject.FindObjectOfType<PlayerMotor>();
			Assert.AreEqual(player.MoveLeft(), new Vector3(-1f, player.transform.position.y, player.transform.position.z));

			yield return null;
		}

		[UnityTest]
		public IEnumerator MoveRightWithEnumeratorPasses() {
			PlayerMotor player = GameObject.FindObjectOfType<PlayerMotor>();
			Assert.AreEqual(player.MoveRight(), new Vector3(1f, player.transform.position.y, player.transform.position.z));

			yield return null;
		}
	}
}