using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 引数で指定した方向へ力を加える
    /// </summary>
    /// <param name="dir"></param>
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    /// <summary>
    /// イガグリ衝突時の処理
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // イガグリの動きを停止する
        GetComponent<Rigidbody>().isKinematic = true;

        // イガグリのパーティカルエフェクト開始
        GetComponent<ParticleSystem>().Play();

    }
}
