﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class TrainerParamsPPO : TrainerParams
{
    [Header("Learning related")]
    [Tooltip("gamma")]
    public float rewardDiscountFactor = 0.99f;
    [Tooltip("lambda")]
    public float rewardGAEFactor = 0.95f;
    public float valueLossWeight = 1f;
    public int timeHorizon = 1000;
    [Tooltip("larger value means exploration is encouraged")]
    public float entropyLossWeight = 0.0f;
    public float clipEpsilon = 0.2f;

    
    public int batchSize = 128;
    public int bufferSizeForTrain = 2048;
    public int numEpochPerTrain = 10;

    [Range(0,1)]
    public float useHeuristicChance = 0.4f;
    
    [Header("Log related")]
    public int lossLogInterval = 1;
    public int rewardLogInterval = 10;

}
