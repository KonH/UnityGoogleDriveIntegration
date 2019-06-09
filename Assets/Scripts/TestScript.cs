using UnityEngine;

public class TestScript : MonoBehaviour {
	public TestWorkSheet WorkSheet;
	
	public void Start() {
		foreach ( var data in WorkSheet.dataArray ) {
			Debug.Log($"A1: {data.A1}, B1: {data.B1}, C1: {data.C1}");
		}
	}
}
