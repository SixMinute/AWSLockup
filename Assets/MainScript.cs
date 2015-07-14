using UnityEngine;
using System.Collections;
using Amazon.CognitoIdentity;
using Amazon;

public class MainScript : MonoBehaviour
{
	void Start()
	{
		new CognitoAWSCredentials("", RegionEndpoint.USEast1);
	}
}
