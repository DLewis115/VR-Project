using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MoonMovement : MonoBehaviour {

    public float speed;
    public float distance;

    private Vector3[] thePath;
    private float pathLength;

    public Text myTimer;
    public float startTime;

    void Start()
    {
        thePath = iTweenPath.GetPath("MoonMovement");
        pathLength = iTween.PathLength(thePath);
        startTime = Time.time;
    }

    void Update()
    {
        distance += speed * Time.deltaTime;
        float perc = distance / pathLength;
        //iTween.PutOnPath(gameObject, thePath, perc);
        //this.transform.LookAt(iTween.PointOnPath(thePath, perc + 0.005f));
        iTween.PutOnPath(gameObject, path, perc);
        this.transform.LookAt(iTween.PointOnPath(path, perc + 0.001f));
        if (distance >= pathLength)
        {
            distance = 0;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        myTimer.text = minutes + ":" + seconds;
    }

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed/10;
    }

    private Vector3[] path =
    {
        new Vector3 { x = 332, y = 7.6f, z = 590 }, //Node1
        new Vector3 { x = 332, y = 5.8f, z = 600 }, //Node2
        new Vector3 { x = 332, y = 4.4f, z = 610 }, //Node3
        new Vector3 { x = 332, y = 3.4f, z = 620 }, //Node4
        new Vector3 { x = 332, y = 2.7f, z = 630 }, //Node5
        new Vector3 { x = 332, y = 2.3f, z = 640 }, //Node6
        new Vector3 { x = 332, y = 2f, z = 650 }, //Node7
        new Vector3 { x = 332, y = 2f, z = 660 }, //Node8
        new Vector3 { x = 332, y = 2f, z = 670 }, //Node9
        new Vector3 { x = 332, y = 2f, z = 680 }, //Node10
        new Vector3 { x = 332, y = 2f, z = 690 }, //Node11
        new Vector3 { x = 332, y = 2f, z = 700 }, //Node12
        new Vector3 { x = 332, y = 2f, z = 710 }, //Node13
        new Vector3 { x = 332, y = 2f, z = 720 }, //Node14
        new Vector3 { x = 332, y = 2f, z = 730 }, //Node15
        new Vector3 { x = 332, y = 2f, z = 740 }, //Node16
        new Vector3 { x = 332, y = 2f, z = 750 }, //Node17
        new Vector3 { x = 332, y = 2f, z = 760 }, //Node18
        new Vector3 { x = 332, y = 2f, z = 770 }, //Node19
        new Vector3 { x = 332, y = 2f, z = 780 }, //Node20
        new Vector3 { x = 332, y = 2f, z = 790 }, //Node21
        new Vector3 { x = 332, y = 2f, z = 800 }, //Node22
        new Vector3 { x = 332, y = 2f, z = 810 }, //Node23
        new Vector3 { x = 332, y = 2f, z = 820 }, //Node24
        new Vector3 { x = 332, y = 2f, z = 830 }, //Node25
        new Vector3 { x = 332, y = 2f, z = 840 }, //Node26
        new Vector3 { x = 332, y = 2.1f, z = 850 }, //Node27
        new Vector3 { x = 332, y = 2.5f, z = 860 }, //Node28
        new Vector3 { x = 332, y = 3.1f, z = 870 }, //Node29
        new Vector3 { x = 332, y = 3.7f, z = 880 }, //Node30
        new Vector3 { x = 332, y = 5f, z = 890 }, //Node31
        new Vector3 { x = 332, y = 6.9f, z = 900 }, //Node32
        new Vector3 { x = 332, y = 8.8f, z = 910 }, //Node33
        new Vector3 { x = 332, y = 14f, z = 920 }, //Node34
        new Vector3 { x = 332, y = 20.5f, z = 930 }, //Node35
        new Vector3 { x = 336, y = 20.9f, z = 939 }, //Node36
        new Vector3 { x = 343, y = 20.4f, z = 946 }, //Node37
        new Vector3 { x = 352, y = 20.3f, z = 950 }, //Node38
        new Vector3 { x = 362, y = 20.4f, z = 950 }, //Node39
        new Vector3 { x = 372, y = 20.1f, z = 950 }, //Node40
        new Vector3 { x = 382, y = 19.9f, z = 950 }, //Node41
        new Vector3 { x = 392, y = 19.8f, z = 950 }, //Node42
        new Vector3 { x = 401, y = 20f, z = 946 }, //Node43
        new Vector3 { x = 408, y = 18.3f, z = 939 }, //Node44
        new Vector3 { x = 415, y = 17.4f, z = 932 }, //Node45
        new Vector3 { x = 424, y = 16.6f, z = 928 }, //Node46
        new Vector3 { x = 433, y = 16.3f, z = 924 }, //Node47
        new Vector3 { x = 443, y = 15.2f, z = 924 }, //Node48
        new Vector3 { x = 452, y = 14.7f, z = 928 }, //Node49
        new Vector3 { x = 459, y = 14.3f, z = 935 }, //Node50
        new Vector3 { x = 466, y = 14.3f, z = 942 }, //Node51
        new Vector3 { x = 473, y = 13.6f, z = 949 }, //Node52
        new Vector3 { x = 480, y = 13.6f, z = 956 }, //Node53
        new Vector3 { x = 484, y = 13.6f, z = 965 }, //Node54
        new Vector3 { x = 488, y = 15.3f, z = 974 }, //Node55
        new Vector3 { x = 492, y = 16f, z = 983 }, //Node56
        new Vector3 { x = 499, y = 16.7f, z = 990 }, //Node57
        new Vector3 { x = 506, y = 16.2f, z = 997 }, //Node58
        new Vector3 { x = 515, y = 16f, z = 1001 }, //Node59
        new Vector3 { x = 524, y = 15.8f, z = 1005 }, //Node60
        new Vector3 { x = 534, y = 15.6f, z = 1005 }, //Node61
        new Vector3 { x = 544, y = 16.1f, z = 1005 }, //Node62
        new Vector3 { x = 554, y = 15.6f, z = 1005 }, //Node63
        new Vector3 { x = 564, y = 15.3f, z = 1005 }, //Node64
        new Vector3 { x = 574, y = 15.9f, z = 1005 }, //Node65
        new Vector3 { x = 584, y = 16.1f, z = 1005 }, //Node66
        new Vector3 { x = 594, y = 15.9f, z = 1005 }, //Node67
        new Vector3 { x = 604, y = 15.6f, z = 1005 }, //Node68
        new Vector3 { x = 614, y = 15.7f, z = 1005 }, //Node69
        new Vector3 { x = 624, y = 15.5f, z = 1005 }, //Node70
        new Vector3 { x = 634, y = 16.1f, z = 1005 }, //Node71
        new Vector3 { x = 644, y = 16.1f, z = 1005 }, //Node72
        new Vector3 { x = 654, y = 16.1f, z = 1005 }, //Node73
        new Vector3 { x = 664, y = 16.1f, z = 1005 }, //Node74
        new Vector3 { x = 674, y = 16.9f, z = 1005 }, //Node75
        new Vector3 { x = 684, y = 17.1f, z = 1005 }, //Node76
        new Vector3 { x = 694, y = 17.5f, z = 1005 }, //Node77
        new Vector3 { x = 704, y = 19.3f, z = 1005 }, //Node78
        new Vector3 { x = 714, y = 19.9f, z = 1005 }, //Node79
        new Vector3 { x = 724, y = 20.9f, z = 1005 }, //Node80
        new Vector3 { x = 734, y = 20.4f, z = 1005 }, //Node81
        new Vector3 { x = 744, y = 19.6f, z = 1005 }, //Node82
        new Vector3 { x = 753, y = 16.9f, z = 1001 }, //Node83
        new Vector3 { x = 762, y = 17.8f, z = 997 }, //Node84
        new Vector3 { x = 769, y = 16.6f, z = 990 }, //Node85
        new Vector3 { x = 773, y = 17f, z = 981 }, //Node86
        new Vector3 { x = 777, y = 16.6f, z = 972 }, //Node87
        new Vector3 { x = 777, y = 16.8f, z = 962 }, //Node88
        new Vector3 { x = 777, y = 15f, z = 952 }, //Node89
        new Vector3 { x = 777, y = 15.1f, z = 942 }, //Node90
        new Vector3 { x = 777, y = 15.4f, z = 932 }, //Node91
        new Vector3 { x = 777, y = 15.6f, z = 922 }, //Node92
        new Vector3 { x = 777, y = 15.8f, z = 912 }, //Node93
        new Vector3 { x = 777, y = 15f, z = 902 }, //Node94
        new Vector3 { x = 777, y = 15f, z = 892 }, //Node95
        new Vector3 { x = 777, y = 15.4f, z = 882 }, //Node96
        new Vector3 { x = 777, y = 13.8f, z = 872 }, //Node97
        new Vector3 { x = 781, y = 14f, z = 863 }, //Node98
        new Vector3 { x = 785, y = 13.7f, z = 854 }, //Node99
        new Vector3 { x = 789, y = 13f, z = 845 }, //Node100
        new Vector3 { x = 793, y = 13f, z = 836 }, //Node101
        new Vector3 { x = 797, y = 12.6f, z = 827 }, //Node102
        new Vector3 { x = 801, y = 12.5f, z = 818 }, //Node103
        new Vector3 { x = 805, y = 12.1f, z = 809 }, //Node104
        new Vector3 { x = 809, y = 12.1f, z = 800 }, //Node105
        new Vector3 { x = 813, y = 12.9f, z = 791 }, //Node106
        new Vector3 { x = 817, y = 14f, z = 782 }, //Node107
        new Vector3 { x = 821, y = 14.4f, z = 773 }, //Node108
        new Vector3 { x = 825, y = 14.7f, z = 764 }, //Node109
        new Vector3 { x = 829, y = 15f, z = 755 }, //Node110
        new Vector3 { x = 833, y = 15.9f, z = 746 }, //Node111
        new Vector3 { x = 837, y = 15.9f, z = 737 }, //Node112
        new Vector3 { x = 841, y = 15.6f, z = 728 }, //Node113
        new Vector3 { x = 845, y = 16.3f, z = 719 }, //Node114
        new Vector3 { x = 849, y = 16.5f, z = 710 }, //Node115
        new Vector3 { x = 853, y = 16.7f, z = 701 }, //Node116
        new Vector3 { x = 857, y = 17.2f, z = 692 }, //Node117
        new Vector3 { x = 861, y = 17.5f, z = 683 }, //Node118
        new Vector3 { x = 865, y = 17f, z = 674 }, //Node119
        new Vector3 { x = 869, y = 17.1f, z = 665 }, //Node120
        new Vector3 { x = 873, y = 17f, z = 656 }, //Node121
        new Vector3 { x = 877, y = 17f, z = 647 }, //Node122
        new Vector3 { x = 881, y = 16.7f, z = 638 }, //Node123
        new Vector3 { x = 885, y = 16.8f, z = 629 }, //Node124
        new Vector3 { x = 889, y = 16.7f, z = 620 }, //Node125
        new Vector3 { x = 893, y = 16.7f, z = 611 }, //Node126
        new Vector3 { x = 897, y = 16.7f, z = 602 }, //Node127
        new Vector3 { x = 901, y = 16.6f, z = 593 }, //Node128
        new Vector3 { x = 905, y = 16.3f, z = 584 }, //Node129
        new Vector3 { x = 909, y = 16.4f, z = 575 }, //Node130
        new Vector3 { x = 913, y = 15.1f, z = 566 }, //Node131
        new Vector3 { x = 913, y = 14.7f, z = 556 }, //Node132
        new Vector3 { x = 913, y = 15.5f, z = 546 }, //Node133
        new Vector3 { x = 913, y = 14.6f, z = 536 }, //Node134
        new Vector3 { x = 913, y = 14.8f, z = 526 }, //Node135
        new Vector3 { x = 913, y = 16.1f, z = 516 }, //Node136
        new Vector3 { x = 913, y = 17.8f, z = 506 }, //Node137
        new Vector3 { x = 913, y = 12f, z = 496 }, //Node138
        new Vector3 { x = 913, y = 6.6f, z = 486 }, //Node139
        new Vector3 { x = 913, y = 4f, z = 476 }, //Node140
        new Vector3 { x = 913, y = 3.2f, z = 466 }, //Node141
        new Vector3 { x = 913, y = 2.8f, z = 456 }, //Node142
        new Vector3 { x = 913, y = 2.1f, z = 446 }, //Node143
        new Vector3 { x = 913, y = 2.1f, z = 436 }, //Node144
        new Vector3 { x = 913, y = 1.9f, z = 426 }, //Node145
        new Vector3 { x = 913, y = 1.9f, z = 416 }, //Node146
        new Vector3 { x = 913, y = 1.9f, z = 406 }, //Node147
        new Vector3 { x = 913, y = 1.9f, z = 396 }, //Node148
        new Vector3 { x = 913, y = 1.9f, z = 386 }, //Node149
        new Vector3 { x = 909, y = 1.9f, z = 377 }, //Node150
        new Vector3 { x = 905, y = 1.9f, z = 368 }, //Node151
        new Vector3 { x = 901, y = 1.9f, z = 359 }, //Node152
        new Vector3 { x = 893, y = 1.9f, z = 350 }, //Node153
        new Vector3 { x = 889, y = 2.1f, z = 341 }, //Node154
        new Vector3 { x = 885, y = 2.5f, z = 332 }, //Node155
        new Vector3 { x = 881, y = 3.3f, z = 323 }, //Node156
        new Vector3 { x = 877, y = 4.8f, z = 314 }, //Node157
        new Vector3 { x = 873, y = 8.7f, z = 305 }, //Node158
        new Vector3 { x = 869, y = 17.2f, z = 296 }, //Node159
        new Vector3 { x = 869, y = 14.6f, z = 287 }, //Node160
        new Vector3 { x = 869, y = 13.3f, z = 277 }, //Node161
        new Vector3 { x = 869, y = 13.2f, z = 267 }, //Node162
        new Vector3 { x = 869, y = 13.3f, z = 257 }, //Node163
        new Vector3 { x = 873, y = 13.3f, z = 248 }, //Node164
        new Vector3 { x = 873, y = 14f, z = 238 }, //Node165
        new Vector3 { x = 873, y = 14f, z = 228 }, //Node166
        new Vector3 { x = 869, y = 15.2f, z = 219 }, //Node167
        new Vector3 { x = 862, y = 15.7f, z = 212 }, //Node168
        new Vector3 { x = 853, y = 18.4f, z = 208 }, //Node169
        new Vector3 { x = 843, y = 18.4f, z = 208 }, //Node170
        new Vector3 { x = 833, y = 17.1f, z = 208 }, //Node171
        new Vector3 { x = 823, y = 15.6f, z = 208 }, //Node172
        new Vector3 { x = 813, y = 15.6f, z = 208 }, //Node173
        new Vector3 { x = 803, y = 15.3f, z = 208 }, //Node174
        new Vector3 { x = 793, y = 15.1f, z = 208 }, //Node175
        new Vector3 { x = 783, y = 15.1f, z = 208 }, //Node176
        new Vector3 { x = 773, y = 15f, z = 208 }, //Node177
        new Vector3 { x = 763, y = 14.6f, z = 208 }, //Node178
        new Vector3 { x = 753, y = 14.3f, z = 208 }, //Node179
        new Vector3 { x = 743, y = 14f, z = 208 }, //Node180
        new Vector3 { x = 733, y = 14.3f, z = 208 }, //Node181
        new Vector3 { x = 723, y = 14.4f, z = 208 }, //Node182
        new Vector3 { x = 713, y = 14.4f, z = 208 }, //Node183
        new Vector3 { x = 703, y = 14.8f, z = 208 }, //Node184
        new Vector3 { x = 693, y = 14.5f, z = 208 }, //Node185
        new Vector3 { x = 683, y = 15.3f, z = 208 }, //Node186
        new Vector3 { x = 673, y = 15.4f, z = 208 }, //Node187
        new Vector3 { x = 663, y = 15.2f, z = 208 }, //Node188
        new Vector3 { x = 654, y = 15.4f, z = 212 }, //Node189
        new Vector3 { x = 647, y = 15.2f, z = 219 }, //Node190
        new Vector3 { x = 640, y = 15.1f, z = 226 }, //Node191
        new Vector3 { x = 633, y = 15.6f, z = 233 }, //Node192
        new Vector3 { x = 626, y = 16.4f, z = 240 }, //Node193
        new Vector3 { x = 622, y = 17.1f, z = 249 }, //Node194
        new Vector3 { x = 618, y = 15.9f, z = 258 }, //Node195
        new Vector3 { x = 614, y = 15.6f, z = 267 }, //Node196
        new Vector3 { x = 610, y = 15.7f, z = 276 }, //Node197
        new Vector3 { x = 606, y = 16.3f, z = 285 }, //Node198
        new Vector3 { x = 602, y = 17.3f, z = 294 }, //Node199
        new Vector3 { x = 598, y = 19.2f, z = 303 }, //Node200
        new Vector3 { x = 594, y = 20.2f, z = 312 }, //Node201
        new Vector3 { x = 590, y = 20.5f, z = 321 }, //Node202
        new Vector3 { x = 586, y = 20.1f, z = 330 }, //Node203
        new Vector3 { x = 582, y = 19.9f, z = 339 }, //Node204
        new Vector3 { x = 578, y = 19.7f, z = 348 }, //Node205
        new Vector3 { x = 574, y = 19f, z = 357 }, //Node206
        new Vector3 { x = 570, y = 17.3f, z = 366 }, //Node207
        new Vector3 { x = 566, y = 16.2f, z = 375 }, //Node208
        new Vector3 { x = 562, y = 16.1f, z = 384 }, //Node209
        new Vector3 { x = 555, y = 15.1f, z = 391 }, //Node210
        new Vector3 { x = 546, y = 14.8f, z = 395 }, //Node211
        new Vector3 { x = 537, y = 14.6f, z = 399 }, //Node212
        new Vector3 { x = 528, y = 14.4f, z = 403 }, //Node213
        new Vector3 { x = 519, y = 14.4f, z = 407 }, //Node214
        new Vector3 { x = 510, y = 14.6f, z = 411 }, //Node215
        new Vector3 { x = 501, y = 15.2f, z = 415 }, //Node216
        new Vector3 { x = 492, y = 17.1f, z = 419 }, //Node217
        new Vector3 { x = 483, y = 17.7f, z = 423 }, //Node218
        new Vector3 { x = 474, y = 19.2f, z = 427 }, //Node219
        new Vector3 { x = 465, y = 19f, z = 431 }, //Node220
        new Vector3 { x = 456, y = 18.5f, z = 435 }, //Node221
        new Vector3 { x = 447, y = 19.6f, z = 439 }, //Node222
        new Vector3 { x = 438, y = 20.1f, z = 443 }, //Node223
        new Vector3 { x = 429, y = 20f, z = 447 }, //Node224
        new Vector3 { x = 420, y = 17.7f, z = 451 }, //Node225
        new Vector3 { x = 411, y = 16.7f, z = 455 }, //Node226
        new Vector3 { x = 402, y = 16.5f, z = 459 }, //Node227
        new Vector3 { x = 393, y = 16.4f, z = 463 }, //Node228
        new Vector3 { x = 384, y = 16.4f, z = 467 }, //Node229
        new Vector3 { x = 375, y = 16.3f, z = 471 }, //Node230
        new Vector3 { x = 366, y = 16.4f, z = 475 }, //Node231
        new Vector3 { x = 357, y = 16.2f, z = 479 }, //Node232
        new Vector3 { x = 348, y = 15.8f, z = 483 }, //Node233
        new Vector3 { x = 339, y = 16.4f, z = 487 }, //Node234
        new Vector3 { x = 332, y = 15.7f, z = 491 }, //Node235
        new Vector3 { x = 332, y = 13.5f, z = 501 }, //Node236
        new Vector3 { x = 332, y = 14.8f, z = 511 }, //Node237
        new Vector3 { x = 332, y = 12.8f, z = 521 }, //Node238
        new Vector3 { x = 332, y = 13f, z = 531 }, //Node239
        new Vector3 { x = 332, y = 13f, z = 541 }, //Node240
        new Vector3 { x = 332, y = 13.6f, z = 551 }, //Node241
        new Vector3 { x = 332, y = 15.1f, z = 561 }, //Node242
        new Vector3 { x = 332, y = 17.4f, z = 571 }, //Node243
        new Vector3 { x = 332, y = 12.6f, z = 581 }, //Node244
        new Vector3 { x = 332, y = 7.6f, z = 590 }, //Node245
        


    };
}
