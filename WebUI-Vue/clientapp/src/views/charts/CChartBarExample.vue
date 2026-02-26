/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
<template>
  <CChartBar
    :datasets="defaultDatasets"
    labels="months"
  />
</template>

<script>
import { CChartBar } from '@coreui/vue-chartjs'

export default {
  name: 'CChartBarExample',
  components: { CChartBar },
  computed: {
    defaultDatasets () {
      return [
        {
          label: 'GitHub Commits',
          backgroundColor: '#f87979',
          data: [40, 20, 12, 39, 10, 40, 39, 80, 40, 20, 12, 11]
        }
      ]
    }
  }
}
</script>
