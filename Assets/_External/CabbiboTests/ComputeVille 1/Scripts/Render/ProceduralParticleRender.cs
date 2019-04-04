﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ComputeVille{
public class ProceduralParticleRender : ProceduralRender {


  public override void Render(){
    material.SetPass(0);
    material.SetBuffer("_vertBuffer", buffer._buffer);
    material.SetInt("_Count",buffer.count);
    Graphics.DrawProceduralNow(MeshTopology.Triangles, buffer.count * 3 * 2 );
  }


}
}