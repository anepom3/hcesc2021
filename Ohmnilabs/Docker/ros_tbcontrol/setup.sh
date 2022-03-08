#!/bin/bash
IMAGE_NAME = "ohmnilabsvn/ohmni_ros"
IMAGE_TAG  = "ohmni_ros_tbcontrol_0.0.8.1"
# docker pull $IMAGE_NAME:$IMAGE_TAG
docker build -t $IMAGE_NAM:$IMAGE_TAG  -f ./Dockerfile .
docker run -it --name ros_tbcontrol --network host --privileged -v /dev:/dev -e ROS_IP = 10.0.0.243 $IMAGE_NAME:$IMAGE_TAG