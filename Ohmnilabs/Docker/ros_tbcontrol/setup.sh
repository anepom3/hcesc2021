#!/bin/bash
IMAGE_NAME="ohmni_unity"
IMAGE_TAG="ros_base"
# docker pull $IMAGE_NAME:$IMAGE_TAG
docker build -t $IMAGE_NAME:$IMAGE_TAG  -f ./Dockerfile . 
docker run -it --name ros_tbcontrol --network host --privileged -v /dev:/dev -e ROS_IP = 10.0.0.243 $IMAGE_NAME:$IMAGE_TAG