#!/bin/bash

# [BOT CLI]
# TURN OFF tb-node
setprop ctl.stop tb-node

# PULL docker ohmnilabs image
# [tb_control_docker_image] : ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1
docker pull ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1

# RUN ohmnilabs based container
docker run -it --network host --privileged -v /dev:/dev ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1
