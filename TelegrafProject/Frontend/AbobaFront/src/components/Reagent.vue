<template>
  <div class="reagents" style="display: flex">
    <div class="reagent" style="margin: 20px; background-color: #909399; border-radius: 10px; padding: 10px; width: 100%; cursor: pointer;">
      <h1>Reagent</h1>
      <div>2025-07-01 00:05:00.4815|DEBUG|Topshelf.Hosts.ConsoleRunHost|Starting up as a console
        application
      </div>
      <div>2025-07-01 00:05:00.4922|INFO|Core.AnalysisResultReciever|Reagent service start</div>
      <div>025-07-01 00:05:00.8741|FATAL|Core.AnalysisResultReciever|System.Net.Sockets.SocketException
        (0x80004005):
      </div>
    </div>
    <div class="reagent_saver" style="margin: 20px; background-color: #909399; border-radius: 10px; padding: 10px; width: 100%; cursor: pointer;">
      <h1>Reagent-Saver</h1>
      <div>2025-07-01 00:05:00.4815|DEBUG|Topshelf.Hosts.ConsoleRunHost|Starting up as a console
        application
      </div>
      <div>2025-07-01 00:05:00.4922|INFO|Core.AnalysisResultReciever|Reagent service start</div>
      <div>025-07-01 00:05:00.8741|FATAL|Core.AnalysisResultReciever|System.Net.Sockets.SocketException
        (0x80004005):
      </div>
    </div>
  </div>
  <div style=" display:flex; justify-content: space-around">
    <el-button style="margin-left: 20px" @click="handleCLickLogs">Развернуть Reagent</el-button>
    <el-button style="margin-left: 20px" @click="handleCLickLogs">Развернуть Reagent-Saver</el-button>
  </div>
</template>

<script setup lang="ts">

</script>


<style scoped>

</style>