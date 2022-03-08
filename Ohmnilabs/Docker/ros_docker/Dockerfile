FROM ros:melodic-ros-base

RUN sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys F42ED6FBAB17C654

RUN sudo apt-get update && sudo apt-get install -y vim iputils-ping net-tools python-pip dos2unix

RUN sudo -H pip install rospkg jsonpickle

ENV ROS_WORKSPACE=/catkin_ws

# Copy each directory explicitly to avoid workspace cruft
COPY ../../URDF/modified/tb_description $ROS_WORKSPACE/src/tb_description

COPY ./set-up-workspace /setup.sh

RUN /bin/bash -c "find $ROS_WORKSPACE -type f -print0 | xargs -0 dos2unix"

RUN dos2unix /tutorial && dos2unix /setup.sh && chmod +x /setup.sh && /setup.sh && rm /setup.sh

WORKDIR $ROS_WORKSPACE

# Source the workspace on sign in
RUN echo ". devel/setup.bash" >> ~/.bashrc

