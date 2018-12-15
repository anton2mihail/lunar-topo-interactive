using UnityEngine;

public class VehicleMovement : MonoBehaviour {

    public Rigidbody vehicle;
    public float MotorForce;
    public WheelCollider WheelColFR;
    public WheelCollider WheelColFL;
    public WheelCollider WheelColRR;
    public WheelCollider WheelColRL;

    public Transform WheelMeshFR;
    public Transform WheelMeshFL;
    public Transform WheelMeshRR;
    public Transform WheelMeshRL;

   

    public float SteerForce;
    public float BrakeForce;
    // Use this for initialization
    private void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;

        // Acceleration
        WheelColRL.motorTorque = v;
        WheelColRR.motorTorque = v;

        // Steering
        WheelColFL.steerAngle = h;
        WheelColFR.steerAngle = h;

        // Breaks
        if(Input.GetKey(KeyCode.Space))
        {
            WheelColRL.brakeTorque = BrakeForce;
            WheelColRR.brakeTorque = BrakeForce;
        }
        // Releases breaks
        if (Input.GetKeyUp(KeyCode.Space))
        {
            WheelColRL.brakeTorque = 0;
            WheelColRR.brakeTorque = 0;
        }
        // WheelMeshFR.localEulerAngles = new Vector3(WheelMeshFR.localEulerAngles.x, WheelColFR.steerAngle - WheelMeshFR.localEulerAngles.z, WheelMeshFR.localEulerAngles.z);
        // WheelMeshFR.Rotate(0, -(WheelColFR.rpm / 60 * 360 * Time.deltaTime), 0);
        // WheelMeshFL.localEulerAngles = new Vector3(WheelMeshFL.localEulerAngles.x, WheelColFL.steerAngle - WheelMeshFL.localEulerAngles.z, WheelMeshFL.localEulerAngles.z);
        // WheelMeshFL.Rotate(0, -(WheelColFL.rpm / 60 * 360 * Time.deltaTime), 0);
        // WheelMeshRR.localEulerAngles = new Vector3(WheelMeshRR.localEulerAngles.x, WheelColRR.steerAngle - WheelMeshRR.localEulerAngles.z, WheelMeshRR.localEulerAngles.z);
        WheelMeshRR.Rotate(0, -(WheelColRR.rpm / 60 * 360 * Time.deltaTime), 0);
        // WheelMeshRL.localEulerAngles = new Vector3(WheelMeshRL.localEulerAngles.x, WheelColRL.steerAngle - WheelMeshRL.localEulerAngles.z, WheelMeshRL.localEulerAngles.z);
        WheelMeshRL.Rotate(0, -(WheelColRL.rpm / 60 * 360 * Time.deltaTime), 0);
        // SteerWheels();


    }
    //void SteerWheels ()
    //{
    //    Vector3 temp;
    //    temp = WheelMeshFR.transform.localEulerAngles;
    //    temp.x = WheelColFR.steerAngle;
    //    WheelMeshFR.transform.localEulerAngles = temp;
    //}
    //flWheel.localEulerAngles = new Vector3(flWheel.localEulerAngles.x, flWheelCollider.steerAngle - flWheel.localEulerAngles.z, flWheel.localEulerAngles.z);

    //flWheel.Rotate(flWheelCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    //frWheel.Rotate(frWheelCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    //rlWheel.Rotate(rlWheelCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
    //rrWheel.Rotate(rrWheelCollider.rpm / 60 * 360 * Time.deltaTime, 0, 0);
}
