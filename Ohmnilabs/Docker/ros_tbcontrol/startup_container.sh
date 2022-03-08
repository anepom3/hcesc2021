#!/bin/bash
# docker pull $IMAGE_NAME:$IMAGE_TAG
#docker run -it --name ros_tbcontrol --network host --privileged -v /dev:/dev -e ROS_IP = 10.0.0.243 ohmni_unity:ros_base
docker run -it --network host --privileged -v /dev:/dev ohmni_unity:ros_base