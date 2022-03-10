#!/bin/bash
docker pull ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1
# docker run -it -d --name ohmni_ros --privileged -p 10000:10000 -p 5005:5005 -v /dev:/dev ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1 bash
docker run -it --name ohmni_ros --privileged -p 10000:10000 -p 5005:5005 -v /dev:/dev ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1 bash
