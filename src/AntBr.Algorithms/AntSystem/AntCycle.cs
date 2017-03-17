using System;
using System.Collections.Generic;
using System.Text;

namespace AntBr.Algorithms.AntSystem
{
    public class AntCycle
    {
        private static double trailQuantity;
        private static double trailSignificance;
        private static double visibilitySignificance;
        private static double evaporationCoeficient;
        private static int antNumber;
        private static int maxCyclesNumber;
        private static double initialTrail;

        private static int nodeCount;
        private static int cycleNumber;
        private static Graph graph;

        private static double[][] edgeVisibility;
        private static double[][] edgeTrail;
        private static double[][] edgeDeltaTrail;

        private System.Collections.ArrayList ants;
        private double path;
        private System.String pathNode;
    }
}
