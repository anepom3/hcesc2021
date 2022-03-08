#!/bin/bash

# KEY COMPONENTS
#   - [LOCAL MACHINE] Docker Image Preparation
#       - https://docs.ohmnilabs.com/develop_with_ros/
#       - PULL docker image [ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1]
#       - RUN docker image detached
#       - START new shell of docker image
#   - [OHMNI DOCKER] Setup Environment
#       - SOURCE ros-melodic distribution
#   - [OHMNI DOCKER] Install Unity's ROS_TCP_ENDPOINT
#       - https://github.com/Unity-Technologies/ROS-TCP-Endpoint
#       - CREATE catkin_ws to house ROS_TCP_ENDPOINT package
#       - COPY ROS_TCP_ENDPOINT package folder in /src of catkin_ws
#       - BUILD catkin_ws
#       - SOURCE workspace
#       - LAUNCH ROS_TCP_ENDPOINT node
#   - [LOCAL MACHINE] Unity Setup
#       - IMPORT Package manger [ROS_TCP_CONNECTOR, ROS VISUALIZER, URDF IMPORTER]
#       - COPY /tb_msgs folder from /tb_ros_common into project
#       - https://gitlab.com/ohmni-sdk/tb_ros_common
#       - GENERATE C# scripts for ROS msgs, services, and actions via Generate Messages...
#   - [OHMNI DOCKER]
#       - TODO: Create publisher script
#       - Launch publisher script 


#[LOCAL MACHINE] Pull docker
docker pull ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1 &&
#[LOCAL MACHINE] Run docker
docker run -it -d --name ohmni_ros --network host --privileged -p 10000:10000 -v /dev:/dev ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1 bash

#[OHMNI DOCKER] Ohmni ROS Image CLI 
source /opt/ros/<your ROS distro>/setup.bash

#[OHMNI DOCKER] Create catkin_ws
mkdir -p ~/catkin_ws/src
cd ~/catkin_ws/src
git clone [this repo]

#[OHMNI DOCKER] Install Unity's ROS_TCP_ENDPOINT


# Build the tb_msgs
cd ~/catkin_ws/
catkin_make -DCATKIN_WHITELIST_PACKAGES="tb_msgs"

#Then if you have other ROS node and want to talk to tb_control, source this workspace before building your node
your node ws> source ~/catkin_ws/devel/setup.bash
your node ws> catkin_make



